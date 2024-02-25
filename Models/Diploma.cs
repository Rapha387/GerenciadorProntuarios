using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorProntuarios.Models
{

    [PrimaryKey(nameof(Id), nameof(AlunoId), nameof(CursoId))]
    public class Diploma
    {
        
        public int Id { get; set; }
        
        [ForeignKey("Aluno")]
        public Guid AlunoId { get; set; }

        [ForeignKey("Curso")]
        public int CursoId { get; set; }
        
        public Guid CodigoDiploma { get; set; }
        public TipoDiploma TipoDiploma { get; set; }
        public bool SegundaVia { get; set; }
        public int CodigoLivro { get; set; }
        public int CodigoPagina { get; set; }
        public DateTime DataConclusao { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataRetirada { get; set; }   


        public virtual Aluno Aluno { get; set; }

        public virtual Curso Curso { get; set; }
    }
}