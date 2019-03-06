using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta() {
                Numero = 1,
                Cliente = new Cliente() {
                    Cpf = "416.367.418-78",
                    Endereco = "Praça Conego Emilio",
                    Rg = "37.890.902-9",
                    Nome = "Gabriel"
                }
            };

            Conta conta2 = new Conta()
            {
                Numero = 2,
                Cliente = new Cliente()
                {
                    Cpf = "418.213.428-18",
                    Endereco = "Avenida dos Palmares",
                    Rg = "47.891.912-9",
                    Nome = "Joana"
                }
            };

            Conta conta3 = new Conta()
            {
                Numero = 3,
                Cliente = new Cliente()
                {
                    Cpf = "216.137.111-18",
                    Endereco = "Coronel Walter",
                    Rg = "17.190.892-1",
                    Nome = "Marcio"
                }
            };

            conta1.Sacar(1000);
            conta2.Depositar(18000);
            conta3.Sacar(239.29);

            MessageBox.Show("Nome : " + conta1.Cliente.Nome + " Saldo: " + conta1.Saldo);
            MessageBox.Show("Nome : " + conta2.Cliente.Nome + " Saldo: " + conta2.Saldo);
            MessageBox.Show("Nome : " + conta3.Cliente.Nome + " Saldo: " + conta3.Saldo);
            
        }
    }
}
