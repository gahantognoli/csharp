﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace CrudMVC.EntityFramework.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Required]
        public string Telefone { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Nascimento { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}