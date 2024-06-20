using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace test_delivery.Screens
{
    public partial class FrmNovoPaciente : Form
    {
        public FrmNovoPaciente()
        {
            InitializeComponent();
            cbo_Cidade.Items.Add("São Paulo");
            cbo_Estado.Items.Add("SP");
            cbo_Cidade.SelectedIndex = 0;
            cbo_Estado.SelectedIndex = 0;
        }
        
        SqlCommand cm = new SqlCommand();
        


        public class FormUtilidades
        {
            public static void Limpar()
            {
                
            }
        }

        private void Btn_cancela_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void Btn_confirma_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            string cidade = "São Paulo"; // Default value
            string estado = "SP";        // Default value
            if (cbo_Cidade.SelectedIndex == 0)
            {
                cidade = "São Paulo";
            }
            if (cbo_Estado.SelectedIndex == 0)
            {
                estado = "SP";
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP_ERICK;Initial Catalog=test_delivery;Integrated Security=true"))
                {
                    cn.Open();

                    string strSQL = "SELECT cpf FROM paciente WHERE cpf = @cpf";

                    using (SqlCommand cm = new SqlCommand(strSQL, cn))
                    {
                        cm.Parameters.Add("@cpf", SqlDbType.Char).Value = Msk_CPF.Text;

                        using (SqlDataReader dt = cm.ExecuteReader())
                        {
                            if (dt.HasRows)
                            {
                                MessageBox.Show("CPF já cadastrado no sistema", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                dt.Close(); // Close the SqlDataReader before reusing the SqlCommand
                                if (string.IsNullOrWhiteSpace(Txt_nome.Text) ||
    string.IsNullOrWhiteSpace(Msk_tel.Text) ||
    string.IsNullOrWhiteSpace(Msk_CPF.Text) ||
    string.IsNullOrWhiteSpace(Txt_rua.Text) ||
    string.IsNullOrWhiteSpace(Txt_numero.Text) ||
    string.IsNullOrWhiteSpace(Txt_bairro.Text) ||
    string.IsNullOrWhiteSpace(cidade) ||
    string.IsNullOrWhiteSpace(estado) ||
    string.IsNullOrWhiteSpace(Msk_CEP.Text))
                                {
                                    MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {

                                    strSQL = "INSERT INTO paciente(nome, telefone, cpf, rua, numero, bairro, complemento, cidade, estado, cep) " +
                                         "VALUES(@nome, @telefone, @cpf, @rua, @numero, @bairro, @complemento, @cidade, @estado, @cep)";

                                    cm.Parameters.Clear(); // Clear existing parameters
                                    cm.CommandText = strSQL;

                                    // Set parameters for the insertion
                                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = Txt_nome.Text;
                                    cm.Parameters.Add("@telefone", SqlDbType.Char).Value = Msk_tel.Text;
                                    cm.Parameters.Add("@cpf", SqlDbType.Char).Value = Msk_CPF.Text;
                                    cm.Parameters.Add("@rua", SqlDbType.VarChar).Value = Txt_rua.Text;
                                    cm.Parameters.Add("@numero", SqlDbType.VarChar).Value = Txt_numero.Text;
                                    cm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = Txt_bairro.Text;
                                    cm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = Txt_complemento.Text;
                                    cm.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
                                    cm.Parameters.Add("@estado", SqlDbType.Char).Value = estado;
                                    cm.Parameters.Add("@cep", SqlDbType.Char).Value = Msk_CEP.Text;


                                    cm.ExecuteNonQuery();

                                    MessageBox.Show("Paciente cadastrado com sucesso", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
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

                MessageBox.Show("Erro ao executar a operação: " + errorMessages.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       




    }
    }

       
 
