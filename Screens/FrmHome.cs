using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_delivery.Screens.Aparelhos;
using test_delivery.Screens.Pacientes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace test_delivery.Screens
{
    public partial class FrmHome : Form
    {
        private FlowLayoutPanel sidebarPanel;
        public FrmHome()
        {

            InitializeComponent();
            InitializeSidebar();
            Frm_login frmLogin = (Frm_login)Application.OpenForms["Frm_Login"];

            if (frmLogin != null)
            {
                string cargo = frmLogin.Cargo;
                if (cargo == "Entregador")
                {
                    BtnNovoPedido.Visible = false;
                    BtnNovoPaciente.Visible = false;
                    
                    BtnNovoAparelho.Visible = false;
                }
                else if (cargo == "Enfermeira")
                {
                    
                    BtnNovoAparelho.Visible = false;
                }
            }

        }
        

        private void InitializeSidebar()
        {
            sidebarPanel = new FlowLayoutPanel();
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.BackColor = Color.FromArgb(53, 59, 72); // Cor de fundo personalizada
            sidebarPanel.AutoScroll = true;
            sidebarPanel.FlowDirection = FlowDirection.TopDown;
            sidebarPanel.WrapContents = false;
            sidebarPanel.Width = 200;
            this.Controls.Add(sidebarPanel);

            // Adiciona os botões principais e os associa aos botões existentes no formulário
            AddSidebarButton("Pedidos", BtnNovoPedido, BtnDespacharPedido, BtnFinalizar, BtnConsultarPedido);
            AddSidebarButton("Pacientes", BtnNovoPaciente, BtnGerenciarPaciente);
            AddSidebarButton("Entregadores", BtnGerenciarEntregador);
            AddSidebarButton("Aparelhos", BtnNovoAparelho, BtnGerenciarAparelho); // Adiciona botão principal para Aparelhos
            BtnSair.Width = sidebarPanel.Width - 10;
            BtnSair.Height = 50;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.FlatAppearance.BorderSize = 0;
            BtnSair.BackColor = Color.FromArgb(63, 114, 175); // Cor de fundo do botão principal
            BtnSair.ForeColor = Color.White; // Cor do texto
            BtnSair.Font = new Font(BtnSair.Font.FontFamily, 12, FontStyle.Bold);
            BtnSair.Margin = new Padding(5, 10, 5, 0); // Espaçamento
            BtnSair.TextAlign = ContentAlignment.MiddleLeft;

            // Move o botão "Sair" para a barra lateral
            sidebarPanel.Controls.Add(BtnSair);
        }

        private void AddSidebarButton(string buttonText, params Button[] associatedButtons)
        {

            Button mainButton = new Button();
            mainButton.Text = buttonText;
            mainButton.Width = sidebarPanel.Width - 10;
            mainButton.Height = 50;
            mainButton.FlatStyle = FlatStyle.Flat;
            mainButton.FlatAppearance.BorderSize = 0;
            mainButton.BackColor = Color.FromArgb(63, 114, 175); // Cor de fundo do botão principal
            mainButton.ForeColor = Color.White; // Cor do texto
            mainButton.Font = new Font(mainButton.Font.FontFamily, 12, FontStyle.Bold);
            mainButton.Margin = new Padding(5, 10, 5, 0); // Espaçamento
            mainButton.TextAlign = ContentAlignment.MiddleLeft;
            mainButton.Click += (sender, e) =>
            {
                ToggleSubOptions(sender as Button, associatedButtons);
            };
            sidebarPanel.Controls.Add(mainButton);

            foreach (Button button in associatedButtons)
            {
                button.Visible = false; // Oculta os botões secundários inicialmente
                button.Width = sidebarPanel.Width - 20;
                button.Height = 40;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = Color.FromArgb(44, 48, 60); // Cor de fundo do botão secundário
                button.ForeColor = Color.White; // Cor do texto
                button.Font = new Font(button.Font.FontFamily, 10);
                button.Margin = new Padding(15, 0, 0, 0);
                button.TextAlign = ContentAlignment.MiddleLeft;
                sidebarPanel.Controls.Add(button); // Adiciona os botões secundários ao FlowLayoutPanel
            }
        }

        private void ToggleSubOptions(Button mainButton, params Button[] associatedButtons)
        {
            foreach (Button button in associatedButtons)
            {
                button.Visible = !button.Visible;
            }
        }




        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_novoPedido_Click(object sender, EventArgs e)
        {
            FrmNovoPedido novoPedido = new FrmNovoPedido();
            novoPedido.Show();
            this.Hide();

        }

        private void Btn_novoPaciente_Click(object sender, EventArgs e)
        {
            FrmNovoPaciente novoPaciente = new FrmNovoPaciente();
            novoPaciente.Show();
            this.Hide();
        }

        private void Btn_novoAparelho_Click(object sender, EventArgs e)
        {
            FrmNovoAparelho novoAparelho = new FrmNovoAparelho();
            novoAparelho.Show();
            this.Hide();
        }

        private void Btn_despachar_Click(object sender, EventArgs e)
        {
            FrmDespachar frmDespachar = new FrmDespachar(); 
            frmDespachar.Show();
            this.Hide();
        }

        private void BtnConsultarPedido_Click(object sender, EventArgs e)
        {
            FrmGerenciarPedidos consultarPedidos = new FrmGerenciarPedidos();
            consultarPedidos.Show();
            this.Hide();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            FrmFinalizar finalizar = new FrmFinalizar();
            this.Hide();
            finalizar.Show();

        }

        private void BtnGerenciarPaciente_Click(object sender, EventArgs e)
        {
           FrmGerenciarPacientes gerenciarPacientes = new FrmGerenciarPacientes();
            gerenciarPacientes.Show();
            this.Hide();
        }

        private void BtnGerenciarEntregador_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnGerenciarAparelho_Click(object sender, EventArgs e)
        {
            FrmGerenciarAparelhos gerenciarAparelhos = new FrmGerenciarAparelhos();
            gerenciarAparelhos.Show();
            this.Hide();
        }
    }
}
