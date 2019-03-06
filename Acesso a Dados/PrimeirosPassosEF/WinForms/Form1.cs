using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private ProductDBContext context;

        public Form1()
        {
            InitializeComponent();
            //Criar a base de dados
            context = new ProductDBContext();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja()
            {
                Nome = "Loja Teste"
            };

            //Adiciona a Loja a coleção de BdSet<Lojas>
            context.Lojas.Add(loja);

            Produto produto = new Produto()
            {
                Nome = "AAA",
                Valor = 20,
                Loja = loja
            };

            //Adciona a Produto a coleção de BdSet<Produtos>
            context.Produtos.Add(produto);

            //Salva as alterações do contexto no banco de dados.
            context.SaveChanges();
        }

        private void btnSelectMoreInsert_Click(object sender, EventArgs e)
        {
            Loja loja = context.Lojas.Find(2);
            Produto produtoNovo = new Produto()
            {
                Nome = "Novo produto",
                Valor = 10,
                Loja = loja
            };

            context.Produtos.Add(produtoNovo);

            context.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = context.Produtos.Find(3);
            MessageBox.Show($"Produto: {produto.Nome}");
        }

        private void btnSelectWhere_Click(object sender, EventArgs e)
        {
            IEnumerable<Produto> produtoComecadosComA =
                context.Produtos.Where(p => p.Nome.StartsWith("A"));

            IEnumerable<Produto> produtosDaLoja =
                context.Produtos.Where(p => p.LojaId == 3);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Loja loja = context.Lojas.Find(2);
            loja.Nome = "Teste update";

            Produto produto = context.Produtos.Find(3);
            produto.Nome = "Teste Update";

            loja.Produtos.ForEach(p => p.Valor += p.Valor * 0.1m);

            context.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Loja loja = context.Lojas.Find(3);
            //Remove Loja
            context.Lojas.Remove(loja);

            //Remove Produto
            context.Produtos.Remove(context.Produtos.Find(3));

            context.SaveChanges();
        }

        private void btnUpdateEntityState_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto()
            {
                Id = 2,
                Nome = "Teste EntityState",
                LojaId = 1
            };

            context.Entry(produto).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
