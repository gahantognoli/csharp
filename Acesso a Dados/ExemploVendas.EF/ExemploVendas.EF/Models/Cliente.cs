using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExemploVendas.EF.Models
{
    [Table("Clientes")] //definindo nome da Tabela
    public class Cliente
    {
        [Key]
        //[Column("IdCliente")] defini nome da Coluna
        public int ClienteId { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Favor informar o nome do Cliente")]
        public string Nome { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "Favor informar o CPF")]
        public string CPF_CNPJ { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string CEP { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Status { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}