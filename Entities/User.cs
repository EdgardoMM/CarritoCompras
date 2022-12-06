using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(8)]
        public int DNI { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string Address { get; set; }  
        public int Phone { get; set; }
        public bool Vip { get; set; } //false = no vip, true = vip
    }
}
