using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Prj.CadastroSocial.Devmidia.Models
{
    public class Pessoa
    {
        [Key]
        [Required(ErrorMessage = "Preencha o CPF.")]
        [Remote("ValidarCPF", "Pessoas", ErrorMessage = "Esse CPF ja foi cadastrado.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha o nome completo.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter ate {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha a data de nascimento.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o sexo.")]
        public Sexo Sexo { get; set; }

        [Required(ErrorMessage = "Selecione um estado civil.")]
        [Display(Name = "Estado Civil")]
        public EstadoCivil EstadoCivil { get; set; }

        [Required(ErrorMessage = "Preencha o estado de residencia.")]
        [RegularExpression("(AC|AL|AP|AM|BA|CE|DF|ES|GO|MA|MT|MS|MG|PA|PB|PR|PE|PI|RJ|RN|RS|RO|RR|SC|SP|SE|TO)", ErrorMessage = "Informe um estado valido.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Preencha a cidade de residencia.")]
        [MaxLength(50, ErrorMessage = "O nome da cidade deve ter ate 50 caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o endereco residencial.")]
        [MaxLength(100, ErrorMessage = "O endereco residencial deve ter ate {1} caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o numero do endereco residencial.")]
        [MaxLength(10, ErrorMessage = "O numero do endereco deve ter ate {1} caracteres")]
        [Display(Name = "Numero")]
        public string NumeroEndereco { get; set; }

        [MaxLength(50, ErrorMessage = "O complemento do endereco deve ter ate {1} caracteres")]
        [Display(Name = "Complemento")]
        public string ComplementoEndereco { get; set; }

        [Required(ErrorMessage = "Preencha a renda mensal.")]
        [Display(Name = "Renda Mensal")]
        public decimal Renda { get; set; }
    }
}