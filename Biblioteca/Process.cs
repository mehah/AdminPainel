// Por Mehah(Renato)

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Biblioteca
{
    public class Process
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(
            IntPtr hwndParent,
            IntPtr hwndChildAfter,
            string lpszClass,
            string lpszWindow);

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(
            IntPtr hWndChild,
            IntPtr hWndNewParent);

        private String file;
        
        private bool autoRestart = false;
        private System.Diagnostics.Process process;

        public String File
        {
            get { return file; }
            set { file = value; }
        }

        public bool AutoRestart
        {
            get { return autoRestart; }
            set { autoRestart = value; }
        }

        public IntPtr Handle
        {
            get { return process.MainWindowHandle; }
        }

        public Process() { }

        public void kill() { process.Kill(); }

        public void start(IntPtr handleClient) { start(handleClient, true); }

        public void start(IntPtr handleClient, bool checkFile)
        {
            if (started())
                    MessageBox.Show("Já possui um processo aberto do " + file + ".");
            else if(checkFile && !System.IO.File.Exists(file))
                MessageBox.Show("Arquivo " + file + " não encontrado.");
            else if (handleClient != IntPtr.Zero)
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = file;

                if (proc.Start())
                {
                    while (true)
                    {
                        process = System.Diagnostics.Process.GetProcessById(proc.Id);
                        if (started())
                        {
                            SetParent(process.MainWindowHandle, handleClient);
                            proc.Dispose();
                            break;
                        }
                        System.Threading.Thread.Sleep(Convert.ToInt32(Enums.Thread.Sleep));
                    }
                }else
                    MessageBox.Show("Não foi possivel executar o processo do " + file + ".");
            }
        }

        public bool started()
        {
            return (process != null && process.MainWindowHandle != IntPtr.Zero && process.Responding);
        }

        public void executeThread(IntPtr mainHandle)
        {
            Thread thread = new Thread(new ThreadStart(delegate { System.Threading.Thread.Sleep(Convert.ToInt32(Enums.Thread.Sleep)); start(mainHandle); }));
            thread.Start(); 
        }

        public void Dispose() { if(process != null) process.Dispose(); }
    }
}
