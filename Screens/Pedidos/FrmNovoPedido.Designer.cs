namespace test_delivery.Screens
{
    partial class FrmNovoPedido
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewAparelhos = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_novopedido = new System.Windows.Forms.Button();
            this.dateTimePickerDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAparelhos)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aparelho:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(99, 46);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(87, 20);
            this.mskCPF.TabIndex = 4;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Location = new System.Drawing.Point(18, 43);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarCliente.TabIndex = 12;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPacientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(18, 72);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(776, 142);
            this.dataGridViewPacientes.TabIndex = 13;
            // 
            // dataGridViewAparelhos
            // 
            this.dataGridViewAparelhos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAparelhos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAparelhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAparelhos.Location = new System.Drawing.Point(18, 251);
            this.dataGridViewAparelhos.Name = "dataGridViewAparelhos";
            this.dataGridViewAparelhos.ReadOnly = true;
            this.dataGridViewAparelhos.Size = new System.Drawing.Size(776, 82);
            this.dataGridViewAparelhos.TabIndex = 14;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(654, 370);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(134, 42);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_novopedido
            // 
            this.btn_novopedido.Location = new System.Drawing.Point(514, 370);
            this.btn_novopedido.Name = "btn_novopedido";
            this.btn_novopedido.Size = new System.Drawing.Size(134, 43);
            this.btn_novopedido.TabIndex = 16;
            this.btn_novopedido.Text = "Cadastrar";
            this.btn_novopedido.UseVisualStyleBackColor = true;
            this.btn_novopedido.Click += new System.EventHandler(this.btn_novopedido_Click);
            // 
            // dateTimePickerDataConsulta
            // 
            this.dateTimePickerDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataConsulta.Location = new System.Drawing.Point(36, 393);
            this.dateTimePickerDataConsulta.Name = "dateTimePickerDataConsulta";
            this.dateTimePickerDataConsulta.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerDataConsulta.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "Data da Consulta:";
            // 
            // FrmNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerDataConsulta);
            this.Controls.Add(this.btn_novopedido);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dataGridViewAparelhos);
            this.Controls.Add(this.dataGridViewPacientes);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNovoPedido";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAparelhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.DataGridView dataGridViewAparelhos;
        private System.Windows.Forms.Button btn_novopedido;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataConsulta;
    }
}