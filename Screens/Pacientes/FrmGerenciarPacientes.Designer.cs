namespace test_delivery.Screens.Pacientes
{
    partial class FrmGerenciarPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarPacientes));
            this.dataGridViewPaciente = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Msk_tel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_rua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_bairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_numero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_complemento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Msk_CEP = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPaciente
            // 
            this.dataGridViewPaciente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dataGridViewPaciente.Location = new System.Drawing.Point(17, 102);
            this.dataGridViewPaciente.Name = "dataGridViewPaciente";
            this.dataGridViewPaciente.ReadOnly = true;
            this.dataGridViewPaciente.RowHeadersWidth = 30;
            this.dataGridViewPaciente.Size = new System.Drawing.Size(771, 197);
            this.dataGridViewPaciente.TabIndex = 0;
            this.dataGridViewPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaciente_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerenciar Pacientes";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(142, 56);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(119, 40);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "Salvar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(17, 56);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(119, 40);
            this.BtnVoltar.TabIndex = 3;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // Txt_nome
            // 
            this.Txt_nome.Location = new System.Drawing.Point(17, 326);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(245, 20);
            this.Txt_nome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF:";
            // 
            // Msk_CPF
            // 
            this.Msk_CPF.Location = new System.Drawing.Point(17, 373);
            this.Msk_CPF.Mask = "000,000,000-00";
            this.Msk_CPF.Name = "Msk_CPF";
            this.Msk_CPF.Size = new System.Drawing.Size(100, 20);
            this.Msk_CPF.TabIndex = 33;
            this.Msk_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Telefone:";
            // 
            // Msk_tel
            // 
            this.Msk_tel.Location = new System.Drawing.Point(17, 420);
            this.Msk_tel.Mask = "(00) 00000-0000";
            this.Msk_tel.Name = "Msk_tel";
            this.Msk_tel.Size = new System.Drawing.Size(100, 20);
            this.Msk_tel.TabIndex = 35;
            this.Msk_tel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(287, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Rua:";
            // 
            // Txt_rua
            // 
            this.Txt_rua.Location = new System.Drawing.Point(291, 326);
            this.Txt_rua.Name = "Txt_rua";
            this.Txt_rua.Size = new System.Drawing.Size(246, 20);
            this.Txt_rua.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(287, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Bairro:";
            // 
            // Txt_bairro
            // 
            this.Txt_bairro.Location = new System.Drawing.Point(291, 373);
            this.Txt_bairro.Name = "Txt_bairro";
            this.Txt_bairro.Size = new System.Drawing.Size(246, 20);
            this.Txt_bairro.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(543, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 21);
            this.label13.TabIndex = 41;
            this.label13.Text = "Nº:";
            // 
            // Txt_numero
            // 
            this.Txt_numero.Location = new System.Drawing.Point(547, 326);
            this.Txt_numero.Name = "Txt_numero";
            this.Txt_numero.Size = new System.Drawing.Size(91, 20);
            this.Txt_numero.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(643, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Complemento:";
            // 
            // Txt_complemento
            // 
            this.Txt_complemento.Location = new System.Drawing.Point(647, 326);
            this.Txt_complemento.Name = "Txt_complemento";
            this.Txt_complemento.Size = new System.Drawing.Size(141, 20);
            this.Txt_complemento.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(543, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 45;
            this.label9.Text = "CEP:";
            // 
            // Msk_CEP
            // 
            this.Msk_CEP.Location = new System.Drawing.Point(547, 373);
            this.Msk_CEP.Mask = "00000-000";
            this.Msk_CEP.Name = "Msk_CEP";
            this.Msk_CEP.Size = new System.Drawing.Size(59, 20);
            this.Msk_CEP.TabIndex = 46;
            this.Msk_CEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FrmGerenciarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Msk_CEP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_complemento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_numero);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Txt_bairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_rua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Msk_tel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Msk_CPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarPacientes";
            this.Text = "GerenciarPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Msk_CPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Msk_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_rua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_bairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_complemento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox Msk_CEP;
    }
}