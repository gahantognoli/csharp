using PaginacaoAspNetMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using X.PagedList;

namespace PaginacaoAspNetMvc.Controllers
{
    public class ProdutosController : Controller
    {
        LojaContext db = new LojaContext();

        public ActionResult Index(string busca = "", int pagina = 1)
        {
            var produtos = db.Produtos.Where(p => p.Nome.ToUpper().Contains(busca.ToUpper()))
                .OrderBy(p => p.Id)
                .ToPagedList(pagina, 10);

            ViewBag.Busca = busca;

            return View(produtos);
        }
    }
}