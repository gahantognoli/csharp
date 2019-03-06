using System.ComponentModel.DataAnnotations;

namespace Prj.CadastroSocial.Devmidia.Models
{
    public enum EstadoCivil
    {
        [Display(Name = "Solteiro(a)")]
        Solteiro,
        [Display(Name = "Casado(a)")]
        Casado,
        [Display(Name = "Divorciado(a)")]
        Divorciado,
        [Display(Name = "Viuvo(a)")]
        Viuvo,
        [Display(Name = "Separado(a)")]
        Separado
    }
}