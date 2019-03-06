using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            /*var query = from arquivo in Directory.GetFiles(@"C:\windows\system32")
                        select arquivo;*/

            var query = from arquivo in Directory.GetFiles(@"C:\windows\system32")
                        select new //tipo anônimo
                        {
                            NomeArquivo = Path.GetFileName(arquivo),
                            Extensao = Path.GetExtension(arquivo)
                        };

            GridView1.DataSource = query;
            GridView1.DataBind();
        }
    }
}