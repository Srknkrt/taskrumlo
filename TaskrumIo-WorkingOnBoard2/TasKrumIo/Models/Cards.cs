using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasKrumIo.Models
{
    public class Cards
    {
        [Key]
        public int Id { get; set; }
        public string CardName { get; set; }
        public CardContents CardContents { get; set; } 
    }
}
