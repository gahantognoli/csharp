using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.F.Mapeamento1ParaN
{
    [Table("Produtos")]
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        /*
         * Para definir a obrigatoriedade no relacionamento e fazer com que todo produto esteja 
         * vinculado a uma marca é preciso explicitar a chave estrangeira por meio de uma propriedade 
         * na classe Produto
         */
        //Por convenção podemos declarar a chave estrangeira explicitamente, tornado ela obrigatória.
        //Para isso precisamos declarar a seguinte nomenclatura: "Nome da Classe" + "Chave primária da classe"
        public int MarcaId { get; set; }

        //Definindo o relacionamento de Produto com uma Marca.
        //Um produto possui uma Marca.
        //É necessário do virtual para o Entity preencher essa Entidade em tempo de execução.
        public virtual Marca Marca { get; set; }
    }
}
