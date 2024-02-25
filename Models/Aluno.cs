using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorProntuarios.Models
{
    public class Aluno
    {
        public Guid Id  {get; set; }

        [Required(ErrorMessage = "Informe o Nome do Aluno")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o RG do Aluno")]
        [StringLength(9,MinimumLength=9, ErrorMessage="O RG deve ter 9 caracteres.")]
        public string RG { get; set; }

        [Required(ErrorMessage = "Informe o CPF do Aluno")]
        [StringLength(11,MinimumLength=11, ErrorMessage="O CPF deve ter 11 caracteres.")]
        public string CPF { get; set; }
    }
}