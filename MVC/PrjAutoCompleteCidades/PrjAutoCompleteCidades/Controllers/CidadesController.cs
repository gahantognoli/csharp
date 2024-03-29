﻿using PrjAutoCompleteCidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrjAutoCompleteCidades.Controllers
{
    public class CidadesController : Controller
    {
        // GET: Cidades
        public JsonResult ListarCidadesPorUF(string uf)
        {
            var db = new ClientesContext();
            var cidades = db.Cidades
                            .Where(c => c.UF == uf)
                            .Select(c => new { Id = c.Id, Nome = c.Nome });
            return Json(cidades, JsonRequestBehavior.AllowGet);
        }
    }
}