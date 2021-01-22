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
    public class EditBoardModel : PageModel
    {
        private readonly TasKrumIo.Data.TasKrumIoContext _context;

        public EditBoardModel(TasKrumIo.Data.TasKrumIoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Board Board { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Board = await _context.Board.FirstOrDefaultAsync(m => m.Id == id);

            if (Board == null)
            {
                return NotFound();
            }
            return Page();
        }

        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Board).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoardExists(Board.Id))
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

        private bool BoardExists(int id)
        {
            return _context.Board.Any(e => e.Id == id);
        }
    }
}
