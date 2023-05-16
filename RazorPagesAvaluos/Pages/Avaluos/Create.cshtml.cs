using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesAvaluos.Data;
using RazorPagesAvaluos.Models;

namespace RazorPagesAvaluos.Pages.Avaluos
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Avaluo Avaluo { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Avaluo == null || Avaluo == null)
            {
                return Page();
            }

            _context.Avaluo.Add(Avaluo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
