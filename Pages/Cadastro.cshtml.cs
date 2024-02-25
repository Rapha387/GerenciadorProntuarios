using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GerenciadorProntuarios.Data;
using GerenciadorProntuarios.Models;

namespace MyApp.Namespace
{
    public class CadastroModel : PageModel
    {
        private readonly AppDbContext _context;


        public CadastroModel(AppDbContext context) 
        {
            _context = context;
        }

        [BindProperty]
        public Aluno Aluno { get; set; } = default!;

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _context.Alunos.Add(Aluno);
            _context.SaveChanges();
        }
    }
}
