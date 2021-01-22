using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TasKrumIo.Data;
using TasKrumIo.Models;

namespace TasKrumIo.Pages.BoardList
{
    public class CreateNewBoardModel : PageModel
    {
        private readonly TasKrumIo.Data.TasKrumIoContext _context;

        public CreateNewBoardModel(TasKrumIo.Data.TasKrumIoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Board Board { get; set; }

       
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Board.Add(Board);
            await _context.SaveChangesAsync();

            return RedirectToPage("BoardList");

        }
    }
}
