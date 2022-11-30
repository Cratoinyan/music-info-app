using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using music_info_app.DB;
using music_info_app.Model;

namespace music_info_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugLogsController : ControllerBase
    {
        private readonly SongContext _context;

        public BugLogsController(SongContext context)
        {
            _context = context;
        }

        // GET: api/BugLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BugLog>>> GetBugLog()
        {
            return await _context.BugLog.ToListAsync();
        }

        // GET: api/BugLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BugLog>> GetBugLog(int id)
        {
            var bugLog = await _context.BugLog.FindAsync(id);

            if (bugLog == null)
            {
                return NotFound();
            }

            return bugLog;
        }

        // PUT: api/BugLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBugLog(int id, BugLog bugLog)
        {
            if (id != bugLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(bugLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BugLogExists(id))
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

        // POST: api/BugLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BugLog>> PostBugLog(BugLog bugLog)
        {
            _context.BugLog.Add(bugLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBugLog", new { id = bugLog.Id }, bugLog);
        }

        // DELETE: api/BugLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBugLog(int id)
        {
            var bugLog = await _context.BugLog.FindAsync(id);
            if (bugLog == null)
            {
                return NotFound();
            }

            _context.BugLog.Remove(bugLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BugLogExists(int id)
        {
            return _context.BugLog.Any(e => e.Id == id);
        }
    }
}
