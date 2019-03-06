using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CriarButtonEmRuntime_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            //button.Parent = this;
            this.Controls.Add(button);
            button.Text = "Clique aqui";
            button.Location = new Point(58, 80);
            //Delegação
            button.Click += new EventHandler(Button_Click);
            button.Click += delegate (object s, EventArgs ea)
            {
                MessageBox.Show("Mensagem!");
            };
            button.Click += (s, ea) => MessageBox.Show("Lambda");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo!");
        }
    }
}
