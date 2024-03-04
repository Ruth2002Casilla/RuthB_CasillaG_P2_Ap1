using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;
using SegundoParcial.Server.DAL;

namespace SegundoParcial.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoDetalleController : ControllerBase
    {
        private readonly Context _context;

        public VehiculoDetalleController(Context context)
        {
            _context = context;
        }

        // GET: api/VehiculoDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehiculoDetalle>>> GetVehiculosDetalle()
        {
            return await _context.VehiculosDetalle.ToListAsync();
        }

        // GET: api/VehiculoDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehiculoDetalle>> GetVehiculoDetalle(int id)
        {
            var vehiculoDetalle = await _context.VehiculosDetalle.FindAsync(id);

            if (vehiculoDetalle == null)
            {
                return NotFound();
            }

            return vehiculoDetalle;
        }

        // PUT: api/VehiculoDetalle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculoDetalle(int id, VehiculoDetalle vehiculoDetalle)
        {
            if (id != vehiculoDetalle.VehiculoDetalleId)
            {
                return BadRequest();
            }

            _context.Entry(vehiculoDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculoDetalleExists(id))
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

        // POST: api/VehiculoDetalle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehiculoDetalle>> PostVehiculoDetalle(VehiculoDetalle vehiculoDetalle)
        {
            _context.VehiculosDetalle.Add(vehiculoDetalle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehiculoDetalle", new { id = vehiculoDetalle.VehiculoDetalleId }, vehiculoDetalle);
        }

        // DELETE: api/VehiculoDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehiculoDetalle(int id)
        {
            var vehiculoDetalle = await _context.VehiculosDetalle.FindAsync(id);
            if (vehiculoDetalle == null)
            {
                return NotFound();
            }

            _context.VehiculosDetalle.Remove(vehiculoDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VehiculoDetalleExists(int id)
        {
            return _context.VehiculosDetalle.Any(e => e.VehiculoDetalleId == id);
        }
    }
}
