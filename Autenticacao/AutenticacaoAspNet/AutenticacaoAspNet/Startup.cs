using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using System.Web.Helpers;

[assembly: OwinStartup(typeof(AutenticacaoAspNet.Startup))]

namespace AutenticacaoAspNet
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Configuração de iniciação do OWIN.
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = "ApplicationCookie", //Autenticação por Cookie
                //Se o usuário não estiver logado, redireciona para página de Login
                LoginPath = new PathString("/Autenticacao/Login") 
            });

            AntiForgeryConfig.UniqueClaimTypeIdentifier = "Login";
        }
    }
}
