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
    public class CardContentsDetailsModel : PageModel
    {
        private readonly TasKrumIo.Data.TasKrumIoContext _context;

        public CardContentsDetailsModel(TasKrumIo.Data.TasKrumIoContext context)
        {
            _context = context;
        }

        public Cards Cards { get; set; }
        public CardContents CardContents { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CardContents = await _context.CardContents.FirstOrDefaultAsync();
            Cards = await _context.Cards.FirstOrDefaultAsync(m => m.Id == id);

            if (Cards == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
