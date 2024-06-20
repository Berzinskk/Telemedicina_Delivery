namespace test_delivery.Screens
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.BtnNovoAparelho = new System.Windows.Forms.Button();
            this.BtnNovoPaciente = new System.Windows.Forms.Button();
            this.Pbox_home = new System.Windows.Forms.PictureBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnConsultarPedido = new System.Windows.Forms.Button();
            this.BtnDespacharPedido = new System.Windows.Forms.Button();
            this.BtnNovoPedido = new System.Windows.Forms.Button();
            this.BtnGerenciarPaciente = new System.Windows.Forms.Button();
            this.BtnGerenciarEntregador = new System.Windows.Forms.Button();
            this.BtnGerenciarAparelho = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovoAparelho
            // 
            this.BtnNovoAparelho.Location = new System.Drawing.Point(12, 326);
            this.BtnNovoAparelho.Name = "BtnNovoAparelho";
            this.BtnNovoAparelho.Size = new System.Drawing.Size(180, 20);
            this.BtnNovoAparelho.TabIndex = 3;
            this.BtnNovoAparelho.Text = "Cadastrar aparelho";
            this.BtnNovoAparelho.UseVisualStyleBackColor = true;
            this.BtnNovoAparelho.Click += new System.EventHandler(this.Btn_novoAparelho_Click);
            // 
            // BtnNovoPaciente
            // 
            this.BtnNovoPaciente.Location = new System.Drawing.Point(8, 185);
            this.BtnNovoPaciente.Name = "BtnNovoPaciente";
            this.BtnNovoPaciente.Size = new System.Drawing.Size(193, 24);
            this.BtnNovoPaciente.TabIndex = 4;
            this.BtnNovoPaciente.Text = "Cadastrar paciente";
            this.BtnNovoPaciente.UseVisualStyleBackColor = true;
            this.BtnNovoPaciente.Click += new System.EventHandler(this.Btn_novoPaciente_Click);
            // 
            // Pbox_home
            // 
            this.Pbox_home.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pbox_home.Image = ((System.Drawing.Image)(resources.GetObject("Pbox_home.Image")));
            this.Pbox_home.Location = new System.Drawing.Point(201, 0);
            this.Pbox_home.Name = "Pbox_home";
            this.Pbox_home.Size = new System.Drawing.Size(550, 461);
            this.Pbox_home.TabIndex = 5;
            this.Pbox_home.TabStop = false;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(8, 406);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(187, 43);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // BtnConsultarPedido
            // 
            this.BtnConsultarPedido.Location = new System.Drawing.Point(8, 105);
            this.BtnConsultarPedido.Name = "BtnConsultarPedido";
            this.BtnConsultarPedido.Size = new System.Drawing.Size(193, 22);
            this.BtnConsultarPedido.TabIndex = 0;
            this.BtnConsultarPedido.Text = "Gerenciar pedidos";
            this.BtnConsultarPedido.UseVisualStyleBackColor = true;
            this.BtnConsultarPedido.Click += new System.EventHandler(this.BtnConsultarPedido_Click);
            // 
            // BtnDespacharPedido
            // 
            this.BtnDespacharPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDespacharPedido.Location = new System.Drawing.Point(8, 45);
            this.BtnDespacharPedido.Name = "BtnDespacharPedido";
            this.BtnDespacharPedido.Size = new System.Drawing.Size(193, 25);
            this.BtnDespacharPedido.TabIndex = 7;
            this.BtnDespacharPedido.Text = "Despachar pedidos";
            this.BtnDespacharPedido.UseVisualStyleBackColor = true;
            this.BtnDespacharPedido.Click += new System.EventHandler(this.Btn_despachar_Click);
            // 
            // BtnNovoPedido
            // 
            this.BtnNovoPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNovoPedido.Location = new System.Drawing.Point(8, 12);
            this.BtnNovoPedido.Name = "BtnNovoPedido";
            this.BtnNovoPedido.Size = new System.Drawing.Size(193, 27);
            this.BtnNovoPedido.TabIndex = 1;
            this.BtnNovoPedido.Text = "Novo pedido";
            this.BtnNovoPedido.UseVisualStyleBackColor = true;
            this.BtnNovoPedido.Click += new System.EventHandler(this.Btn_novoPedido_Click);
            // 
            // BtnGerenciarPaciente
            // 
            this.BtnGerenciarPaciente.Location = new System.Drawing.Point(8, 215);
            this.BtnGerenciarPaciente.Name = "BtnGerenciarPaciente";
            this.BtnGerenciarPaciente.Size = new System.Drawing.Size(193, 24);
            this.BtnGerenciarPaciente.TabIndex = 14;
            this.BtnGerenciarPaciente.Text = "Gerenciar pacientes";
            this.BtnGerenciarPaciente.UseVisualStyleBackColor = true;
            this.BtnGerenciarPaciente.Click += new System.EventHandler(this.BtnGerenciarPaciente_Click);
            // 
            // BtnGerenciarEntregador
            // 
            this.BtnGerenciarEntregador.Location = new System.Drawing.Point(12, 266);
            this.BtnGerenciarEntregador.Name = "BtnGerenciarEntregador";
            this.BtnGerenciarEntregador.Size = new System.Drawing.Size(180, 24);
            this.BtnGerenciarEntregador.TabIndex = 15;
            this.BtnGerenciarEntregador.Text = "Gerenciar entregadores";
            this.BtnGerenciarEntregador.UseVisualStyleBackColor = true;
            this.BtnGerenciarEntregador.Click += new System.EventHandler(this.BtnGerenciarEntregador_Click);
            // 
            // BtnGerenciarAparelho
            // 
            this.BtnGerenciarAparelho.Location = new System.Drawing.Point(12, 352);
            this.BtnGerenciarAparelho.Name = "BtnGerenciarAparelho";
            this.BtnGerenciarAparelho.Size = new System.Drawing.Size(180, 24);
            this.BtnGerenciarAparelho.TabIndex = 16;
            this.BtnGerenciarAparelho.Text = "Gerenciar Aparelhos";
            this.BtnGerenciarAparelho.UseVisualStyleBackColor = true;
            this.BtnGerenciarAparelho.Click += new System.EventHandler(this.BtnGerenciarAparelho_Click);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(8, 76);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(193, 23);
            this.BtnFinalizar.TabIndex = 17;
            this.BtnFinalizar.Text = "Finalizar pedidos";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 461);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnGerenciarAparelho);
            this.Controls.Add(this.BtnGerenciarEntregador);
            this.Controls.Add(this.BtnGerenciarPaciente);
            this.Controls.Add(this.BtnConsultarPedido);
            this.Controls.Add(this.BtnDespacharPedido);
            this.Controls.Add(this.BtnNovoPedido);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnNovoAparelho);
            this.Controls.Add(this.BtnNovoPaciente);
            this.Controls.Add(this.Pbox_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnNovoAparelho;
        private System.Windows.Forms.Button BtnNovoPaciente;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.PictureBox Pbox_home;
        private System.Windows.Forms.Button BtnNovoPedido;
        private System.Windows.Forms.Button BtnDespacharPedido;
        private System.Windows.Forms.Button BtnConsultarPedido;
        private System.Windows.Forms.Button BtnGerenciarPaciente;
        private System.Windows.Forms.Button BtnGerenciarEntregador;
        private System.Windows.Forms.Button BtnGerenciarAparelho;
        private System.Windows.Forms.Button BtnFinalizar;
    }
}