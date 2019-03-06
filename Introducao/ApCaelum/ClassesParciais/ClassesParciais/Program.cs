using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario(1, "Gabriel", "senha@123");
            if (usuario.Autenticar(usuario.Nome, usuario.Senha))
            {
                Console.WriteLine("Usuário Autenticado com sucesso!");
            }
            else
            {
                Console.WriteLine("Falha na Autenticação do usuário!");
            }

            Console.ReadKey();
        }
    }
}
