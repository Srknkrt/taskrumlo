using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasKrumIo.Areas.Identity.Data;
using TasKrumIo.Data;
using TasKrumIo.Models;


namespace TasKrumIo.Pages.BoardList
{
  

        public class BoardListModel : PageModel
        {

            private readonly TasKrumIo.Data.TasKrumIoContext _context;

            public BoardListModel(TasKrumIo.Data.TasKrumIoContext context)
            {
                _context = context;
            }

            public IList<Board> Board { get; set; }
            

            public async Task OnGetAsync()
            {
                
            
              Board = await _context.Board.ToListAsync();
           
        }

        }
    }
