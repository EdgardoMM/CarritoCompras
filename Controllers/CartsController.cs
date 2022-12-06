using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarritoCompras.DataAccess;
using CarritoCompras.Entities;
using CarritoCompras.Core.Models.DTOs;
using CarritoCompras.Core.Interfaces;

namespace CarritoCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly CarritoDbContext _context;
        private readonly ICartsBusiness _cartBusiness;

        public CartsController(CarritoDbContext context, ICartsBusiness cartBusiness)
        {
            _context = context;
            _cartBusiness = cartBusiness;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart>>> GetCarts()
        {
            return await _context.Carts.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cart>> GetCart(int id)
        {
            var cart = await _context.Carts.FindAsync(id);

            if (cart == null)
            {
                return NotFound();
            }

            return cart;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCart(int id, Cart cart)
        {
            if (id != cart.Id)
            {
                return BadRequest();
            }

            _context.Entry(cart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CartDto request) => Ok(await _cartBusiness.Insert(request));

        //public async Task<ActionResult> NewCart(CartDto request){           if (!await _cartBusiness.Insert(request))
        //        return NotFound();

        //    return Ok("Categoria Añadida Correctamente, DNI: "+ request.DNI);
        //    //_context.Carts.Add(request);
        //    //await _context.SaveChangesAsync();

        //    //return CreatedAtAction("Carrito Creado ID", new { id = cart.Id }, cart);
        //}

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound("Carrito Inexistente");
            }

            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();

            return Ok("Carrito Eliminado Exitosamente");
        }

        private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.Id == id);
        }
    }
}
