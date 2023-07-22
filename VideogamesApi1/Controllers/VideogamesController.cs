using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideogamesApi1.Models;

namespace VideogamesApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideogamesController : ControllerBase
    {
        private readonly VideogamesContext _context;

        public VideogamesController(VideogamesContext context)
        {
            _context = context;
        }

        // GET: api/Videogame
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Videogame>>> GetVideogame()
        {
            if (_context.Videogame == null)
            {
                return NotFound();
            }
            return await _context.Videogame.ToListAsync();
        }

        // GET: api/Videogame/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Videogame>> GetVideogame(long id)
        {
            if (_context.Videogame == null)
            {
                return NotFound();
            }
            var videojuego = await _context.Videogame.Where(videojuego => videojuego.Id == id).FirstAsync();

            if (videojuego == null)
            {
                return NotFound();
            }

            return videojuego;
        }

        // PUT: api/Videogame/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVideogame([FromForm] Videogame request)
        {
            _context.Videogame.Update(request);
            await _context.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "ok");
        }

        // POST: api/Videogame
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Videogame>> PostVideogame([FromForm] Videogame request)
        {
            await _context.Videogame.AddAsync(request);
            await _context.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "ok");
        }

        // DELETE: api/Videogame/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVideogame(int id)
        {
            var videogame = await _context.Videogame.FindAsync(id);

            if (videogame == null)
            {
                return NotFound();
            }
            _context.Videogame.Remove(videogame);
            await _context.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "ok");
        }

        private bool VideogameExists(long id)
        {
            return _context.Videogame.Any(e => e.Id == id);
        }

    }

}
