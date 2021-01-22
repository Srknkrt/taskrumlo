using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasKrumIo.Models
{
    public class Columns
    {
        [Key]
        public int Id { get; set; }
        public string ColumnName { get; set; }
        public virtual BoardView BoardView { get; set; }
        public List<Cards> Cards { get; set; } = new List<Cards>();

    }
}
