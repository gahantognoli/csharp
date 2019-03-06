using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ExemploLinq2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            var query = from arquivo in Directory.GetFiles(@"c:\windows\system32")
                        let nomeArquivo = Path.GetFileName(arquivo)
                        let extensao = Path.GetExtension(arquivo).ToUpper()
                        orderby extensao, nomeArquivo descending
                        select new
                        {
                            Arquivo = nomeArquivo,
                            Extensao = extensao
                        };
            GridView1.DataSource = query;
            GridView1.DataBind();
        }
    }
}