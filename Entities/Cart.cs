using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.Entities
{
    public class Cart : BaseEntity
    {
        public string Type { get; set; } 
        public string Item { get; set; }
        public bool Promo { get; set; } // false no promo, true sí promo
        public double Total { get; set; }
        public double Discount { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User Users { get; set; }
    }
}
