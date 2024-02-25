using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GerenciadorProntuarios.Models;
using GerenciadorProntuarios.Data;
using GerenciadorProntuarios.ViewModels;

namespace MyApp.Namespace
{
    public class AlunoModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Aluno Aluno { get; set; } = new();

        //public List<Documento> Documentos { get; set; } = new();

        public List<DocumentosAlunoViewModel> DocumentosAluno { get; set; } = new();

        public AlunoModel(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(Guid id)
        {
            Aluno = _context.Alunos.FirstOrDefault(x => x.Id == id);

            DocumentosAluno = (from documentoAluno in _context.DocumentosAluno
                              join documento in _context.Documentos on documentoAluno.DocumentoId equals documento.Id
                              join aluno in _context.Alunos on documentoAluno.AlunoId equals aluno.Id
                               where aluno.Id == id
                              select new DocumentosAlunoViewModel(documento.Nome, documentoAluno.Consta)
                              ).ToList();

            return Page();
        }

        public IActionResult OnPost(string nomeAluno, string rgAluno, string cpfAluno)
        {
           Aluno.Nome = nomeAluno;
           Aluno.RG = rgAluno;
           Aluno.CPF = cpfAluno;

           _context.Update(Aluno);
           _context.SaveChanges();

           return RedirectToPage();
        }

        public IActionResult AtualizarDocumentos()
        {
            return RedirectToPage();
        }
    }
}
