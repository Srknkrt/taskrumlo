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
    public class DeleteBoardModel : PageModel
    {
        private readonly TasKrumIo.Data.TasKrumIoContext _context;

        public DeleteBoardModel(TasKrumIo.Data.TasKrumIoContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Board = await _context.Board.FindAsync(id);

            if (Board != null)
            {
                try
                {
                    _context.Board.Remove(Board);
                    await _context.SaveChangesAsync();
                }
                catch
                {
                    return RedirectToPage("ErrorPageDeleteBoard");
                }
               
            }

            return RedirectToPage("BoardList");
        }
    }
}
