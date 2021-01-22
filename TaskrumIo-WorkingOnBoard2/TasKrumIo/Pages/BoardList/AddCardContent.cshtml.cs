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
    public class AddCardContentModel : PageModel
    {
        private readonly TasKrumIo.Data.TasKrumIoContext _context;

        public AddCardContentModel(TasKrumIo.Data.TasKrumIoContext context)
        {
            _context = context;
        }
        [BindProperty]
        public CardContents CardContents { get; set; }
        [BindProperty]
        public Cards Cards { get; set; }

        public async Task<IActionResult> OnGet(int? id)
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
            Cards = await _context.Cards.FirstOrDefaultAsync(m => m.Id == id);
            if(Cards == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
               
                _context.CardContents.Add(CardContents);
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
