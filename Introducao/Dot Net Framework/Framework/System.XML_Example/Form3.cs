using System.Windows.Forms;
using System.Xml;

namespace System.XML_Example
{
    public partial class Form3 : Form
    {
        string arquivo = @"C:\temp\Agenda.xml";
        XmlDocument xmlDocument = new XmlDocument();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
