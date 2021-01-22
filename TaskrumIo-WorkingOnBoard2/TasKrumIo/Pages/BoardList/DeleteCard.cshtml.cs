using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasKrumIo.Data;
using TasKrumIo.Models;

namespace TasKrumIo.Pages.BoardList
{
    public class DeleteCardModel : PageModel
    {
        private readonly TasKrumIo.Data.TasKrumIoContext _context;

        public DeleteCardModel(TasKrumIo.Data.TasKrumIoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cards Cards { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cards = await _context.Cards.FirstOrDefaultAsync(m => m.Id == id);

            if (Cards == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cards = await _context.Cards.FindAsync(id);

            if (Cards != null)
            {
                _context.Cards.Remove(Cards);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("BoardList");
        }
    }
}
