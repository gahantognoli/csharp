using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace System.XML_Example
{
    public partial class Form2 : Form
    {
        string arquivo = @"C:\temp\Agenda2.xml";
        XmlDocument document = new XmlDocument();

        public Form2()
        {
            InitializeComponent();

            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = document.CreateElement("Contatos");
                document.AppendChild(nodeRoot);
                document.Save(arquivo);
            }

            ReadAgenda();
        }

        private void ReadAgenda()
        {
            document.Load(arquivo);
            foreach (XmlNode node in document.GetElementsByTagName("Contato"))
            {
                lblAgenda.Text += "Nome: " + node.Attributes["nome"].Value + "\nTelefone: "
                    + node.Attributes["telefone"].Value + "\n\n";
            }
        }

        private void Add()
        {
            
        }
    }
}
