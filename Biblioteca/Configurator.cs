using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Biblioteca
{
    public class Configurator
    {
        String currentPatch;
        String patch;

        string arquivo;

        string[] contFile;

        public Configurator(string arquivo, string patch)
        {
            this.arquivo = arquivo;
            this.patch = patch;
            this.currentPatch = patch + "/" + arquivo;
        }

        public bool isComment(string line)
        {
            return (line.Length >= 2 && line[0] == '/' && line[1] == '/');
        }

        public void setAtr(string conf, string res)
        {
            for (int i = 0; i < contFile.Length; i++)
            {
                if (!isComment(contFile[i].Trim()))
                {
                    string[] _linha = contFile[i].Split(':');
                    if (_linha[0].Trim() == conf)
                    {
                        contFile[i] = conf + ": " + res;
                        break;
                    }
                }
            }
        }

        public string getAtr(string conf)
        {
            string resultado = "";

            foreach (string linha in contFile)
            {
                if (!isComment(linha.Trim()))
                {
                    string[] _linha = linha.Split(':');
                    if (_linha[0].Trim() == conf)
                    {
                        resultado = _linha[1].Trim();
                        break;
                    }
                }
            }

            return resultado;
        }

        public bool loadFile()
        {
            if (!File.Exists(this.currentPatch))
                return false;

            StreamReader stream = new StreamReader(this.currentPatch, Encoding.GetEncoding("ISO-8859-1"));
            string linha = null;
            ArrayList _contFile = new ArrayList();

            while ((linha = stream.ReadLine()) != null)
                _contFile.Add(linha);

            contFile = new string[_contFile.Count];
            _contFile.CopyTo(contFile);

            stream.Close();
            stream.Dispose();
            stream = null;

            return true;
        }

        public bool saveFile()
        {
            if (!File.Exists(this.currentPatch))
                return false;

            StreamWriter stream = new StreamWriter(this.currentPatch, false, Encoding.GetEncoding("ISO-8859-1"));

            foreach (string linha in contFile)
                stream.WriteLine(linha);

            stream.Close();
            stream.Dispose();
            stream = null;

            return true;
        }

        public string Arquivo
        {
            get { return arquivo; }
            set { arquivo = value; currentPatch = patch + "/" + value; }
        }

        public string[] ContFile
        {
            get { return contFile; }
            set { contFile = value; }
        }

    }
}
