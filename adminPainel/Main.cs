using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Runtime.InteropServices;
using System.IO;
using Biblioteca;

namespace adminPainel
{
    public partial class Main : Form
    {
        private static String currentPatch = Environment.CurrentDirectory;

        private IntPtr mainHandle;

        private ProgressBarForm progressBar = new ProgressBarForm();

        private static List<Process> processList = new List<Process>();
        private static List<Form> formList = new List<Form>();

        public static List<Form> FormList { get { return formList; } }
        public static List<Process> ProcessList { get { return processList; } }
        public static String getCurrentPatch() { return currentPatch; }

        // CONSTANTES
        public static readonly Int32 LOGIN = 0;
        public static readonly Int32 CHAR = 1;
        public static readonly Int32 MAP = 2;

        public Main()
        {
            InitializeComponent();

            notifyIcon1.Text = Text;

            MdiClient mdi = this.Controls[this.Controls.Count - 1] as MdiClient;
            mainHandle = mdi.Handle;

            updateTimeDay();

            for (Int32 i = LOGIN; i <= MAP; i++)
                processList.Add(new Process());

            formList.Add(new confMapsForm());
            formList.Add(new confGrfForm());
            formList.Add(new TaskpssForm());
            formList.Add(new StatusForm());
            formList.Add(new confSetForm("Login", "login_athena.conf"));
            formList.Add(new confSetForm("Char", "char_athena.conf"));
            formList.Add(new confSetForm("Map", "map_athena.conf"));
            formList.Add(new confSetForm("atCommand", "atcommand_athena.conf"));
            formList.Add(new confSetForm("charCommand", "charcommand_athena.conf"));
            formList.Add(new confSetForm("Inter", "inter_athena.conf"));
            formList.Add(new confSetForm("lAdmin", "ladmin_athena.conf"));
            formList.Add(new confSetForm("Log", "log_athena.conf"));
            formList.Add(new confSetForm("Msg", "msg_athena.conf"));
            formList.Add(new confSetForm("Packet", "packet_athena.conf"));
            formList.Add(new confSetForm("Plugin", "plugin_athena.conf"));
            formList.Add(new confSetForm("Script", "script_athena.conf"));
            formList.Add(new confSetForm("Subnet", "subnet_athena.conf"));
            formList.Add(new confSetForm("Battle", "battle/battle.conf"));
            formList.Add(new confSetForm("Client", "battle/client.conf"));
            formList.Add(new confSetForm("Drops", "battle/drops.conf"));
            formList.Add(new confSetForm("Exp", "battle/exp.conf"));
            formList.Add(new confSetForm("Gm", "battle/gm.conf"));
            formList.Add(new confSetForm("Guild", "battle/guild.conf"));
            formList.Add(new confSetForm("Homunc", "battle/homunc.conf"));
            formList.Add(new confSetForm("Items", "battle/items.conf"));
            formList.Add(new confSetForm("Misc", "battle/misc.conf"));
            formList.Add(new confSetForm("Monster", "battle/monster.conf"));
            formList.Add(new confSetForm("Party", "battle/party.conf"));
            formList.Add(new confSetForm("Pet", "battle/pet.conf"));
            formList.Add(new confSetForm("Player", "battle/player.conf"));
            formList.Add(new confSetForm("Skill", "battle/skill.conf"));
            formList.Add(new confSetForm("Status", "battle/status.conf"));

            progressBar.Start("Carregando Painel de Controle", formList.Count);
            foreach (Control conf in formList)
            {
                if (conf is confSetForm)
                    ((confSetForm)conf).LoadConf();
                else if (conf is confMapsForm)
                    ((confMapsForm)conf).LoadConf();
                else if (conf is confGrfForm)
                    ((confGrfForm)conf).LoadConf();

                ((Form)conf).MdiParent = this;
                progressBar.UpdateBar();
            }
            progressBar.Stop();
        }

        private void confOption_Click(object sender, EventArgs e)
        {
            String file = "";
            String title = "";
            Timer timer = null;

            foreach (Control conf in formList)
            {
                if (conf is confSetForm)
                {
                    file = ((confSetForm)conf).Conf.Arquivo;
                    title = ((confSetForm)conf).Title;
                }
                else if (conf is confMapsForm)
                {
                    file = ((confMapsForm)conf).Conf.Arquivo;
                    title = ((confMapsForm)conf).Title;
                }
                else if (conf is confGrfForm)
                {
                    file = ((confGrfForm)conf).Conf.Arquivo;
                    title = ((confGrfForm)conf).Title;
                }
                else if (conf is TaskpssForm)
                {
                    file = "";
                    title = ((TaskpssForm)conf).Text;
                    timer = ((TaskpssForm)conf).eventProcessList;
                }
                else if (conf is StatusForm)
                {
                    file = "";
                    title = ((StatusForm)conf).Text;
                }

                if (title == sender.ToString())
                {
                    if (file != "" && !File.Exists(currentPatch + "/" + file))
                    {
                        MessageBox.Show("Não foi possivel encontrar o arquivo " + file + ".");
                        break;
                    }
                    else if (((Form)conf).Created)
                    {
                        ((Form)conf).Hide();
                        // Codigo desativado por haver um pequeno bug quando é para dar focus,
                        // quando ele já esta focado atraz de um processo de outro sistema
                        //    ((Form)conf).Focus();
                    }
                    else
                    {
                        if (timer != null)
                            timer.Enabled = true;
                        //((Form)conf).LoadConf();
                    }
                    ((Form)conf).Show();
                    break;
                }
            }
        }

        protected Boolean startedAllServers = false;

        private void startAllServers_Click(object sender, EventArgs e)
        {
            iniciarLoginServer_Click(null, null);
            iniciarCharServer_Click(null, null);
            iniciarMapServer_Click(null, null);
            startedAllServers = true;
        }

        private void updateTimeDay() { timeDay.Text = DateTime.Now.ToString(); }

        private bool haveConfModified()
        {
            foreach (Control conf in formList)
            {
                if (
                    conf is confSetForm && ((confSetForm)conf).ConfModified ||
                    conf is confMapsForm && ((confMapsForm)conf).ConfModified ||
                    conf is confGrfForm && ((confGrfForm)conf).ConfModified
                )
                    return true;
            }

            return false;
        }

        private bool haveProcessStarted()
        {
            foreach (Process process in processList)
            {
                if (process.started())
                    return true;
            }

            foreach (Control process in formList)
            {
                if (((Form)process).Created)
                    return true;
            }

            return false;
        }

        protected void checkProcess(Int32 id, Boolean autoRestartChecked, Timer eventAutoRestart)
        {
            Process process = processList[id]; // Map Server
            if (!process.started())
            {
                if (startedAllServers)
                    autoRestartChecked = autoRestartTodos.Checked;

                if (autoRestartChecked)
                {
                    autoRestartForm autoRestart = new autoRestartForm(process, mainHandle, eventAutoRestart);
                    autoRestart.MdiParent = this;
                    autoRestart.Show();
                }
                else
                {
                    eventAutoRestart.Enabled = false;
                    startedAllServers = false;
                    process.Dispose();
                }
            }
        }

        private StatusForm getStatusForm()
        {
            foreach (Control form in formList)
            {
                if (form is StatusForm)
                    return ((StatusForm)form);
            }

            return null;
        }

        private void saveAllConf()
        {
            progressBar.Start("Salvando as Configurações", formList.Count);
            foreach (Control conf in formList)
            {
                if (conf is confSetForm && ((confSetForm)conf).ConfModified)
                    ((confSetForm)conf).save();
                else if (conf is confMapsForm && ((confMapsForm)conf).ConfModified)
                    ((confMapsForm)conf).save();
                else if (conf is confGrfForm && ((confGrfForm)conf).ConfModified)
                    ((confGrfForm)conf).save();
                progressBar.UpdateBar();
            }
            progressBar.Stop();
        }

        private void salvarConfiguraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que deseja salvar todas as configurações modificadas?",
            "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                saveAllConf();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobreForm sobre = new SobreForm();
            sobre.ShowDialog(this);
            sobre.Dispose();
            sobre = null;
        }

        private void iniciarLoginServer_Click(object sender, EventArgs e)
        {
            Process process = processList[LOGIN];
            process.File = (sender.ToString() == "Iniciar SQL" ? "login-server_sql.exe" : "login-server.exe");
            process.executeThread(mainHandle);
            eventAutoRestartLogin.Enabled = true;
        }

        private void iniciarCharServer_Click(object sender, EventArgs e)
        {
            Process process = processList[CHAR];
            process.File = (sender.ToString() == "Iniciar SQL" ? "char-server_sql.exe" : "char-server.exe");
            process.executeThread(mainHandle);
            eventAutoRestartChar.Enabled = true;
        }

        private void iniciarMapServer_Click(object sender, EventArgs e)
        {
            Process process = processList[MAP];
            process.File = (sender.ToString() == "Iniciar SQL" ? "map-server_sql.exe" : "map-server.exe");
            process.executeThread(mainHandle);
            eventAutoRestartMap.Enabled = true;
        }

        private void Painel_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Hide();
            else
            {
                menuStrip.Width = Width - 220;
                panel2.Location = new Point(Width - 214, panel2.Location.Y);
            }
        }

        private void Painel_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Process process in processList)
            {
                if (process.started())
                    process.kill();
            }

            foreach (Form process in formList)
            {
                if (process.Created)
                    process.Close();
            }
        }

        private void Painel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(haveConfModified())
            {
                if(MessageBox.Show("Possui configurações modificadas que ainda não foram salvas, desejar salva-las?", "Alerta!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    saveAllConf();
            }

            if (haveProcessStarted())
                e.Cancel = (MessageBox.Show("Possui processos abertos, tem certeza que deseja sair?", "Alerta!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No);
            else
                e.Cancel = false;
        }

        private void autoRestartLogin_Tick(object sender, EventArgs e)
        {
            Process loginServer = processList[LOGIN];
            loginServer.start(mainHandle);
        }

        private void globalEvent_Tick(object sender, EventArgs e)
        {
            StatusForm statusForm = getStatusForm();
            if (statusForm != null)
            {
                for (Int32 i = LOGIN; i <= MAP; i++)
                {
                    String status = (processList[i].started() ? "LIGADO" : "DESLIGADO");
                    if (i == LOGIN)
                        statusForm.statusLogin.Text = status;
                    else if (i == CHAR)
                        statusForm.statusChar.Text = status;
                    else if (i == MAP)
                        statusForm.statusMap.Text = status;
                }
            }
            updateTimeDay();
        }

        private void eventAutoRestartLogin_Tick(object sender, EventArgs e)
        {
            checkProcess(0, autoRestartLogin.Checked,eventAutoRestartLogin);
        }

        private void eventAutoRestartChar_Tick(object sender, EventArgs e)
        {
            checkProcess(1, autoRestartChar.Checked, eventAutoRestartChar);
        }

        private void eventAutoRestartMap_Tick(object sender, EventArgs e)
        {
            checkProcess(2, autoRestartMap.Checked , eventAutoRestartMap);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
