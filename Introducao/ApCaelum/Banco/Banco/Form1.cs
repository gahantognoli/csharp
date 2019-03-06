using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {

        private Conta conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta = new Conta();
            conta.Numero = 1;
            Cliente cliente = new Cliente("Victor");
            conta.Titular = cliente;

            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Depositar(valorOperacao);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            MessageBox.Show("Sucesso!");

            //Conta c1 = new ContaPoupanca();
            //c1.Depositar(100.0);
            //c1.Sacar(50.0);
            //MessageBox.Show("conta	poupança	=	" + c1.Saldo);


            //Conta c2 = new Conta();
            //c2.Depositar(100.0);
            //c2.Sacar(50.0);
            //MessageBox.Show("conta	=	" + c2.Saldo);
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Sacar(valorOperacao);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            MessageBox.Show("Sucesso!");
        }
    }
}
