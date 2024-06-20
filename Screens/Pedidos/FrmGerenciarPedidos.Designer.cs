namespace test_delivery.Screens
{
    partial class FrmGerenciarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarPedidos));
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.BtnBuscarPaciente = new System.Windows.Forms.Button();
            this.textBoxNomePaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.dataGridViewPaciente = new System.Windows.Forms.DataGridView();
            this.dataGridViewAparelho = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAparelho)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.AllowUserToOrderColumns = true;
            this.dataGridViewPedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar});
            this.dataGridViewPedido.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.ReadOnly = true;
            this.dataGridViewPedido.RowHeadersWidth = 30;
            this.dataGridViewPedido.Size = new System.Drawing.Size(776, 145);
            this.dataGridViewPedido.TabIndex = 0;
            this.dataGridViewPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedido_CellContentClick_1);
            this.dataGridViewPedido.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPedido_CellFormatting_1);
            this.dataGridViewPedido.SelectionChanged += new System.EventHandler(this.dataGridViewPedido_SelectionChanged);
            // 
            // BtnBuscarPaciente
            // 
            this.BtnBuscarPaciente.Location = new System.Drawing.Point(189, 32);
            this.BtnBuscarPaciente.Name = "BtnBuscarPaciente";
            this.BtnBuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarPaciente.TabIndex = 1;
            this.BtnBuscarPaciente.Text = "Buscar";
            this.BtnBuscarPaciente.UseVisualStyleBackColor = true;
            this.BtnBuscarPaciente.Click += new System.EventHandler(this.BtnBuscarPaciente_Click);
            // 
            // textBoxNomePaciente
            // 
            this.textBoxNomePaciente.Location = new System.Drawing.Point(12, 32);
            this.textBoxNomePaciente.Name = "textBoxNomePaciente";
            this.textBoxNomePaciente.Size = new System.Drawing.Size(171, 20);
            this.textBoxNomePaciente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o nome do paciente";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnCancelar.Location = new System.Drawing.Point(189, 384);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(169, 54);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar Pedido";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(12, 383);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(169, 55);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar ";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.Gray;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnVoltar.Location = new System.Drawing.Point(364, 387);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(169, 48);
            this.BtnVoltar.TabIndex = 7;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // dataGridViewPaciente
            // 
            this.dataGridViewPaciente.AllowUserToOrderColumns = true;
            this.dataGridViewPaciente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaciente.Location = new System.Drawing.Point(12, 212);
            this.dataGridViewPaciente.Name = "dataGridViewPaciente";
            this.dataGridViewPaciente.ReadOnly = true;
            this.dataGridViewPaciente.Size = new System.Drawing.Size(376, 90);
            this.dataGridViewPaciente.TabIndex = 8;
            // 
            // dataGridViewAparelho
            // 
            this.dataGridViewAparelho.AllowUserToOrderColumns = true;
            this.dataGridViewAparelho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAparelho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAparelho.Location = new System.Drawing.Point(394, 212);
            this.dataGridViewAparelho.Name = "dataGridViewAparelho";
            this.dataGridViewAparelho.ReadOnly = true;
            this.dataGridViewAparelho.Size = new System.Drawing.Size(394, 89);
            this.dataGridViewAparelho.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alterar data da consulta:";
            // 
            // dateTimePickerDataConsulta
            // 
            this.dateTimePickerDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataConsulta.Location = new System.Drawing.Point(189, 332);
            this.dateTimePickerDataConsulta.Name = "dateTimePickerDataConsulta";
            this.dateTimePickerDataConsulta.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerDataConsulta.TabIndex = 18;
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 18;
            // 
            // FrmGerenciarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerDataConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAparelho);
            this.Controls.Add(this.dataGridViewPaciente);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomePaciente);
            this.Controls.Add(this.BtnBuscarPaciente);
            this.Controls.Add(this.dataGridViewPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarPedidos";
            this.Text = "ConsultarPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAparelho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Button BtnBuscarPaciente;
        private System.Windows.Forms.TextBox textBoxNomePaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.DataGridView dataGridViewPaciente;
        private System.Windows.Forms.DataGridView dataGridViewAparelho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataConsulta;
        private System.Windows.Forms.DataGridViewImageColumn editar;
    }
}