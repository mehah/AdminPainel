using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//using System.Diagnostics;
using Biblioteca;

namespace adminPainel
{
    public partial class TaskpssForm : Form
    {

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public TaskpssForm()
        {
            InitializeComponent();       
        }

        private void finalizarProcessoSelecionado(object sender, EventArgs e)
        {
            if (processList.Rows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Tem certeza que deseja finalizar este processo?",
                "Aviso do Gerenciador de Processos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    DataGridViewCellCollection process = processList.CurrentRow.Cells;
                    if (process[2].Value.ToString() == "1")
                        Main.ProcessList[Convert.ToInt32(process[1].Value)].kill();
                    else if (process[2].Value.ToString() == "2")
                        Main.FormList[Convert.ToInt32(process[1].Value)].Close();
                }
            }
         }

        private void eventProcessList_Tick(object sender, EventArgs e)
        {
            string[] _process = new string[3];

            for (Int32 i = 0, count = Main.ProcessList.Count; i < count; i++)
            {
                Process process = Main.ProcessList[i];
                foreach (DataGridViewRow row in processList.Rows)
                {
                    if (row.Cells[0].Value.ToString() == process.File && !process.started())
                        processList.Rows.Remove(row);
                }

                if (process.started() && !inProcessList(process.File))
                {
                    _process[0] = process.File;
                    _process[1] = i.ToString();
                    _process[2] = "1";
                    processList.Rows.Add(_process);
                }
            }

            String title = "";
            bool created = false;

            for (Int32 i = 0, count = Main.FormList.Count; i < count; i++)
            {
                if (Main.FormList[i] is confSetForm)
                {
                    title = ((confSetForm)Main.FormList[i]).Text;
                    created = ((confSetForm)Main.FormList[i]).Created;
                }
                else if (Main.FormList[i] is confMapsForm)
                {
                    title = ((confMapsForm)Main.FormList[i]).Text;
                    created = ((confMapsForm)Main.FormList[i]).Created;
                }
                else if (Main.FormList[i] is confGrfForm)
                {
                    title = ((confGrfForm)Main.FormList[i]).Text;
                    created = ((confGrfForm)Main.FormList[i]).Created;
                }
                else if (Main.FormList[i] is StatusForm)
                {
                    title = ((StatusForm)Main.FormList[i]).Text;
                    created = ((StatusForm)Main.FormList[i]).Created;
                }

                foreach (DataGridViewRow row in processList.Rows)
                {
                    if (row.Cells[0].Value.ToString() == title && !created)
                        processList.Rows.Remove(row);
                }

                if (created && !inProcessList(title))
                {
                    _process[0] = title;
                    _process[1] = i.ToString();
                    _process[2] = "2";
                    processList.Rows.Add(_process);
                }
            }
        }

        private void Taskpss_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                eventProcessList.Enabled = false;
                Hide();
            }
        }

        private bool inProcessList(Object param)
        {
            foreach (DataGridViewRow row in processList.Rows)
            {
                if (row.Cells[0].Value.ToString() == param.ToString())
                    return true;
            }

            return false;
        }

        private void focarProcesso_Click(object sender, EventArgs e)
        {
            if (processList.Rows.Count > 0)
            {
                DataGridViewCellCollection process = processList.CurrentRow.Cells;
                if (process[2].Value.ToString() == "1")
                    SetForegroundWindow(Main.ProcessList[Convert.ToInt32(process[1].Value)].Handle);
                else if (process[2].Value.ToString() == "2")
                {
                    Form selected = Main.FormList[Convert.ToInt32(process[1].Value)];
                    if (selected.WindowState == FormWindowState.Minimized)
                        selected.WindowState = FormWindowState.Normal;
                    selected.Focus();
                }
            }
        }
    }
}
