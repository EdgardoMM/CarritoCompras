using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompras.Core.Models.DTOs
{
    public class CartDto
    {
        [Required, MinLength(8, ErrorMessage = "El DNI debe tener 8 números.")]
        public int DNI { get; set; }

        public int Id { get; }


    }
}
