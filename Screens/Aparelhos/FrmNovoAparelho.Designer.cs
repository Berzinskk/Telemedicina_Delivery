namespace test_delivery.Screens
{
    partial class FrmNovoAparelho
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNserie = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.checkedListBoxAcessorios = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de aparelho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº de Série:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(317, 438);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(138, 41);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "Cadastrar";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(479, 37);
            this.txtNome.TabIndex = 10;
            // 
            // txtNserie
            // 
            this.txtNserie.Location = new System.Drawing.Point(21, 242);
            this.txtNserie.Name = "txtNserie";
            this.txtNserie.Size = new System.Drawing.Size(479, 37);
            this.txtNserie.TabIndex = 11;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(529, 438);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 41);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // checkedListBoxAcessorios
            // 
            this.checkedListBoxAcessorios.BackColor = System.Drawing.Color.LightSteelBlue;
            this.checkedListBoxAcessorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxAcessorios.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkedListBoxAcessorios.FormattingEnabled = true;
            this.checkedListBoxAcessorios.Items.AddRange(new object[] {
            "Acessório 1",
            "Acessório 2",
            "Acessório 3"});
            this.checkedListBoxAcessorios.Location = new System.Drawing.Point(26, 339);
            this.checkedListBoxAcessorios.Name = "checkedListBoxAcessorios";
            this.checkedListBoxAcessorios.Size = new System.Drawing.Size(231, 96);
            this.checkedListBoxAcessorios.TabIndex = 0;
            this.checkedListBoxAcessorios.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Extras";
            // 
            // FrmNovoAparelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBoxAcessorios);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtNserie);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmNovoAparelho";
            this.Text = "FrmNovoAparelho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNserie;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.CheckedListBox checkedListBoxAcessorios;
        private System.Windows.Forms.Label label4;
    }
}