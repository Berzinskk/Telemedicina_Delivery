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

namespace test_delivery.Screens.Aparelhos
{
    public partial class FrmGerenciarAparelhos : Form
    {
        public FrmGerenciarAparelhos()
        {
            InitializeComponent();
            CarregarDadosAparelho();
        }
        private string connectionString = @"Data Source=DESKTOP_ERICK;Initial Catalog=test_delivery;Integrated Security=true";
        private void CarregarDadosAparelho()
        {
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    string query = "SELECT * FROM aparelho";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridViewAparelho.DataSource = dataTable;

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
                MessageBox.Show("Erro ao carregar dados do aparelho: " + ex.Message + "\n\n" + errorMessages.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}
