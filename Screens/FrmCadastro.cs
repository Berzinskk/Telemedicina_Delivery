using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test_delivery
{
    public partial class FrmCadastro : Form
    {
        bool Ver_senhaTxt = false;

        public FrmCadastro()
        {
            InitializeComponent();

            cbo_cargo.Items.Add("Administrador");
            cbo_cargo.Items.Add("Enfermeira");
            cbo_cargo.Items.Add("Entregador");

            cbo_cargo.SelectedIndex = 1;
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            Frm_login login = new Frm_login();
            login.Show();
            this.Hide();

        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            string cargo;
            if (cbo_cargo.SelectedIndex == 0)
            {
                cargo = "Administrador";
            }
            else
            {
                if (cbo_cargo.SelectedIndex == 1)
                    cargo = "Enfermeira";
                else cargo = "Entregador";
            }

            if
                (Txt_senha.Text != Txt_confirma_senha.Text) 
            {
                MessageBox.Show("As senhas não correspondem","Mensagem de erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Txt_senha.Text == Txt_confirma_senha.Text)
            {
                Cadastro cad = new Cadastro(Txt_usuario.Text, Txt_senha.Text, cargo);
                
            }
            
            
           


        }

        private void Ckbox_senha_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Ver_senhaTxt == false)
            {
                Txt_senha.PasswordChar = '\0';
                Ver_senhaTxt = true;
            }
            else
            {
                Txt_senha.PasswordChar = '*';
                Ver_senhaTxt = false;
            }
        }

        
        
    }
}
