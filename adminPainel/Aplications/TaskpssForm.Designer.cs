namespace adminPainel
{
    partial class TaskpssForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskpssForm));
            this.processList = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalizarProcesso = new System.Windows.Forms.Button();
            this.eventProcessList = new System.Windows.Forms.Timer(this.components);
            this.focarProcesso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.processList)).BeginInit();
            this.SuspendLayout();
            // 
            // processList
            // 
            this.processList.AllowUserToAddRows = false;
            this.processList.AllowUserToDeleteRows = false;
            this.processList.AllowUserToResizeRows = false;
            this.processList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.process_id,
            this.type});
            this.processList.Cursor = System.Windows.Forms.Cursors.Default;
            this.processList.Location = new System.Drawing.Point(14, 12);
            this.processList.MultiSelect = false;
            this.processList.Name = "processList";
            this.processList.ReadOnly = true;
            this.processList.RowHeadersVisible = false;
            this.processList.Size = new System.Drawing.Size(301, 150);
            this.processList.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome.Frozen = true;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 298;
            // 
            // process_id
            // 
            this.process_id.HeaderText = "ID";
            this.process_id.Name = "process_id";
            this.process_id.ReadOnly = true;
            this.process_id.Visible = false;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Visible = false;
            // 
            // finalizarProcesso
            // 
            this.finalizarProcesso.Location = new System.Drawing.Point(240, 178);
            this.finalizarProcesso.Name = "finalizarProcesso";
            this.finalizarProcesso.Size = new System.Drawing.Size(75, 23);
            this.finalizarProcesso.TabIndex = 1;
            this.finalizarProcesso.Text = "Finalizar";
            this.finalizarProcesso.UseVisualStyleBackColor = true;
            this.finalizarProcesso.Click += new System.EventHandler(this.finalizarProcessoSelecionado);
            // 
            // eventProcessList
            // 
            this.eventProcessList.Interval = 1000;
            this.eventProcessList.Tick += new System.EventHandler(this.eventProcessList_Tick);
            // 
            // focarProcesso
            // 
            this.focarProcesso.Location = new System.Drawing.Point(143, 178);
            this.focarProcesso.Name = "focarProcesso";
            this.focarProcesso.Size = new System.Drawing.Size(75, 23);
            this.focarProcesso.TabIndex = 2;
            this.focarProcesso.Text = "Focar";
            this.focarProcesso.UseVisualStyleBackColor = true;
            this.focarProcesso.Click += new System.EventHandler(this.focarProcesso_Click);
            // 
            // Taskpss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 219);
            this.Controls.Add(this.focarProcesso);
            this.Controls.Add(this.finalizarProcesso);
            this.Controls.Add(this.processList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Taskpss";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gerenciador de Processos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Taskpss_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.processList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView processList;
        private System.Windows.Forms.Button finalizarProcesso;
        private System.Windows.Forms.Button focarProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        public System.Windows.Forms.Timer eventProcessList;

    }
}