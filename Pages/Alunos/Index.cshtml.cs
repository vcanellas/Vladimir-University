using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VladimirUniversity.Data;
using VladimirUniversity.Models;

namespace VladimirUniversity.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        private readonly VladimirUniversity.Data.UniversidadeContext _context;

        public IndexModel(VladimirUniversity.Data.UniversidadeContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; }

        public async Task OnGetAsync()
        {
            Aluno = await _context.Aluno.ToListAsync();
        }
    }
}
