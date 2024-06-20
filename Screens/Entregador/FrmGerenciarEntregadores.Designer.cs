namespace test_delivery.Screens.Entregador
{
    partial class FrmGerenciarEntregadores
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
            this.dataGridViewEntregadores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntregadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEntregadores
            // 
            this.dataGridViewEntregadores.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewEntregadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntregadores.Location = new System.Drawing.Point(41, 75);
            this.dataGridViewEntregadores.Name = "dataGridViewEntregadores";
            this.dataGridViewEntregadores.Size = new System.Drawing.Size(720, 303);
            this.dataGridViewEntregadores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerenciar entregadores";
            // 
            // FrmGerenciarEntregadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEntregadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenciarEntregadores";
            this.Text = "FrmGerenciarEntregadores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntregadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEntregadores;
        private System.Windows.Forms.Label label1;
    }
}