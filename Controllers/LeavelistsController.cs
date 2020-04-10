using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Data;
using LeaveManagement.Models;

namespace LeaveManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavelistsController : ControllerBase
    {
        private readonly LeaveManagementContext _context;

        public LeavelistsController(LeaveManagementContext context)
        {
            _context = context;
        }

        // GET: api/Leavelists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Leavelist>>> GetLeavelist()
        {
            return await _context.Leavelist.ToListAsync();
        }

        // GET: api/Leavelists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Leavelist>> GetLeavelist(string id)
        {
            var leavelist = await _context.Leavelist.FindAsync(id);

            if (leavelist == null)
            {
                return NotFound();
            }

            return leavelist;
        }

        // PUT: api/Leavelists/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLeavelist(string id, Leavelist leavelist)
        {
            if (id != leavelist.Name)
            {
                return BadRequest();
            }

            _context.Entry(leavelist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeavelistExists(id))
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

        // POST: api/Leavelists
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Leavelist>> PostLeavelist(Leavelist leavelist)
        {
            _context.Leavelist.Add(leavelist);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LeavelistExists(leavelist.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLeavelist", new { id = leavelist.Name }, leavelist);
        }

        // DELETE: api/Leavelists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Leavelist>> DeleteLeavelist(string id)
        {
            var leavelist = await _context.Leavelist.FindAsync(id);
            if (leavelist == null)
            {
                return NotFound();
            }

            _context.Leavelist.Remove(leavelist);
            await _context.SaveChangesAsync();

            return leavelist;
        }

        private bool LeavelistExists(string id)
        {
            return _context.Leavelist.Any(e => e.Name == id);
        }
    }
}
