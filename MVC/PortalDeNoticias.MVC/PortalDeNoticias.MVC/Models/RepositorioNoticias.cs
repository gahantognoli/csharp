using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.MVC.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                {
                    CriarNoticias();
                }
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia()
            {
                Id = 1,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "João Carlos",
                Data = DateTime.Now.AddDays(-10),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nisl purus in mollis nunc sed id semper. Tristique magna sit amet purus gravida quis blandit turpis. Lectus sit amet est placerat in egestas. Ornare aenean euismod elementum nisi quis. Dis parturient montes nascetur ridiculus mus mauris vitae ultricies. Nibh mauris cursus mattis molestie a iaculis. Neque laoreet suspendisse interdum consectetur. Arcu non odio euismod lacinia at quis risus. Facilisis gravida neque convallis a cras. Vitae congue eu consequat ac felis donec et. Aliquam ultrices sagittis orci a scelerisque purus semper eget duis. Ornare lectus sit amet est placerat in."
            });

            noticias.Add(new Noticia()
            {
                Id = 2,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Gabriel Antognoli",
                Data = DateTime.Now.AddDays(-17),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Justo laoreet sit amet cursus sit amet dictum sit amet. Nullam ac tortor vitae purus. Egestas erat imperdiet sed euismod nisi porta lorem. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Metus dictum at tempor commodo. Volutpat lacus laoreet non curabitur gravida arcu. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit lectus. Pharetra vel turpis nunc eget lorem dolor. Id nibh tortor id aliquet lectus proin nibh nisl. Purus viverra accumsan in nisl. Lectus vestibulum mattis ullamcorper velit sed. Nisl suscipit adipiscing bibendum est ultricies integer quis auctor. Suscipit adipiscing bibendum est ultricies integer quis auctor elit. Sapien faucibus et molestie ac. Nam libero justo laoreet sit amet cursus sit amet. Et tortor at risus viverra adipiscing at in. Vel quam elementum pulvinar etiam non quam lacus suspendisse. Curabitur gravida arcu ac tortor dignissim convallis aenean et tortor."
            });

            noticias.Add(new Noticia()
            {
                Id = 3,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Luiz Carlos",
                Data = DateTime.Now.AddDays(-12),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Pellentesque elit ullamcorper dignissim cras tincidunt lobortis. Consectetur libero id faucibus nisl tincidunt eget nullam non. Purus non enim praesent elementum facilisis leo vel. Leo integer malesuada nunc vel risus commodo viverra maecenas. Sit amet porttitor eget dolor morbi. Ultricies integer quis auctor elit sed vulputate mi sit. Hac habitasse platea dictumst vestibulum rhoncus est pellentesque elit. Scelerisque felis imperdiet proin fermentum leo vel orci porta. Neque aliquam vestibulum morbi blandit. Nisl tincidunt eget nullam non nisi est sit amet. Bibendum est ultricies integer quis auctor elit. Purus ut faucibus pulvinar elementum. Amet venenatis urna cursus eget. Interdum consectetur libero id faucibus nisl tincidunt eget nullam non. Felis eget nunc lobortis mattis aliquam faucibus purus in."
            });

            noticias.Add(new Noticia()
            {
                Id = 4,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Elziabete Almeida",
                Data = DateTime.Now.AddDays(-7),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Pellentesque elit ullamcorper dignissim cras tincidunt lobortis. Consectetur libero id faucibus nisl tincidunt eget nullam non. Purus non enim praesent elementum facilisis leo vel. Leo integer malesuada nunc vel risus commodo viverra maecenas. Sit amet porttitor eget dolor morbi. Ultricies integer quis auctor elit sed vulputate mi sit. Hac habitasse platea dictumst vestibulum rhoncus est pellentesque elit. Scelerisque felis imperdiet proin fermentum leo vel orci porta. Neque aliquam vestibulum morbi blandit. Nisl tincidunt eget nullam non nisi est sit amet. Bibendum est ultricies integer quis auctor elit. Purus ut faucibus pulvinar elementum. Amet venenatis urna cursus eget. Interdum consectetur libero id faucibus nisl tincidunt eget nullam non. Felis eget nunc lobortis mattis aliquam faucibus purus in."
            });

            noticias.Add(new Noticia()
            {
                Id = 5,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Luiz Carlos",
                Data = DateTime.Now.AddDays(-8),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Laoreet sit amet cursus sit amet dictum. Posuere urna nec tincidunt praesent semper. Faucibus et molestie ac feugiat sed lectus vestibulum. Congue quisque egestas diam in. Neque laoreet suspendisse interdum consectetur libero id. In metus vulputate eu scelerisque felis. Eros in cursus turpis massa tincidunt. Tincidunt praesent semper feugiat nibh sed pulvinar proin gravida. Massa id neque aliquam vestibulum. Tellus integer feugiat scelerisque varius morbi."
            });
        }
    }
}