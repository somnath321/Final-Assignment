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
    public class LeaveConfigurationsController : ControllerBase
    {
        private readonly LeaveManagementContext _context;

        public LeaveConfigurationsController(LeaveManagementContext context)
        {
            _context = context;
        }

        // GET: api/LeaveConfigurations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaveConfiguration>>> GetLeaveConfiguration()
        {
            return await _context.LeaveConfiguration.ToListAsync();
        }

        // GET: api/LeaveConfigurations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveConfiguration>> GetLeaveConfiguration(string id)
        {
            var leaveConfiguration = await _context.LeaveConfiguration.FindAsync(id);

            if (leaveConfiguration == null)
            {
                return NotFound();
            }

            return leaveConfiguration;
        }

        // PUT: api/LeaveConfigurations/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLeaveConfiguration(string id, LeaveConfiguration leaveConfiguration)
        {
            if (id != leaveConfiguration.Leave_Name)
            {
                return BadRequest();
            }

            _context.Entry(leaveConfiguration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeaveConfigurationExists(id))
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

        // POST: api/LeaveConfigurations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<LeaveConfiguration>> PostLeaveConfiguration(LeaveConfiguration leaveConfiguration)
        {
            _context.LeaveConfiguration.Add(leaveConfiguration);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LeaveConfigurationExists(leaveConfiguration.Leave_Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLeaveConfiguration", new { id = leaveConfiguration.Leave_Name }, leaveConfiguration);
        }

        // DELETE: api/LeaveConfigurations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LeaveConfiguration>> DeleteLeaveConfiguration(string id)
        {
            var leaveConfiguration = await _context.LeaveConfiguration.FindAsync(id);
            if (leaveConfiguration == null)
            {
                return NotFound();
            }

            _context.LeaveConfiguration.Remove(leaveConfiguration);
            await _context.SaveChangesAsync();

            return leaveConfiguration;
        }

        private bool LeaveConfigurationExists(string id)
        {
            return _context.LeaveConfiguration.Any(e => e.Leave_Name == id);
        }
    }
}
