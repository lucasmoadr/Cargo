using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    [Table("Ship")]
    public class Ship
    {
        [Key]
       public int IdShip { get; set; }
        [Required]
        public string NameShip { get; set; }
        public DateTime YearOfCreation { get; set; }
    }
}
