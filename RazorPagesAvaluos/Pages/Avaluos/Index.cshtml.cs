using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesAvaluos.Data;
using RazorPagesAvaluos.Models;

namespace RazorPagesAvaluos.Pages.Avaluos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Avaluo> Avaluo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Avaluo != null)
            {
                Avaluo = await _context.Avaluo.ToListAsync();
            }
        }
    }
}
