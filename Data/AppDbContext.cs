using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorProntuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorProntuarios.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Banco.sqlite");

            base.OnConfiguring(optionsBuilder);
        }
        
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Diploma> Diplomas { get; set; }

        public DbSet<Documento> Documentos { get; set; }

        public DbSet<DocumentoAluno> DocumentosAluno { get; set; }

        public DbSet<Prontuario> Prontuarios { get; set; }

        public DbSet<TipoDiploma> TipoDiploma { get; set; }
    }
}