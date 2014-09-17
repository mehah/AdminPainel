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
    public partial class confSetForm : Form
    {
        Configurator _conf = new Configurator("conf/", Main.getCurrentPatch());

        String title;
        bool loaded = false;

        bool confModified = false;

        public bool ConfModified { get { return confModified; } }

        public String Title { get { return title; } }

        public Configurator Conf { get { return _conf; } }

        public confSetForm(String title, String arquivo)
        {
            InitializeComponent();
            this.title = title;
            Text = Text + title;
            _conf.Arquivo = _conf.Arquivo + arquivo;
        }

        public void LoadConf()
        {
            if (loaded) // Apenas carrega, se ainda não estiver carregado as configurações
                return;

            if (loaded = _conf.loadFile())
            {
                String linha;
                String comentario;
                string[] _linha;

                for (Int32 i = 0, i2 = 0, c = _conf.ContFile.Length, l = 0; i < c; i++)
                {
                    linha = _conf.ContFile[i];
                    if (!_conf.isComment(linha.Trim()) && linha.Trim().Length > 0 && linha.Contains(':'))
                    {
                        comentario = "";

                        for (i2 = i - 1; i2 > 0; i2--)
                        {
                            if (!_conf.isComment(_conf.ContFile[i2].Trim()))
                            {
                                for (; i2 <= i; i2++)
                                {
                                    String line = _conf.ContFile[i2].Trim();
                                    if (_conf.isComment(line))
                                    {
                                        comentario += line.Replace("//", "");
                                        if (_conf.isComment(_conf.ContFile[i2 + 1].Trim()))
                                            comentario += "\n";
                                    }
                                }
                                break;
                            }
                        }

                        _linha = linha.Split(':');
                        _linha[0] = _linha[0].Trim();
                        _linha[1] = _linha[1].Trim();
                        confDataGrid.Rows.Add(_linha);
                        confDataGrid.Rows[l++].Cells[0].ToolTipText = comentario;
                    }
                }
            }

            confModified = false;
        }

        public void save()
        {
            foreach (DataGridViewRow row in confDataGrid.Rows)
                _conf.setAtr(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());

            _conf.saveFile();

            confModified = false;
        }

        private void fecharConf_Click(object sender, EventArgs e) { Hide(); }
        private void confSalvar_Click(object sender, EventArgs e) { save(); }

        private void confDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            confModified = true;
        }

        private void confSet_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
