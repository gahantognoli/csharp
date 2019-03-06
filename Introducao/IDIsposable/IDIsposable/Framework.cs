using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDIsposable
{
    public class Conexao : IDisposable
    {
        //resource
        private string Handle;

        public Conexao()
        {
            Handle = "Recurso alocado.";
            Console.WriteLine("Recurso alocado.");
        }

        public void Conectar()
        {
            Console.WriteLine("Conectado");
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando...");
        }

        public void Dispose()
        {
            Handle = "";
            Console.WriteLine("Recurso liberado com sucesso!");
        }
    }
}
