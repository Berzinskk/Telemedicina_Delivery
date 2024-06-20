namespace test_delivery
{
    partial class FrmCadastro
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
            this.Lbl_cadastro = new System.Windows.Forms.Label();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.cbo_cargo = new System.Windows.Forms.ComboBox();
            this.Btn_cadastrar = new System.Windows.Forms.Button();
            this.Btn_voltar = new System.Windows.Forms.Button();
            this.Txt_confirma_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ckbox_senha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lbl_cadastro
            // 
            this.Lbl_cadastro.AutoSize = true;
            this.Lbl_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cadastro.Location = new System.Drawing.Point(395, 105);
            this.Lbl_cadastro.Name = "Lbl_cadastro";
            this.Lbl_cadastro.Size = new System.Drawing.Size(136, 16);
            this.Lbl_cadastro.TabIndex = 0;
            this.Lbl_cadastro.Text = "Faça seu cadastro";
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Location = new System.Drawing.Point(359, 154);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(46, 13);
            this.Lbl_usuario.TabIndex = 1;
            this.Lbl_usuario.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(411, 151);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.Txt_usuario.TabIndex = 4;
            // 
            // Txt_senha
            // 
            this.Txt_senha.Location = new System.Drawing.Point(410, 191);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.PasswordChar = '*';
            this.Txt_senha.Size = new System.Drawing.Size(100, 20);
            this.Txt_senha.TabIndex = 5;
            // 
            // cbo_cargo
            // 
            this.cbo_cargo.FormattingEnabled = true;
            this.cbo_cargo.Location = new System.Drawing.Point(407, 272);
            this.cbo_cargo.Name = "cbo_cargo";
            this.cbo_cargo.Size = new System.Drawing.Size(121, 21);
            this.cbo_cargo.TabIndex = 6;
            // 
            // Btn_cadastrar
            // 
            this.Btn_cadastrar.Location = new System.Drawing.Point(398, 324);
            this.Btn_cadastrar.Name = "Btn_cadastrar";
            this.Btn_cadastrar.Size = new System.Drawing.Size(62, 22);
            this.Btn_cadastrar.TabIndex = 7;
            this.Btn_cadastrar.Text = "Cadastrar";
            this.Btn_cadastrar.UseVisualStyleBackColor = true;
            this.Btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            // 
            // Btn_voltar
            // 
            this.Btn_voltar.Location = new System.Drawing.Point(478, 324);
            this.Btn_voltar.Name = "Btn_voltar";
            this.Btn_voltar.Size = new System.Drawing.Size(62, 22);
            this.Btn_voltar.TabIndex = 8;
            this.Btn_voltar.Text = "Voltar";
            this.Btn_voltar.UseVisualStyleBackColor = true;
            this.Btn_voltar.Click += new System.EventHandler(this.Btn_voltar_Click);
            // 
            // Txt_confirma_senha
            // 
            this.Txt_confirma_senha.Location = new System.Drawing.Point(410, 232);
            this.Txt_confirma_senha.Name = "Txt_confirma_senha";
            this.Txt_confirma_senha.PasswordChar = '*';
            this.Txt_confirma_senha.Size = new System.Drawing.Size(100, 20);
            this.Txt_confirma_senha.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirmar senha";
            // 
            // Ckbox_senha
            // 
            this.Ckbox_senha.AutoSize = true;
            this.Ckbox_senha.Location = new System.Drawing.Point(516, 193);
            this.Ckbox_senha.Name = "Ckbox_senha";
            this.Ckbox_senha.Size = new System.Drawing.Size(93, 17);
            this.Ckbox_senha.TabIndex = 11;
            this.Ckbox_senha.Text = "Mostrar senha";
            this.Ckbox_senha.UseVisualStyleBackColor = true;
            this.Ckbox_senha.CheckedChanged += new System.EventHandler(this.Ckbox_senha_CheckedChanged_1);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.Ckbox_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_confirma_senha);
            this.Controls.Add(this.Btn_voltar);
            this.Controls.Add(this.Btn_cadastrar);
            this.Controls.Add(this.cbo_cargo);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Lbl_cadastro);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_cadastro;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_senha;
        private System.Windows.Forms.ComboBox cbo_cargo;
        private System.Windows.Forms.Button Btn_cadastrar;
        private System.Windows.Forms.Button Btn_voltar;
        private System.Windows.Forms.TextBox Txt_confirma_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Ckbox_senha;
    }
}