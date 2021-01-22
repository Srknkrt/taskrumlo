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
    public class AddColumnModel : PageModel
    {


        

        private readonly TasKrumIo.Data.TasKrumIoContext _context;
        public AddColumnModel(TasKrumIo.Data.TasKrumIoContext context)
        {
            _context = context;
        }
        public int Id { get; set; }
        [BindProperty]
        public Columns Columns { get; set; }
        public Board Board { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();

            }
            Board = await _context.Board.FirstOrDefaultAsync(m => m.Id == id);

            if(Board == null)
            {
                return NotFound();
            }
            return Page();

        }


       
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            Board = await _context.Board.FirstOrDefaultAsync(m => m.Id == id);
            if(Board == null)
            {
                return NotFound();

            }

            else if (ModelState.IsValid)
            {
                Board.Columns.Add(Columns);
                await _context.Columns.AddAsync(Columns);
                await _context.SaveChangesAsync();
                return RedirectToPage("BoardList");
            }
            else
            {
                return Page();
            }

        }
    }
}
