using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorProntuarios.Models
{
    [PrimaryKey(nameof(AlunoId), nameof(DocumentoId))]
    public class DocumentoAluno
    {
        [ForeignKey("Aluno")]
        public Guid AlunoId { get; set; }
        [ForeignKey("Documento")]
        public int DocumentoId { get; set; }
        public bool Consta { get; set; }

        public virtual Aluno Aluno { get; set; }

        public virtual Documento Documento { get; set; }
    }
}