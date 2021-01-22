using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasKrumIo.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }
        public string BoardName { get; set; }
        public List<Columns> Columns { get; set; } = new List<Columns>();


    }
}
