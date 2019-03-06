using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{

    public enum TipoAluno
    {
        Regular, Especial
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Aluno aluno = new Aluno();
                aluno.Matricula = -100;
            }
            catch (MensalidadeNagativaException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
