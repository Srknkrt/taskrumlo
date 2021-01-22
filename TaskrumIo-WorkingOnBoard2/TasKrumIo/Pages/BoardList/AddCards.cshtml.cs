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
    public class AddCardsModel : PageModel
    {
        private readonly TasKrumIo.Data.TasKrumIoContext _context;

        public AddCardsModel(TasKrumIo.Data.TasKrumIoContext context)
        {
            _context = context;
        }



        [BindProperty]
        public Cards Cards { get; set; }
        public Columns Columns { get; set; }
        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            Columns = await _context.Columns.FirstOrDefaultAsync(m => m.Id == id);

            if (Columns == null)
            {
                return NotFound();
            }
            return Page();

        }



        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            Columns = await _context.Columns.FirstOrDefaultAsync(m => m.Id == id);
            if(Columns == null)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                Columns.Cards.Add(Cards);
                await _context.Cards.AddAsync(Cards);
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
