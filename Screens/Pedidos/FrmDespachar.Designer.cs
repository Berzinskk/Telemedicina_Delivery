namespace test_delivery.Screens
{
    partial class FrmDespachar
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
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Veiculo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.msk_Placa = new System.Windows.Forms.MaskedTextBox();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomePaciente = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.dataGridViewPaciente = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewAparelho = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAparelho)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewPedido.MultiSelect = false;
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.ReadOnly = true;
            this.dataGridViewPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewPedido.Size = new System.Drawing.Size(776, 89);
            this.dataGridViewPedido.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Entregador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(18, 415);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(172, 20);
            this.txt_Nome.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Veículo:";
            // 
            // txt_Veiculo
            // 
            this.txt_Veiculo.Location = new System.Drawing.Point(213, 415);
            this.txt_Veiculo.Name = "txt_Veiculo";
            this.txt_Veiculo.Size = new System.Drawing.Size(127, 20);
            this.txt_Veiculo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Placa:";
            // 
            // msk_Placa
            // 
            this.msk_Placa.Location = new System.Drawing.Point(363, 415);
            this.msk_Placa.Mask = "AAA-9C99";
            this.msk_Placa.Name = "msk_Placa";
            this.msk_Placa.Size = new System.Drawing.Size(56, 20);
            this.msk_Placa.TabIndex = 20;
            this.msk_Placa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnDespachar
            // 
            this.btnDespachar.Location = new System.Drawing.Point(713, 400);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(75, 38);
            this.btnDespachar.TabIndex = 21;
            this.btnDespachar.Text = "Despachar";
            this.btnDespachar.UseVisualStyleBackColor = true;
            this.btnDespachar.Click += new System.EventHandler(this.btnDespachar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Selecione o pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pedidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Digite o nome do paciente";
            // 
            // textBoxNomePaciente
            // 
            this.textBoxNomePaciente.Location = new System.Drawing.Point(194, 32);
            this.textBoxNomePaciente.Name = "textBoxNomePaciente";
            this.textBoxNomePaciente.Size = new System.Drawing.Size(131, 20);
            this.textBoxNomePaciente.TabIndex = 25;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(331, 30);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPaciente.TabIndex = 26;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // dataGridViewPaciente
            // 
            this.dataGridViewPaciente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaciente.Location = new System.Drawing.Point(12, 187);
            this.dataGridViewPaciente.MultiSelect = false;
            this.dataGridViewPaciente.Name = "dataGridViewPaciente";
            this.dataGridViewPaciente.ReadOnly = true;
            this.dataGridViewPaciente.Size = new System.Drawing.Size(776, 60);
            this.dataGridViewPaciente.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 31);
            this.label8.TabIndex = 28;
            this.label8.Text = "Paciente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(643, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 26);
            this.label9.TabIndex = 29;
            this.label9.Text = "Verifique as informações \r\nantes de despachar o pedido";
            // 
            // dataGridViewAparelho
            // 
            this.dataGridViewAparelho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAparelho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAparelho.Location = new System.Drawing.Point(12, 284);
            this.dataGridViewAparelho.MultiSelect = false;
            this.dataGridViewAparelho.Name = "dataGridViewAparelho";
            this.dataGridViewAparelho.ReadOnly = true;
            this.dataGridViewAparelho.Size = new System.Drawing.Size(776, 66);
            this.dataGridViewAparelho.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 31);
            this.label10.TabIndex = 31;
            this.label10.Text = "Aparelho:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 32;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDespachar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewAparelho);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewPaciente);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.textBoxNomePaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDespachar);
            this.Controls.Add(this.msk_Placa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Veiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDespachar";
            this.Text = "FrmDespachar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAparelho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Veiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msk_Placa;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomePaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.DataGridView dataGridViewPaciente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewAparelho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}