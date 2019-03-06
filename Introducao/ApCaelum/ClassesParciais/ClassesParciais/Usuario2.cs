using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParciais
{
    public partial class Usuario
    {
        public bool Autenticar(string usuario, string senha)
        {
            return ((usuario == "Gabriel") && (senha == "senha@123"));
        }
    }
}
