using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.Entities
{
    public class ProductInCart : BaseEntity
    {
        [ForeignKey("Cart")]
        public int CartID { get; set; }
        public Cart Carts { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Products { get; set; }
    }
}
