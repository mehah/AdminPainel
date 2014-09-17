namespace adminPainel
{
    partial class SobreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.developer = new System.Windows.Forms.Label();
            this.versao = new System.Windows.Forms.Label();
            this.companhia = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // developer
            // 
            this.developer.AutoSize = true;
            this.developer.Location = new System.Drawing.Point(9, 99);
            this.developer.Name = "developer";
            this.developer.Size = new System.Drawing.Size(85, 13);
            this.developer.TabIndex = 1;
            this.developer.Text = "Desenvolvedor: ";
            this.developer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versao
            // 
            this.versao.AutoSize = true;
            this.versao.Location = new System.Drawing.Point(151, 99);
            this.versao.Name = "versao";
            this.versao.Size = new System.Drawing.Size(46, 13);
            this.versao.TabIndex = 2;
            this.versao.Text = "Versão: ";
            // 
            // companhia
            // 
            this.companhia.AutoSize = true;
            this.companhia.Location = new System.Drawing.Point(247, 99);
            this.companhia.Name = "companhia";
            this.companhia.Size = new System.Drawing.Size(66, 13);
            this.companhia.TabIndex = 3;
            this.companhia.Text = "Campanhia: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(334, 42);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Ferramenta administrativa para emuladores baseado no Athena.\n";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(271, 191);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 5;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SobreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 226);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.companhia);
            this.Controls.Add(this.versao);
            this.Controls.Add(this.developer);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SobreForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do Painel de Controle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label developer;
        private System.Windows.Forms.Label versao;
        private System.Windows.Forms.Label companhia;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ok;

    }
}
