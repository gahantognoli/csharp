using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploLinq3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private static string[] obterTodosArquivosDotNet()
        {
            return
                Directory.GetFiles(
                    @"C:\Windows\Microsoft.NET\Framework\v4.0.30319", "*",
                    SearchOption.AllDirectories
                );
        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            var query = from arquivo in obterTodosArquivosDotNet()
                        let infoArquivo = new FileInfo(arquivo)
                        group infoArquivo by new
                        {
                            Pasta = infoArquivo.DirectoryName,
                            Extensao = infoArquivo.Extension.ToUpper()
                        }
                        into infoArquivosPorPastaExtensao
                        let tamanhoKB = infoArquivosPorPastaExtensao.Sum(ia => ia.Length) / 1024M
                        orderby infoArquivosPorPastaExtensao.Key.Pasta,
                        tamanhoKB descending
                        select new
                        {
                            infoArquivosPorPastaExtensao.Key.Pasta,
                            infoArquivosPorPastaExtensao.Key.Extensao,
                            NumeroArquivos = infoArquivosPorPastaExtensao.Count(),
                            TamanhoKB = tamanhoKB
                        };

            GridView1.DataSource = query;
            GridView1.DataBind();

        }
    }
}