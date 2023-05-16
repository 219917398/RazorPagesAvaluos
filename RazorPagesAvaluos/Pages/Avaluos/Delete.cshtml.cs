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
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Avaluo Avaluo { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Avaluo == null)
            {
                return NotFound();
            }

            var avaluo = await _context.Avaluo.FirstOrDefaultAsync(m => m.Id == id);

            if (avaluo == null)
            {
                return NotFound();
            }
            else 
            {
                Avaluo = avaluo;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Avaluo == null)
            {
                return NotFound();
            }
            var avaluo = await _context.Avaluo.FindAsync(id);

            if (avaluo != null)
            {
                Avaluo = avaluo;
                _context.Avaluo.Remove(Avaluo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
