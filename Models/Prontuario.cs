using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorProntuarios.Models
{
    [PrimaryKey(nameof(AlunoId), nameof(CursoId))]
    public class Prontuario
    {   
        [ForeignKey("Aluno")]
        public Guid AlunoId { get; set; }

        [ForeignKey("Curso")]
        public int CursoId { get; set; }

        public string Descricao { get; set; }

        public virtual Aluno Aluno { get; set; }

        public virtual Curso Curso { get; set; }
    }
}