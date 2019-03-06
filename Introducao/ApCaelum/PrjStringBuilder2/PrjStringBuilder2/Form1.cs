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

namespace PrjStringBuilder2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exemplo StringWritter
            StringWriter stringWriter = new StringWriter();
            stringWriter.WriteLine("Linha 1");
            stringWriter.WriteLine("Linha 2");
            stringWriter.WriteLine("Linha 3");
            stringWriter.WriteLine("Linha 4");

            //MessageBox.Show(stringWriter.ToString());
            txtStrings.Text = stringWriter.ToString();

            //Exemplo StringReader
            string linha = null;
            string msg = null;
            StringReader stringReader = new StringReader(stringWriter.ToString());
            while (true)
            {
                linha = stringReader.ReadLine();
                if (linha == null)
                {
                    break;
                }
                else
                {
                    msg += linha + Environment.NewLine;
                }
            }

            txtStringReader.Text = msg;

        }
    }
}
