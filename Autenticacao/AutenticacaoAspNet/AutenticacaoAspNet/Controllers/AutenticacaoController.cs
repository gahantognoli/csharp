using AutenticacaoAspNet.Models;
using AutenticacaoAspNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutenticacaoAspNet.Utils;
using System.Security.Claims;

namespace AutenticacaoAspNet.Controllers
{
    public class AutenticacaoController : Controller
    {
        private UsuarioContext db = new UsuarioContext();

        // GET: Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CadastroUsuarioViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            if (db.Usuarios.Count(u => u.Login == viewModel.Login) > 0)
            {
                ModelState.AddModelError("Login", "Esse Login já está em uso.");
                return View(viewModel);
            }

            Usuario usuario = new Usuario()
            {
                Nome = viewModel.Nome,
                Login = viewModel.Login,
                Senha = Hash.GerarHash(viewModel.Senha)
            };

            db.Usuarios.Add(usuario);
            db.SaveChanges();

            TempData["Message"] = "Cadastro realizado com sucesso. Efetue login.";
            return RedirectToAction("Login");
        }

        public ActionResult Login(string ReturnUrl)
        {
            var viewModel = new LoginViewModel()
            {
                UrlRetorno = ReturnUrl
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var usuario = db.Usuarios.FirstOrDefault(u => u.Login == viewModel.Login);
            if (usuario == null)
            {
                ModelState.AddModelError("Login", "Login incorreto");
                return View(viewModel);
            }

            if (usuario.Senha != Hash.GerarHash(viewModel.Senha))
            {
                ModelState.AddModelError("Senha", "Senha incorreta");
                return View(viewModel);
            }

            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, usuario.Nome),
                new Claim("Login", usuario.Login)
            }, "ApplicationCookie");

            Request.GetOwinContext().Authentication.SignIn(identity);

            if (!String.IsNullOrWhiteSpace(viewModel.UrlRetorno) || Url.IsLocalUrl(viewModel.UrlRetorno))
            {
                return Redirect(viewModel.UrlRetorno);
            }
            else
            {
                return RedirectToAction("Index", "Painel");
            }
        }

        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }
    }
}