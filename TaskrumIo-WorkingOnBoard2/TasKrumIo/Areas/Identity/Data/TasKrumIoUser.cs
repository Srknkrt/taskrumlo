using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TasKrumIo.Models;

namespace TasKrumIo.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the TasKrumIoUser class
    public class TasKrumIoUser : IdentityUser
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string UserNameID { get; internal set; }
        public int UserId { get; set; }
        public List<Board> Boards { get; set; } = new List<Board>();
    }
}
