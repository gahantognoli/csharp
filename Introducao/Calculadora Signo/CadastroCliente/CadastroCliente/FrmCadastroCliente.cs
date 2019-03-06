using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CadastroCliente
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Cria o dataset, que pode ser uma coleção de tabelas
            DataSet dataSet = new DataSet("Dados");
            //Cria a tabela em memória
            DataTable tabela = new DataTable("Clientes");
            
            //Criação das colunas 
            tabela.Columns.Add(new DataColumn("Codigo"));
            tabela.Columns.Add(new DataColumn("Nome"));
            tabela.Columns.Add(new DataColumn("Fone"));
            tabela.Columns.Add(new DataColumn("Email"));

            //Adiciona tabela ao dataset
            dataSet.Tables.Add(tabela);

            //adiciona os registros na tabela
            //criar os registros
            DataRow registro = tabela.NewRow();
            registro["Codigo"] = txtCodigo.Text;
            registro["Nome"] = txtNome.Text;
            registro["Fone"] = txtTelefone.Text;
            registro["Email"] = txtEmail.Text;
            tabela.Rows.Add(registro);
            //Grava arquivo xml
            dataSet.WriteXml(@".\cliente_" + txtCodigo.Text + ".xml");

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //Cria o dataset
            DataSet dataSet = new DataSet();
            //Le o dataset do disco
            dataSet.ReadXml(@".\cliente_" + txtCodigo.Text + ".xml");
            //Primeiro datable da coleção do dataset
            DataTable tabela = dataSet.Tables["Clientes"];
            //primeiro registro da tabela (xml)
            DataRow registro = tabela.Rows[0];
            txtNome.Text = registro["Nome"].ToString();
            txtTelefone.Text = registro["Fone"].ToString();
            txtEmail.Text = registro["Email"].ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (TextBox campo in Controls)
            {
                if (campo is TextBox)
                {
                    (campo as TextBox).Clear();
                }
            }
        }
    }
}
