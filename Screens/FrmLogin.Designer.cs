namespace test_delivery
{
    partial class Frm_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_login = new System.Windows.Forms.Label();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Lbl_senha = new System.Windows.Forms.Label();
            this.Lbl_cadastro = new System.Windows.Forms.Label();
            this.Btn_login = new System.Windows.Forms.Button();
            this.Btn_cadastro = new System.Windows.Forms.Button();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Ckbox_senha = new System.Windows.Forms.CheckBox();
            this.cbo_cargo = new System.Windows.Forms.ComboBox();
            this.Lbl_cargo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_login
            // 
            this.Lbl_login.AutoSize = true;
            this.Lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_login.Location = new System.Drawing.Point(397, 42);
            this.Lbl_login.Name = "Lbl_login";
            this.Lbl_login.Size = new System.Drawing.Size(109, 16);
            this.Lbl_login.TabIndex = 0;
            this.Lbl_login.Text = "Faça seu login";
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Location = new System.Drawing.Point(348, 103);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(46, 13);
            this.Lbl_usuario.TabIndex = 1;
            this.Lbl_usuario.Text = "Usuário:";
            // 
            // Lbl_senha
            // 
            this.Lbl_senha.AutoSize = true;
            this.Lbl_senha.Location = new System.Drawing.Point(353, 143);
            this.Lbl_senha.Name = "Lbl_senha";
            this.Lbl_senha.Size = new System.Drawing.Size(41, 13);
            this.Lbl_senha.TabIndex = 2;
            this.Lbl_senha.Text = "Senha:";
            // 
            // Lbl_cadastro
            // 
            this.Lbl_cadastro.AutoSize = true;
            this.Lbl_cadastro.Location = new System.Drawing.Point(355, 217);
            this.Lbl_cadastro.Name = "Lbl_cadastro";
            this.Lbl_cadastro.Size = new System.Drawing.Size(106, 13);
            this.Lbl_cadastro.TabIndex = 3;
            this.Lbl_cadastro.Text = "Não tem uma conta?";
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(368, 261);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(75, 23);
            this.Btn_login.TabIndex = 4;
            this.Btn_login.Text = "Entrar";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Btn_cadastro
            // 
            this.Btn_cadastro.Location = new System.Drawing.Point(467, 212);
            this.Btn_cadastro.Name = "Btn_cadastro";
            this.Btn_cadastro.Size = new System.Drawing.Size(75, 23);
            this.Btn_cadastro.TabIndex = 5;
            this.Btn_cadastro.Text = "Cadastre-se";
            this.Btn_cadastro.UseVisualStyleBackColor = true;
            this.Btn_cadastro.Click += new System.EventHandler(this.Btn_cadastro_Click);
            // 
            // Btn_sair
            // 
            this.Btn_sair.Location = new System.Drawing.Point(467, 261);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_sair.TabIndex = 6;
            this.Btn_sair.Text = "Sair";
            this.Btn_sair.UseVisualStyleBackColor = true;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(400, 100);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.Txt_usuario.TabIndex = 7;
            // 
            // Txt_senha
            // 
            this.Txt_senha.Location = new System.Drawing.Point(400, 140);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.PasswordChar = '*';
            this.Txt_senha.Size = new System.Drawing.Size(100, 20);
            this.Txt_senha.TabIndex = 8;
            // 
            // Ckbox_senha
            // 
            this.Ckbox_senha.AutoSize = true;
            this.Ckbox_senha.Location = new System.Drawing.Point(506, 143);
            this.Ckbox_senha.Name = "Ckbox_senha";
            this.Ckbox_senha.Size = new System.Drawing.Size(93, 17);
            this.Ckbox_senha.TabIndex = 9;
            this.Ckbox_senha.Text = "Mostrar senha";
            this.Ckbox_senha.UseVisualStyleBackColor = true;
            this.Ckbox_senha.CheckedChanged += new System.EventHandler(this.Ckbox_senha_CheckedChanged);
            // 
            // cbo_cargo
            // 
            this.cbo_cargo.FormattingEnabled = true;
            this.cbo_cargo.Location = new System.Drawing.Point(399, 176);
            this.cbo_cargo.Name = "cbo_cargo";
            this.cbo_cargo.Size = new System.Drawing.Size(121, 21);
            this.cbo_cargo.TabIndex = 10;
            // 
            // Lbl_cargo
            // 
            this.Lbl_cargo.AutoSize = true;
            this.Lbl_cargo.Location = new System.Drawing.Point(355, 179);
            this.Lbl_cargo.Name = "Lbl_cargo";
            this.Lbl_cargo.Size = new System.Drawing.Size(38, 13);
            this.Lbl_cargo.TabIndex = 11;
            this.Lbl_cargo.Text = "Cargo:";
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.Lbl_cargo);
            this.Controls.Add(this.cbo_cargo);
            this.Controls.Add(this.Ckbox_senha);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Btn_sair);
            this.Controls.Add(this.Btn_cadastro);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Lbl_cadastro);
            this.Controls.Add(this.Lbl_senha);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Lbl_login);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_login;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.Label Lbl_senha;
        private System.Windows.Forms.Label Lbl_cadastro;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Button Btn_cadastro;
        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_senha;
        private System.Windows.Forms.CheckBox Ckbox_senha;
        private System.Windows.Forms.ComboBox cbo_cargo;
        private System.Windows.Forms.Label Lbl_cargo;
    }
}

