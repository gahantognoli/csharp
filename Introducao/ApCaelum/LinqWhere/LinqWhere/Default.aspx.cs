using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace LinqWhere
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            var query = from arquivo in Directory.GetFiles(@"c:\windows\system32")
                        let infoArquivo = new FileInfo(arquivo) //inferencia de tipos com let
                        let tamanhoArquivoMB = infoArquivo.Length / 1024 / 1024
                        where tamanhoArquivoMB > 1M && infoArquivo.Extension.ToUpper() == ".EXE"
                        orderby tamanhoArquivoMB descending
                        select new 
                        {
                            Nome = infoArquivo.Name,
                            Tamanho = tamanhoArquivoMB
                        };

            GridView1.DataSource = query;
            GridView1.DataBind();
        }
    }
}