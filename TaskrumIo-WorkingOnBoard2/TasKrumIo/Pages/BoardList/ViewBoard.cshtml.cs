using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasKrumIo.Models;

namespace TasKrumIo.Pages.BoardList
{
    public class ViewBoardModel : PageModel
    {
        private readonly TasKrumIo.Data.TasKrumIoContext _context;
        public ViewBoardModel(TasKrumIo.Data.TasKrumIoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Board Board { get; set; }
        public IEnumerable<Columns> Columns { get; set; }
        public List<Cards> Cards { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Columns = await _context.Columns.ToListAsync();

            Cards = await _context.Cards.ToListAsync();

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

            _context.Attach(Columns).State = EntityState.Added;
            _context.Attach(Cards).State = EntityState.Added;
            await _context.SaveChangesAsync();
           

            return RedirectToPage("/BoardList/BoardList");
        }

      
    }
}
