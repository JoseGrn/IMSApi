using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IMSApi.Models;

namespace IMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessLevelsController : ControllerBase
    {
        private readonly ImsdbContext _context;

        public AccessLevelsController(ImsdbContext context)
        {
            _context = context;
        }

        // GET: api/AccessLevels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccessLevel>>> GetAccessLevels()
        {
          if (_context.AccessLevels == null)
          {
              return NotFound();
          }
            return await _context.AccessLevels.ToListAsync();
        }

        // GET: api/AccessLevels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccessLevel>> GetAccessLevel(int id)
        {
          if (_context.AccessLevels == null)
          {
              return NotFound();
          }
            var accessLevel = await _context.AccessLevels.FindAsync(id);

            if (accessLevel == null)
            {
                return NotFound();
            }

            return accessLevel;
        }

        // PUT: api/AccessLevels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccessLevel(int id, AccessLevel accessLevel)
        {
            if (id != accessLevel.AccessLevelId)
            {
                return BadRequest();
            }

            _context.Entry(accessLevel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccessLevelExists(id))
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

        // POST: api/AccessLevels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AccessLevel>> PostAccessLevel(AccessLevel accessLevel)
        {
          if (_context.AccessLevels == null)
          {
              return Problem("Entity set 'ImsdbContext.AccessLevels'  is null.");
          }
            _context.AccessLevels.Add(accessLevel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccessLevel", new { id = accessLevel.AccessLevelId }, accessLevel);
        }

        // DELETE: api/AccessLevels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccessLevel(int id)
        {
            if (_context.AccessLevels == null)
            {
                return NotFound();
            }
            var accessLevel = await _context.AccessLevels.FindAsync(id);
            if (accessLevel == null)
            {
                return NotFound();
            }

            _context.AccessLevels.Remove(accessLevel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccessLevelExists(int id)
        {
            return (_context.AccessLevels?.Any(e => e.AccessLevelId == id)).GetValueOrDefault();
        }
    }
}
