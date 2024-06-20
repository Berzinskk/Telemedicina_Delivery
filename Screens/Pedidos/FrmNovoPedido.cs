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
    public partial class FrmNovoPedido : Form
    {
        private string connectionString = @"Data Source=DESKTOP_ERICK;Initial Catalog=test_delivery;Integrated Security=true";
        public FrmNovoPedido()
        {
            InitializeComponent();
            CarregarDadosPaciente();
            CarregarDadosAparelho();
            dateTimePickerDataConsulta.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dataGridViewPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAparelhos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            dateTimePickerDataConsulta.Format = DateTimePickerFormat.Custom;



        }


        private void CarregarDadosPaciente()
        {
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();



                    string query = "SELECT * FROM paciente";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridViewPacientes.DataSource = dataTable;

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

        private void CarregarDadosAparelho()
        {
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    string query = "SELECT * FROM aparelho WHERE aparelho_status = 'Disponível'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridViewAparelhos.DataSource = dataTable;

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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome home = new FrmHome();
            home.Show();
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
      AND pedido_status = 'Pendente'

";


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
        
    


        private void btn_novopedido_Click(object sender, EventArgs e)
        {
            
            DateTime dataConsulta = dateTimePickerDataConsulta.Value;
            

            int idPaciente;
            int idAparelho;
            int idEntregador = 1;

            // Inserção do entregador
           
            // Obtém o ID do paciente selecionado na DataGridView
            if (dataGridViewPacientes.SelectedRows.Count == 1)
            {
                idPaciente = Convert.ToInt32(dataGridViewPacientes.Rows[dataGridViewPacientes.SelectedCells[0].RowIndex].Cells["paciente_id"].Value);
            }
            else
            {
                MessageBox.Show("Selecione um paciente na antes de inserir o pedido.");
                return;
            }

            // Obtém o ID do aparelho selecionado na DataGridView
            if (dataGridViewAparelhos.SelectedRows.Count == 1)
            {
                idAparelho = Convert.ToInt32(dataGridViewAparelhos.Rows[dataGridViewAparelhos.SelectedCells[0].RowIndex].Cells["aparelho_id"].Value);
            }
            else
            {
                MessageBox.Show("Selecione um aparelho na antes de inserir o pedido.");
                return;
            }

            
                if (VerificarDisponibilidadePedido(idAparelho, dataConsulta))
                {
                    // O pedido pode ser cadastrado
                    // Faça a inserção do novo pedido no banco de dados aqui
                    string query_pac_ = "INSERT INTO pedido (data_consulta, pedido_status, paciente_id, aparelho_id, entregador_id) " +
                    "VALUES (@dataConsulta, 'Pendente', @idPaciente, @idAparelho, @idEntregador )";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query_pac_, connection))
                        {

                            command.Parameters.AddWithValue("@dataConsulta", dataConsulta);
                            command.Parameters.AddWithValue("@idPaciente", idPaciente);
                            command.Parameters.AddWithValue("@idAparelho", idAparelho);
                            command.Parameters.AddWithValue("@idEntregador", idEntregador);

                            // Executa a consulta
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Pedido inserido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Já existe um pedido com o mesmo aparelho em um intervalo menor do que 2 horas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           





        






        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cpf = mskCPF.Text;

            // Validar CPF, você pode implementar a lógica de validação conforme necessário

            // Construir a consulta SQL para encontrar o registro correspondente ao CPF
            string query = "SELECT * FROM paciente WHERE cpf LIKE @cpf";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cpf", "%" + cpf + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Exibir os resultados na DataGridView
                        dataGridViewPacientes.DataSource = dataTable;

                    }
                }
            }
        }

       
    }
}
