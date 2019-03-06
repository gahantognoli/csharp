using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace DevZip
{
    public partial class FrmZip : Form
    {
        public FrmZip()
        {
            InitializeComponent();
        }

        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.SelectedPath;
                txtSource.Text = path;
                foreach (var arquivo in Directory.GetFiles(path))
                {
                    lbArquivos.Items.Add(arquivo);
                }
            }
        }

        private void btnTargetFile_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = dlg.SelectedPath;
            }
        }

        private void btnCompactar_Click(object sender, EventArgs e)
        {
            string pathToZip = txtSource.Text;
            string targetZip = txtTarget.Text;
            string fileName = txtFileName.Text;

            ZipFile.CreateFromDirectory(pathToZip, fileName);
            MessageBox.Show("Arquivo zipado com sucesso!");

        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = saveDlg.FileName;
            }
        }
    }



}
