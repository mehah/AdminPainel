namespace adminPainel
{
    partial class confSetForm
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
            this.confDataGrid = new System.Windows.Forms.DataGridView();
            this.conf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confSalvar = new System.Windows.Forms.Button();
            this.fecharConf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.confDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // confDataGrid
            // 
            this.confDataGrid.AllowUserToAddRows = false;
            this.confDataGrid.AllowUserToResizeRows = false;
            this.confDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conf,
            this.param});
            this.confDataGrid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.confDataGrid.Location = new System.Drawing.Point(3, 12);
            this.confDataGrid.MultiSelect = false;
            this.confDataGrid.Name = "confDataGrid";
            this.confDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.confDataGrid.RowHeadersVisible = false;
            this.confDataGrid.Size = new System.Drawing.Size(479, 180);
            this.confDataGrid.TabIndex = 0;
            this.confDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.confDataGrid_CellValueChanged);
            // 
            // conf
            // 
            this.conf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.conf.HeaderText = "Configuração";
            this.conf.Name = "conf";
            this.conf.ReadOnly = true;
            this.conf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.conf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.conf.Width = 239;
            // 
            // param
            // 
            this.param.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.param.HeaderText = "Parametro";
            this.param.Name = "param";
            this.param.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.param.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.param.Width = 237;
            // 
            // confSalvar
            // 
            this.confSalvar.Location = new System.Drawing.Point(12, 208);
            this.confSalvar.Name = "confSalvar";
            this.confSalvar.Size = new System.Drawing.Size(75, 23);
            this.confSalvar.TabIndex = 1;
            this.confSalvar.Text = "Salvar";
            this.confSalvar.UseVisualStyleBackColor = true;
            this.confSalvar.Click += new System.EventHandler(this.confSalvar_Click);
            // 
            // fecharConf
            // 
            this.fecharConf.Location = new System.Drawing.Point(115, 208);
            this.fecharConf.Name = "fecharConf";
            this.fecharConf.Size = new System.Drawing.Size(75, 23);
            this.fecharConf.TabIndex = 2;
            this.fecharConf.Text = "Fechar";
            this.fecharConf.UseVisualStyleBackColor = true;
            this.fecharConf.Click += new System.EventHandler(this.fecharConf_Click);
            // 
            // confSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(486, 243);
            this.Controls.Add(this.fecharConf);
            this.Controls.Add(this.confSalvar);
            this.Controls.Add(this.confDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "confSet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Configuração de ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confSet_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.confDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView confDataGrid;
        private System.Windows.Forms.Button confSalvar;
        private System.Windows.Forms.Button fecharConf;
        private System.Windows.Forms.DataGridViewTextBoxColumn conf;
        private System.Windows.Forms.DataGridViewTextBoxColumn param;

    }
}