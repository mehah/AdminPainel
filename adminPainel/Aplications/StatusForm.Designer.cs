namespace adminPainel
{
    partial class StatusForm
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelChar = new System.Windows.Forms.Label();
            this.labelMap = new System.Windows.Forms.Label();
            this.statusLogin = new System.Windows.Forms.Label();
            this.statusChar = new System.Windows.Forms.Label();
            this.statusMap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login:";
            // 
            // labelChar
            // 
            this.labelChar.AutoSize = true;
            this.labelChar.Location = new System.Drawing.Point(12, 32);
            this.labelChar.Name = "labelChar";
            this.labelChar.Size = new System.Drawing.Size(32, 13);
            this.labelChar.TabIndex = 1;
            this.labelChar.Text = "Char:";
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Location = new System.Drawing.Point(12, 54);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(31, 13);
            this.labelMap.TabIndex = 2;
            this.labelMap.Text = "Map:";
            // 
            // statusLogin
            // 
            this.statusLogin.AutoSize = true;
            this.statusLogin.Location = new System.Drawing.Point(55, 9);
            this.statusLogin.Name = "statusLogin";
            this.statusLogin.Size = new System.Drawing.Size(10, 13);
            this.statusLogin.TabIndex = 3;
            this.statusLogin.Text = "-";
            // 
            // statusChar
            // 
            this.statusChar.AutoSize = true;
            this.statusChar.Location = new System.Drawing.Point(55, 32);
            this.statusChar.Name = "statusChar";
            this.statusChar.Size = new System.Drawing.Size(10, 13);
            this.statusChar.TabIndex = 4;
            this.statusChar.Text = "-";
            // 
            // statusMap
            // 
            this.statusMap.AutoSize = true;
            this.statusMap.Location = new System.Drawing.Point(55, 54);
            this.statusMap.Name = "statusMap";
            this.statusMap.Size = new System.Drawing.Size(10, 13);
            this.statusMap.TabIndex = 5;
            this.statusMap.Text = "-";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 84);
            this.Controls.Add(this.statusMap);
            this.Controls.Add(this.statusChar);
            this.Controls.Add(this.statusLogin);
            this.Controls.Add(this.labelMap);
            this.Controls.Add(this.labelChar);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Status";
            this.ShowIcon = false;
            this.Text = "Status dos Servidores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Status_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelChar;
        private System.Windows.Forms.Label labelMap;
        public System.Windows.Forms.Label statusLogin;
        public System.Windows.Forms.Label statusChar;
        public System.Windows.Forms.Label statusMap;
    }
}