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

namespace FileInformations
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                ShowFileInfo(openDlg.FileName);
            }
        }

        private void ShowFileInfo(string fileName)
        {
            Text = fileName;
            FileInfo info = new FileInfo(fileName);
            txtCriacao.Text = info.CreationTime.ToString();
            txtAcesso.Text = info.LastAccessTime.ToString();
            txtDataModicacao.Text = info.LastWriteTime.ToString();
            txtNome.Text = info.Name;
            txtDiretorio.Text = info.Directory.FullName;
            txtTamanho.Text = info.Length.ToString();
            txtExtensao.Text = info.Extension;
            checkBox1.Checked = info.IsReadOnly;

            txtAtributos.Text = info.Attributes.ToString();

        }
    }
}
