using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_delivery.Screens
{
    public partial class FrmNovoAparelho : Form
    {
        public string AparelhoStatus { get; set; }
        public FrmNovoAparelho()
        {
            InitializeComponent();
            
        }
        
        private void btnSub_Click(object sender, EventArgs e)
        {
            AparelhoStatus = "Disponível";
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP_ERICK;Initial Catalog=test_delivery;Integrated Security=true"))
                {
                    cn.Open();

                    string selectQuery = "SELECT n_serie FROM aparelho WHERE n_serie = @nserie";

                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, cn))
                    {
                        selectCmd.Parameters.Add("@nserie", SqlDbType.VarChar).Value = txtNserie.Text;

                        using (SqlDataReader dt = selectCmd.ExecuteReader())
                        {
                            if (dt.HasRows)
                            {
                                MessageBox.Show("Número de série já cadastrado no sistema", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                dt.Close(); // Fecha o SqlDataReader antes de reutilizar o SqlCommand

                                string insertQuery = "INSERT INTO aparelho(nome,aparelho_status, n_serie, extras) " +
                                                     "VALUES(@nome,@status, @nserie, @extras)";

                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, cn))
                                {
                                    List<string> extrasSelecionados = new List<string>();

                                    foreach (int index in checkedListBoxAcessorios.CheckedIndices)
                                    {
                                        string itemText = checkedListBoxAcessorios.Items[index].ToString();
                                        extrasSelecionados.Add(itemText);
                                    }

                                    string extras = extrasSelecionados.Count > 0 ? string.Join(", ", extrasSelecionados) : "";


                                    insertCmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                                    insertCmd.Parameters.Add("@status", SqlDbType.VarChar).Value = AparelhoStatus;
                                    insertCmd.Parameters.Add("@nserie", SqlDbType.VarChar).Value = txtNserie.Text;
                                    insertCmd.Parameters.Add("@extras", SqlDbType.VarChar).Value = extras;

                                    insertCmd.ExecuteNonQuery();

                                    MessageBox.Show("Aparelho cadastrado com sucesso", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Manipule as exceções
                StringBuilder errorMessages = new StringBuilder();

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmHome Home = new FrmHome();
            Home.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}