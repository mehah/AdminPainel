using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Biblioteca;

namespace adminPainel
{
    public partial class autoRestartForm : Form
    {
        private Process process;
        private IntPtr mainHandle;
        private Timer mainEvent;

        private Int32 count = 20;
        public autoRestartForm(Process process, IntPtr mainHandle, Timer mainEvent)
        {
            InitializeComponent();
            this.process = process;
            this.mainHandle = mainHandle;
            this.mainEvent = mainEvent;

            mainEvent.Enabled = false;

            Text = "autoRestart (" + process.File + ")";
            label1.Text = "O processo " + process.File + " não esta respodendo deseja renicia-lo?\nSerá reniciado em " + count + "s.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count -= 1;
            label1.Text = "O processo " + process.File + " não esta respodendo deseja renicia-lo?\nSerá reniciado em " + count + "s.";
            if (count == 0)
            {
                if(!process.started())
                    process.executeThread(mainHandle);

                mainEvent.Enabled = true;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 1;
            timer1_Tick(null, null);
        }

        private void autoRestart_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainEvent.Enabled == false)
                process.Dispose();
        }
    }
}
