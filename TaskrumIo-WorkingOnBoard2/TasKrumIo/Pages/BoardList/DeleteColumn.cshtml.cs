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
    public class DeleteColumnModel : PageModel
    {


        private readonly TasKrumIo.Data.TasKrumIoContext _context;
        public DeleteColumnModel(TasKrumIo.Data.TasKrumIoContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Columns Columns { get; set; }
        public Board Board { get; set; }
        Cards Cards { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
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


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {

                try
                {
                    _context.Columns.Remove(Columns);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("BoardList");
                }
                catch
                {
                    return RedirectToPage("ErrorPageDeleteColumn");
                }
                
               

               
            }
            else
            {
                return Page();
            }

        }
    }
}
