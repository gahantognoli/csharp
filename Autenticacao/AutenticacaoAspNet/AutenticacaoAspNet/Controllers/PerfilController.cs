﻿using AutenticacaoAspNet.Models;
using AutenticacaoAspNet.Utils;
using AutenticacaoAspNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace AutenticacaoAspNet.Controllers
{
    public class PerfilController : Controller
    {
        private UsuarioContext db = new UsuarioContext();
        // GET: Perfil
        [Authorize]
        public ActionResult AlterarSenha()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AlterarSenha(AlterarSenhaViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var identity = User.Identity as ClaimsIdentity;
            var login = identity.Claims.FirstOrDefault(c => c.Type == "Login").Value;

            var usuario = db.Usuarios.FirstOrDefault(u => u.Login == login);

            if (Hash.GerarHash(viewModel.SenhaAtual) != usuario.Senha)
            {
                ModelState.AddModelError("SenhaAtual", "Senha incorreta");
                return View();
            }

            usuario.Senha = Hash.GerarHash(viewModel.NovaSenha);
            db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            TempData["Message"] = "Senha alterada com sucesso";

            return RedirectToAction("Index", "Painel");
        }
    }
}