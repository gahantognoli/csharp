using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.FMigrations
{
    [Table("Produtos")]
    public class Produto
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nome { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
