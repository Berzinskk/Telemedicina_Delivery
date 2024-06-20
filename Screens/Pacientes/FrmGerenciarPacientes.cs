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

namespace test_delivery.Screens.Pacientes
{
    public partial class FrmGerenciarPacientes : Form
    {
        public FrmGerenciarPacientes()
        {
            InitializeComponent();
            CarregarDadosPaciente();
        }
        private string connectionString = @"Data Source=DESKTOP_ERICK;Initial Catalog=test_delivery;Integrated Security=true";
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

                            dataGridViewPaciente.DataSource = dataTable;

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

        
            
        

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int paciente_id;
            string nome = Txt_nome.Text;
            string telefone = Msk_tel.Text;
            string cpf = Msk_CPF.Text;
            string rua = Txt_rua.Text;
            string bairro = Txt_bairro.Text;
            string complemento = Txt_complemento.Text;
            string cep = Msk_CEP.Text;
            

            
                if (dataGridViewPaciente.SelectedRows.Count == 1)
                {

                    // Continuar com o cancelamento do pedido
                    paciente_id = Convert.ToInt32(dataGridViewPaciente.Rows[dataGridViewPaciente.SelectedCells[0].RowIndex].Cells["paciente_id"].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                    string queryEditarPaciente = @"UPDATE paciente SET nome = @nome, telefone = @telefone, 
                        cpf = @cpf, rua = @rua, numero = @numero, bairro = @bairro, 
                        complemento = @complemento, cep = @cep WHERE paciente_id = @paciente_id";
                        using (SqlCommand commandEditarPaciente = new SqlCommand(queryEditarPaciente, connection))
                        {
                            commandEditarPaciente.Parameters.AddWithValue("@paciente_id", paciente_id);
                            commandEditarPaciente.Parameters.AddWithValue("@nome", nome);
                            commandEditarPaciente.Parameters.AddWithValue("@telefone", telefone);
                            commandEditarPaciente.Parameters.AddWithValue("@cpf", cpf);
                            commandEditarPaciente.Parameters.AddWithValue("@rua", rua);
                            commandEditarPaciente.Parameters.AddWithValue("@numero", Txt_numero.Text);
                            commandEditarPaciente.Parameters.AddWithValue("@bairro", bairro);
                            commandEditarPaciente.Parameters.AddWithValue("@complemento", complemento);
                            commandEditarPaciente.Parameters.AddWithValue("@cep", cep);
                            commandEditarPaciente.ExecuteNonQuery();
                            dataGridViewPaciente.DataSource = null;
                            CarregarDadosPaciente();
                            MessageBox.Show("Pedido editado com sucesso", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                            dataGridViewPaciente.DataSource = null;
                            CarregarDadosPaciente();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um paciente na antes de inserir o pedido.");
                    return;
                }
            }

        private void dataGridViewPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int paciente_id;

            paciente_id = Convert.ToInt32((dataGridViewPaciente.Rows[e.RowIndex].Cells["paciente_id"].Value.ToString()));
            if (dataGridViewPaciente.Columns[e.ColumnIndex] == dataGridViewPaciente.Columns["editar"])
            {
                Txt_nome.Text = dataGridViewPaciente.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                Txt_rua.Text = dataGridViewPaciente.Rows[e.RowIndex].Cells["rua"].Value.ToString();
                Txt_bairro.Text = dataGridViewPaciente.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
                Txt_complemento.Text = dataGridViewPaciente.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
                Txt_numero.Text = dataGridViewPaciente.Rows[e.RowIndex].Cells["numero"].Value.ToString();
                Msk_CEP.Text = dataGridViewPaciente.Rows[e.RowIndex].Cells["cep"].Value.ToString();
                Msk_CPF.Text = dataGridViewPaciente.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                Msk_tel.Text = dataGridViewPaciente.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
               
            }
        }
    }
    }



