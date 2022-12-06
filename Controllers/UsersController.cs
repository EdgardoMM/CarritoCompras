using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarritoCompras.DataAccess;
using CarritoCompras.Entities;

namespace CarritoCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CarritoDbContext _context;

        public UsersController(CarritoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("VIP")]
        public async Task<ActionResult> GetUsersVIP(int id, int dni)
        {
            var user = await _context.Users.FindAsync(id);

            if (user != null && user.DNI == dni)
            {
                if (user.Vip == true) return Ok("Usuario VIP");
                else return Ok("Usario Comun");
            }
  
            return NotFound("Cliente Inexistente");
        }
    }
}
