using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TraininggSystem.Data;
using TraininggSystem.Models;

namespace TraininggSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrolmentController : ControllerBase
    {
        private readonly TraininggSystemContext _context;

        public EnrolmentController(TraininggSystemContext context)
        {
            _context = context;
        }

        // GET: api/Enrolment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Enrolment>>> GetEnrolment()
        {
          if (_context.Enrolment == null)
          {
              return NotFound();
          }
            return await _context.Enrolment.ToListAsync();
        }

        // GET: api/Enrolment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Enrolment>> GetEnrolment(int id)
        {
          if (_context.Enrolment == null)
          {
              return NotFound();
          }
            var enrolment = await _context.Enrolment.FindAsync(id);

            if (enrolment == null)
            {
                return NotFound();
            }

            return enrolment;
        }

        // PUT: api/Enrolment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnrolment(int id, Enrolment enrolment)
        {
            if (id != enrolment.EnrolmentId)
            {
                return BadRequest();
            }

            _context.Entry(enrolment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnrolmentExists(id))
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

        // POST: api/Enrolment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Enrolment>> PostEnrolment(Enrolment enrolment)
        {
          if (_context.Enrolment == null)
          {
              return Problem("Entity set 'TraininggSystemContext.Enrolment'  is null.");
          }
            _context.Enrolment.Add(enrolment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEnrolment", new { id = enrolment.EnrolmentId }, enrolment);
        }

        // DELETE: api/Enrolment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnrolment(int id)
        {
            if (_context.Enrolment == null)
            {
                return NotFound();
            }
            var enrolment = await _context.Enrolment.FindAsync(id);
            if (enrolment == null)
            {
                return NotFound();
            }

            _context.Enrolment.Remove(enrolment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EnrolmentExists(int id)
        {
            return (_context.Enrolment?.Any(e => e.EnrolmentId == id)).GetValueOrDefault();
        }
    }
}
