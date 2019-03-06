using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    
    public class Aluno
    {
        private int matricula;
        private string nome;
        private double mensalidade;
        private TipoAluno tipoAluno;

        //forma 1 de propriedade
        public int Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                if (value < 0)
                {
                    throw new MensalidadeNagativaException("Valor da matricula não pode ser negativo!");
                }
                else
                {
                    matricula = value;
                }
                
            }
        }

        //forma 2 de propriedade
        public string Nome { get => nome; set => nome = value; }
        public double Mensalidade { get => mensalidade; set => mensalidade = value; }
        public TipoAluno TipoAluno { get => tipoAluno; set => tipoAluno = value; }

        
    }
}
