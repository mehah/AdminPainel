using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace adminPainel
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
        }

        public void Start(String title, Int32 maxCnt)
        {
            Text = title;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = maxCnt;
            Show();
        }

        public void UpdateBar()
        {
            progressBar1.Value += 1;
        }

        public void Stop()
        {
            progressBar1.Value = 0;
            Hide();
        }
    }
}
