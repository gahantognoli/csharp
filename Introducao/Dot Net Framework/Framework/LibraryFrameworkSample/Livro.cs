using System;

namespace LibraryFrameworkSample
{
    public class Livro
    {
        string titulo;
        string autor;
        int anoPublicacao;

        public string Titulo {
            get {
                return titulo;
            }
            set {
                titulo = value;
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }

        public int AnoPublicacao
        {
            get
            {
                return anoPublicacao;
            }
            set
            {
                anoPublicacao = value;
            }
        }

    }
}
