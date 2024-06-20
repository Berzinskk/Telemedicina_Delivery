using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_delivery.Screens
{
    public partial class FrmGerenciarPedidos : Form
    {
        public FrmGerenciarPedidos()
        {
            InitializeComponent();
            CarregarDadosPedido();
            dataGridViewPedido.MultiSelect = false;
            dataGridViewPedido.SelectionChanged += dataGridViewPedido_SelectionChanged;
            dataGridViewPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAparelho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dateTimePickerDataConsulta.CustomFormat = "dd/MM/yyyy HH:mm:ss";

        }
        private string connectionString = @"Data Source=DESKTOP_ERICK;Initial Catalog=test_delivery;Integrated Security=true";

        private void CarregarDadosPedido()
        {
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();



                    string query = "SELECT * FROM pedido ORDER BY data_consulta";

                    using (SqlCommand command = new SqlCommand(query, connection))
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
                // Handle exceptions
                StringBuilder Errors = new StringBuilder();

                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show("Erro ao carregar dados do paciente: " + ex.Message + "\n\n" + errorMessages.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        

        private void BtnBuscarPaciente_Click(object sender, EventArgs e)
        {
           
            string nomePaciente = textBoxNomePaciente.Text;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                // Consulta para buscar os pedidos do paciente pelo nome
                string query = @"
                    SELECT *
                    FROM pedido p
                    INNER JOIN paciente pa ON p.paciente_id = pa.paciente_id
                    AND pa.nome LIKE @NomePaciente";


                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@NomePaciente", "%" + nomePaciente + "%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Vincular dados ao DataGridView de Pedidos
                dataGridViewPedido.DataSource = dataTable;

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            int pedido_id;
            if (dataGridViewPedido.SelectedRows.Count == 1)
            {
                // Verificar se o status do pedido não é "Concluído"
                string pedidoStatus = dataGridViewPedido.Rows[dataGridViewPedido.SelectedCells[0].RowIndex].Cells["pedido_status"].Value.ToString();
                if (pedidoStatus == "Concluído")
                {
                    MessageBox.Show("O pedido selecionado já está concluído e não pode ser cancelado.");
                    return;
                }

                // Continuar com o cancelamento do pedido
                pedido_id = Convert.ToInt32(dataGridViewPedido.Rows[dataGridViewPedido.SelectedCells[0].RowIndex].Cells["pedido_id"].Value);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryCancelarPedido = "UPDATE pedido SET pedido_status = 'Cancelado' WHERE pedido_id = @pedido_id";
                    using (SqlCommand commandCancelarPedido = new SqlCommand(queryCancelarPedido, connection))
                    {
                        commandCancelarPedido.Parameters.AddWithValue("@pedido_id", pedido_id);
                        commandCancelarPedido.ExecuteNonQuery();
                        dataGridViewPedido.DataSource = null;
                        CarregarDadosPedido();
                        MessageBox.Show("Pedido cancelado com sucesso", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um paciente na antes de inserir o pedido.");
                return;
            }
        }





        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            int idAparelho;
            idAparelho = Convert.ToInt32(dataGridViewAparelho.Rows[dataGridViewAparelho.SelectedCells[0].RowIndex].Cells["aparelho_id"].Value);
            int pedido_id;
            DateTime dataConsulta = dateTimePickerDataConsulta.Value;
            if (!VerificarDisponibilidadePedido(idAparelho, dataConsulta))
            {
                MessageBox.Show("O aparelho não está disponível para a data e hora selecionadas.");
                return;
            }

            if (dataGridViewPedido.SelectedRows.Count == 1)
            {
                string pedidoStatus = dataGridViewPedido.Rows[dataGridViewPedido.SelectedCells[0].RowIndex].Cells["pedido_status"].Value.ToString();
                if (pedidoStatus == "Concluído" || pedidoStatus == "Cancelado")
                {
                    MessageBox.Show("O pedido selecionado já está concluído e não pode ser editado.");
                    return;
                }

                pedido_id = Convert.ToInt32(dataGridViewPedido.Rows[dataGridViewPedido.SelectedCells[0].RowIndex].Cells["pedido_id"].Value);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryEditarPedido = "UPDATE pedido SET data_consulta = @dataConsulta WHERE pedido_id = @pedido_id";
                    using (SqlCommand commandEditarPedido = new SqlCommand(queryEditarPedido, connection))
                    {
                        commandEditarPedido.Parameters.AddWithValue("@pedido_id", pedido_id);
                        commandEditarPedido.Parameters.AddWithValue("@dataConsulta", dataConsulta);
                        commandEditarPedido.ExecuteNonQuery();

                        // Atualizar a grid de pedidos
                        dataGridViewPedido.DataSource = null;
                        CarregarDadosPedido();

                        MessageBox.Show("Pedido editado com sucesso", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private bool VerificarDisponibilidadePedido(int aparelhoId, DateTime dataConsulta)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Consulta para verificar se há algum pedido com o mesmo aparelho em um intervalo menor do que 2 horas
                string query = @"
                SELECT COUNT(*) 
                FROM pedido
                WHERE aparelho_id = @AparelhoId 
                AND data_consulta BETWEEN DATEADD(MINUTE, -119, @DataConsulta) AND DATEADD(MINUTE, 119, @DataConsulta)
                AND pedido_status = 'Pendente'";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AparelhoId", aparelhoId);
                    command.Parameters.AddWithValue("@DataConsulta", dataConsulta);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Se count for maior que 0, significa que já existe um pedido com o mesmo aparelho
                    // em um intervalo menor do que 2 horas
                    return count == 0;
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void dataGridViewPedido_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {

            dataGridViewPedido.Rows[e.RowIndex].Cells["Editar"].ToolTipText = "Clique aqui para editar";
        }

        private void dataGridViewPedido_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idPedido;

            idPedido = Convert.ToInt32((dataGridViewPedido.Rows[e.RowIndex].Cells["pedido_id"].Value.ToString()));
            if (dataGridViewPedido.Columns[e.ColumnIndex] == dataGridViewPedido.Columns["editar"]) 
            {
                dateTimePickerDataConsulta.Text = dataGridViewPedido.Rows[e.RowIndex].Cells["data_consulta"].Value.ToString();
            }
        }

        private void dataGridViewPedido_SelectionChanged(object sender, EventArgs e)
        {
            LimparDataGrids();

            if (dataGridViewPedido.SelectedCells.Count > 0)
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
                    MessageBox.Show("Não há pedidos para serem gerenciados.", "Mensagem de Alerta.");
                }
            }
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
        private void LimparDataGrids()
        {
            dataGridViewPaciente.DataSource = null;
            dataGridViewAparelho.DataSource = null;

        }

    }
}

                
            
