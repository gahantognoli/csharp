using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqGroupBy
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            var query = from arquivo in Directory.GetFiles(@"c:\windows\system32")
                        let infoArquivo = new FileInfo(arquivo)
                        group infoArquivo by infoArquivo.Extension.ToUpper() into g
                        let extensao = g.Key
                        orderby extensao
                        select new
                        {
                            Extensao = extensao,
                            NumeroArquivos = g.Count(),
                            TamanhoTotalArquivosKB = g.Sum(fi => fi.Length) / 1024M,
                            TamanhoMedioArquivosKB = g.Average(fi => fi.Length) / 1024D,
                            TamanhoMenorArquivosKB = g.Min(fi => fi.Length) / 1024M,
                            TamanhoMaiorArquivosKB = g.Max(fi => fi.Length) / 1024M
                        };

            GridView1.DataSource = query;
            GridView1.DataBind();

        }
    }
}