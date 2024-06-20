using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_delivery.Screens
{
    public partial class FrmFinalizar : Form
    {
        private string connectionString = @"Data Source=DESKTOP_ERICK;Initial Catalog=test_delivery;Integrated Security=true";

        public FrmFinalizar()
        {
            InitializeComponent();
            ConfigurarDataGridViews();
            
        }
        private void ConfigurarDataGridViews()
        {
            dataGridViewPedido.MultiSelect = false;
            dataGridViewPedido.SelectionChanged += dataGridViewPedido_SelectionChanged;
            dataGridViewPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAparelho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CarregarDadosPedido();
        }
        private void CarregarDadosPedido()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryPedidos = "SELECT * FROM pedido WHERE pedido_status = 'Em trânsito'";

                    using (SqlCommand command = new SqlCommand(queryPedidos, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridViewPedido.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                TratarErro(ex, "Erro ao carregar dados do pedido.");
            }
        }


        private void TratarErro(SqlException ex, string mensagem)
        {
            StringBuilder errorMessages = new StringBuilder();

            for (int i = 0; i < ex.Errors.Count; i++)
            {
                errorMessages.Append("Index #" + i + "\n" +
                    "Message: " + ex.Errors[i].Message + "\n" +
                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                    "Source: " + ex.Errors[i].Source + "\n" +
                    "Procedure: " + ex.Errors[i].Procedure + "\n");
            }

            MessageBox.Show(mensagem + "\n\n" + errorMessages.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int pedido_id = 0;

            if (dataGridViewPedido.SelectedRows.Count > 0)
            {
                if (dataGridViewPedido.SelectedRows[0].Cells["pedido_id"].Value != null)
                {
                    pedido_id = Convert.ToInt32(dataGridViewPedido.SelectedRows[0].Cells["pedido_id"].Value);

                    DialogResult result = MessageBox.Show("Você tem certeza que deseja finalizar o pedido?", "Verifique as informações antes de despachar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        FinalizarPedido(pedido_id);

                    }
                }
            }
        }

        private void FinalizarPedido(int pedidoId)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryAtualizarPedido = "UPDATE pedido SET pedido_status = 'Concluído' WHERE pedido_id = @SeuPedidoId";
                using (SqlCommand commandAtualizarPedido = new SqlCommand(queryAtualizarPedido, connection))
                {
                    commandAtualizarPedido.Parameters.AddWithValue("@SeuPedidoId", pedidoId);
                    commandAtualizarPedido.ExecuteNonQuery();
                    dataGridViewPedido.DataSource = null;
                    CarregarDadosPedido();
                    connection.Close();

                }


            }

        }
        private void dataGridViewPedido_SelectionChanged(object sender, EventArgs e)
        {
            LimparDataGrids();

            if (dataGridViewPedido.SelectedRows.Count > 0)
            {
                object pacienteIdObj = dataGridViewPedido.SelectedRows[0].Cells["paciente_id"].Value;
                object aparelhoIdObj = dataGridViewPedido.SelectedRows[0].Cells["aparelho_id"].Value;

                if (pacienteIdObj != DBNull.Value && aparelhoIdObj != DBNull.Value)
                {
                    int pacienteId = Convert.ToInt32(pacienteIdObj);
                    int aparelhoId = Convert.ToInt32(aparelhoIdObj);

                    CarregarDataGridPaciente(pacienteId);
                    CarregarDataGridAparelho(aparelhoId);
                }
                else
                {
                    MessageBox.Show("Não há pedidos para serem finalizados.", "Mensagem de Alerta.");
                }
            }
        }
        private void LimparDataGrids()
        {
            dataGridViewPaciente.DataSource = null;
            dataGridViewAparelho.DataSource = null;

        }
        private void CarregarDataGridPaciente(int pacienteId)
        {
            try
            {
                string queryPaciente = $"SELECT * FROM Paciente WHERE paciente_id = {pacienteId}";
                SqlDataAdapter adapterPaciente = new SqlDataAdapter(queryPaciente, connectionString);
                DataTable dataTablePaciente = new DataTable();
                adapterPaciente.Fill(dataTablePaciente);

                dataGridViewPaciente.DataSource = dataTablePaciente;
            }
            catch (SqlException ex)
            {
                TratarErro(ex, "Erro ao carregar dados do paciente.");
            }
        }

        private void CarregarDataGridAparelho(int aparelhoId)
        {
            try
            {
                string queryAparelho = $"SELECT * FROM Aparelho WHERE aparelho_id = {aparelhoId}";
                SqlDataAdapter adapterAparelho = new SqlDataAdapter(queryAparelho, connectionString);
                DataTable dataTableAparelho = new DataTable();
                adapterAparelho.Fill(dataTableAparelho);

                dataGridViewAparelho.DataSource = dataTableAparelho;
            }
            catch (SqlException ex)
            {
                TratarErro(ex, "Erro ao carregar dados do aparelho.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();  
            this.Hide();
        }
    }
}

