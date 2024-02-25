using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GerenciadorProntuarios.Models;
using GerenciadorProntuarios.Data;

namespace GerenciadorProntuarios.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
    
    public IndexModel(AppDbContext context) 
    {
        _context = context;
    }
    public List<Aluno> Alunos { get; set; } = new();

    public string Nome {get; set;}

    public void OnGet(string nomeAluno)
    {
        Alunos = _context.Alunos.ToList();

        if(!string.IsNullOrEmpty(nomeAluno))
            Alunos = _context.Alunos.Where(aluno => aluno.Nome.ToLower().Contains(nomeAluno)).ToList();
    }
}
