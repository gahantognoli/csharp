using System.Web;
using System.Web.Mvc;

namespace Prj.CadastroSocial.Devmidia
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
