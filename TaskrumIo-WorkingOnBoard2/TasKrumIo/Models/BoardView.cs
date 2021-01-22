using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasKrumIo.Models
{
    public class BoardView
    {
        [Key]
        public int Id { get; set; }
        public virtual Board Board { get; set; }
    }
}
