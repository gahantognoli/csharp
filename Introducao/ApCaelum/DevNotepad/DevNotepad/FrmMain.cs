using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DevNotepad
{
    public partial class FrmMain : Form
    {
        private readonly object txt;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(openDlg.ShowDialog() == DialogResult.OK)
            {
                LerArquivo(openDlg.FileName);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(saveDlg.ShowDialog() == DialogResult.OK)
            {
                Salvar(saveDlg.FileName);
            }
        }

        private void LerArquivo(string fileName)
        {
            StreamReader reader = File.OpenText(fileName);
            string str = "";
            StringBuilder sb = new StringBuilder();
            while ((str = reader.ReadLine()) != null)
            {
                sb.AppendLine(str);
            }

            txtArquivo.Text = sb.ToString();

        }

        private void Salvar(string fileName)
        {
            if (!File.Exists(fileName))
            {
                FileStream file = File.Create(fileName);
                Byte[] arquivo = new UTF8Encoding(true).GetBytes(txtArquivo.Text);
                file.Write(arquivo, 0, arquivo.Length);
                file.Close();
            }
        }
    }
}
