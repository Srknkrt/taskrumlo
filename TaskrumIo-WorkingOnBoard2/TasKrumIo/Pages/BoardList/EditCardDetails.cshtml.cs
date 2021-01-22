using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TasKrumIo.Data;
using TasKrumIo.Models;

namespace TasKrumIo.Pages.BoardList
{
    public class EditCardDetailsModel : PageModel
    {
        private readonly TasKrumIo.Data.TasKrumIoContext _context;

        public EditCardDetailsModel(TasKrumIo.Data.TasKrumIoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cards Cards { get; set; }

        [BindProperty]
        public CardContents CardContents { get; set; }

        [BindProperty]
        public IEnumerable<Columns> Columns { get; set; }
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cards).State = EntityState.Modified;
            _context.Attach(CardContents).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardsExists(Cards.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("BoardList");
        }

        private bool CardsExists(int id)
        {
            return _context.Cards.Any(e => e.Id == id);
        }
    }
}
