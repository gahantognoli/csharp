using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
}

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    [WebMethod]
    public int Somar(int x, int y)
    {
        return x + y;
    }

    [WebMethod]
   public List<Cliente> getClientes()
    {
        List<Cliente> list = new List<Cliente>();
        list.Add(new Cliente() { Id = 1, Nome = "Gabriel" });
        list.Add(new Cliente() { Id = 2, Nome = "Web Service" });
        list.Add(new Cliente() { Id = 3, Nome = "Teste" });
        return list;
    }

}
