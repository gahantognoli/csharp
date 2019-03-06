using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace System.XML_Example
{
    public partial class Form1 : Form
    {
        string arquivo = @"C:\temp\Agenda.xml";
        XmlDocument document = new XmlDocument();

        public Form1()
        {
            InitializeComponent();
            
            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = document.CreateElement("Contatos");
                document.AppendChild(nodeRoot);
                document.Save(arquivo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            document.Load(arquivo);

            XmlNode nodeContato = document.CreateElement("Contato");
            document.SelectSingleNode("/Contatos").PrependChild(nodeContato);

            XmlNode nodeNome = document.CreateElement("Nome");
            XmlNode nodeTelefone = document.CreateElement("Telefone");

            nodeNome.InnerText = txtNome.Text;
            nodeTelefone.InnerText = txtTelefone.Text;

            document.SelectSingleNode("Contatos/Contato").AppendChild(nodeNome);
            document.SelectSingleNode("Contatos/Contato").AppendChild(nodeTelefone);

            document.Save(arquivo);

            ReadAgenda();
        }

        private void ReadAgenda()
        {
            document.Load(arquivo);
            foreach (XmlNode node in document.GetElementsByTagName("Contato"))
            {
                lblAgenda.Text += "Nome: " + node.ChildNodes[0].InnerText + "\nTelefone: " 
                    + node.ChildNodes[1].InnerText + "\n\n";
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadAgenda();
        }
    }
}
