namespace adminPainel
{
    partial class confGrfForm
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
            this.listGrf = new System.Windows.Forms.ListBox();
            this.adcionar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.remover = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listGrf
            // 
            this.listGrf.FormattingEnabled = true;
            this.listGrf.HorizontalScrollbar = true;
            this.listGrf.Location = new System.Drawing.Point(12, 12);
            this.listGrf.Name = "listGrf";
            this.listGrf.Size = new System.Drawing.Size(238, 108);
            this.listGrf.TabIndex = 0;
            // 
            // adcionar
            // 
            this.adcionar.Location = new System.Drawing.Point(256, 12);
            this.adcionar.Name = "adcionar";
            this.adcionar.Size = new System.Drawing.Size(75, 23);
            this.adcionar.TabIndex = 1;
            this.adcionar.Text = "Adicionar";
            this.adcionar.UseVisualStyleBackColor = true;
            this.adcionar.Click += new System.EventHandler(this.adcionar_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(256, 70);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 2;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(256, 41);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 3;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(256, 99);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 23);
            this.fechar.TabIndex = 4;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // confGrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 129);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.adcionar);
            this.Controls.Add(this.listGrf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "confGrf";
            this.Text = "Configuração dos Grf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confGrf_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listGrf;
        private System.Windows.Forms.Button adcionar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button fechar;
    }
}