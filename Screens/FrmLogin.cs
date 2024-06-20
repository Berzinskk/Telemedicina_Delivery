using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using test_delivery.Modelo;
using test_delivery.Screens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using test_delivery.Conexão;

namespace test_delivery
{
    public partial class Frm_login : Form
    {
        public string Cargo { get; set; }
        bool Ver_senhaTxt = false;
        Conexao conexao = new Conexao();

        public Frm_login()
        {
            InitializeComponent();

            // Adiciona opções à ComboBox
            cbo_cargo.Items.Add("Administrador");
            cbo_cargo.Items.Add("Enfermeira");
            cbo_cargo.Items.Add("Entregador");

            cbo_cargo.SelectedIndex = 1;

        }

        private void Btn_cadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro cad = new FrmCadastro();
            cad.Show();
            this.Hide();
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ckbox_senha_CheckedChanged(object sender, EventArgs e)
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

        private void Btn_login_Click(object sender, EventArgs e)

        {
            Login controle = new Login();
            string login = Txt_usuario.Text;
            string senha = Txt_senha.Text;
            string cargo = cbo_cargo.SelectedItem?.ToString();



            // Verifica se as caixas de texto não estão vazias
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha ambos os campos de usuário e senha.");
                return;
            }

            // Verifica se um tipo de usuário foi selecionado na ComboBox
            if (string.IsNullOrEmpty(cargo))
            {
                MessageBox.Show("Por favor, selecione um tipo de usuário na lista.");
                return;
            }

            // Agora, após garantir que os campos não estão vazios, podemos chamar o método de login
            controle.Logar(login, senha, cargo);

            // Verifica se o login foi bem-sucedido ou não
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Bem-Vindo", "Mensagem de Boas-Vindas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cargo = cargo;
                    FrmHome home = new FrmHome();
                    home.Show();
                    this.Hide();
                    
                    

                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login, senha e cargo", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_senha.Clear();
                    Txt_usuario.Clear();
                    Txt_usuario.Focus();
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }











        }

    }
}