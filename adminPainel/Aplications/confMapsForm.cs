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
    public partial class confMapsForm : Form
    {
        Configurator _conf = new Configurator("conf/maps_athena.conf", Main.getCurrentPatch());

        String title = "Maps";

        bool loaded = false;

        bool confModified = false;

        public bool ConfModified { get { return confModified; } }

        public String Title { get { return title; } }

        public Configurator Conf { get { return _conf; } }

        public confMapsForm()
        {
            InitializeComponent();
        }

        public void LoadConf()
        {
            if (loaded) // Apenas carrega, se ainda não estiver carregado as configurações
                return;

            if (loaded = _conf.loadFile())
            {
                string[] _linha;
                foreach (string linha in _conf.ContFile)
                {
                    if (!_conf.isComment(linha.Trim()) && linha.Trim().Length > 0 && linha.Contains(':'))
                    {
                        _linha = linha.Split(':');
                        listMap.Items.Add(_linha[1].Trim());
                    }
                }
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            if (nomeMap.Text.Trim().Length > 0)
            {
                listMap.Items.Add(nomeMap.Text.ToString());
                confModified = true;
            }
        }

        private void remover_Click(object sender, EventArgs e)
        {
            if (listMap.SelectedItem != null)
            {
                listMap.Items.Remove(listMap.SelectedItem);
                confModified = true;
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            save();
        }

        private void listMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listMap.SelectedIndex != -1)
                nomeMap.Text = listMap.SelectedItem.ToString();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (listMap.SelectedIndex != -1)
            {
                listMap.Items[listMap.SelectedIndex] = nomeMap.Text.ToString();
                confModified = true;
            }
        }

        public void save()
        {
            ArrayList _contFile = new ArrayList();
            foreach (String map in listMap.Items)
                _contFile.Add("map: " + map);

            _conf.ContFile = new String[_contFile.Count];
            _contFile.CopyTo(_conf.ContFile);

            _conf.saveFile();
            confModified = false;
        }

        private void confMaps_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if (e.CloseReason == CloseReason.UserClosing)
                Hide();
        }

    }
}
