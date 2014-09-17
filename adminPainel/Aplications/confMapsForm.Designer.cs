namespace adminPainel
{
    partial class confMapsForm
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
            this.adicionar = new System.Windows.Forms.Button();
            this.nomeMap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remover = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.listMap = new System.Windows.Forms.ListBox();
            this.editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(250, 35);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(60, 23);
            this.adicionar.TabIndex = 1;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // nomeMap
            // 
            this.nomeMap.Location = new System.Drawing.Point(197, 9);
            this.nomeMap.Name = "nomeMap";
            this.nomeMap.Size = new System.Drawing.Size(113, 20);
            this.nomeMap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(40, 227);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 4;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(235, 227);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 23);
            this.fechar.TabIndex = 5;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(154, 227);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 6;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // listMap
            // 
            this.listMap.FormattingEnabled = true;
            this.listMap.Location = new System.Drawing.Point(12, 9);
            this.listMap.Name = "listMap";
            this.listMap.Size = new System.Drawing.Size(135, 212);
            this.listMap.TabIndex = 7;
            this.listMap.SelectedIndexChanged += new System.EventHandler(this.listMap_SelectedIndexChanged);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(197, 35);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(47, 23);
            this.editar.TabIndex = 8;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // confMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 257);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.listMap);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeMap);
            this.Controls.Add(this.adicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "confMaps";
            this.Text = "Configuração dos Maps";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confMaps_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.TextBox nomeMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button editar;
        public System.Windows.Forms.ListBox listMap;
    }
}