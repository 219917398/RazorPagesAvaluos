using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesAvaluos.Data;
using RazorPagesAvaluos.Models;

namespace RazorPagesAvaluos.Pages.Avaluos
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
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

            var avaluo =  await _context.Avaluo.FirstOrDefaultAsync(m => m.Id == id);
            if (avaluo == null)
            {
                return NotFound();
            }
            Avaluo = avaluo;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Avaluo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvaluoExists(Avaluo.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AvaluoExists(int id)
        {
          return (_context.Avaluo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
