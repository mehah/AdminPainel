using System;
using System.Collections;
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
    public partial class confGrfForm : Form
    {
        Configurator _conf = new Configurator("conf/grf-files.txt", Main.getCurrentPatch());

        String title = "Grf";

        bool loaded = false;

        bool confModified = false;

        public bool ConfModified { get { return confModified; } }

        public String Title { get { return title; } }

        public Configurator Conf { get { return _conf; } }

        public confGrfForm()
        {
            InitializeComponent();
        }

        public void LoadConf()
        {
            if (loaded) // Apenas carrega, se ainda não estiver carregado as configurações
                return;

            if (loaded = _conf.loadFile())
            {
                foreach (string linha in _conf.ContFile)
                {
                    if (!_conf.isComment(linha.Trim()) && linha.Trim().Length > 8 && linha.Contains(':'))
                        listGrf.Items.Add(linha.Substring(9).Trim());
                }
            }
        }

        public void save()
        {
            ArrayList _contFile = new ArrayList();
            foreach (String map in listGrf.Items)
                _contFile.Add("data_dir: " + map);

            _conf.ContFile = new String[_contFile.Count];
            _contFile.CopyTo(_conf.ContFile);

            _conf.saveFile();

            confModified = false;
        }

        private void adcionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = currentPatch;
            openFileDialog.Filter = "Grf Files (*.grf)|*.grf|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                listGrf.Items.Add(openFileDialog.FileName);
                confModified = true;
            }
            openFileDialog.Dispose();
            openFileDialog = null;
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            save();
        }

        private void remover_Click(object sender, EventArgs e)
        {
            listGrf.Items.Remove(listGrf.SelectedItem);
            confModified = true;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void confGrf_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if (e.CloseReason == CloseReason.UserClosing)
                Hide();
        }
    }
}
