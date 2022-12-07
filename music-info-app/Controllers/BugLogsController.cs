using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using music_info_app.DAL;
using music_info_app.DB;
using music_info_app.Model;

namespace music_info_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugLogsController : ControllerBase
    {
        private readonly IGenericRepository<BugLog> _repository;

        public BugLogsController(IGenericRepository<BugLog> repository)
        {
            _repository = repository;
        }

        // GET: api/Albums
        [HttpGet]
        public IQueryable<BugLog> GetBugLogs()
        {
            return _repository.GetAll();
        }

        // GET: api/Albums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BugLog>> GetBugLog(int id)
        {
            var bugLog = await _repository.GetByID(id);

            if (bugLog == null)
            {
                return NotFound();
            }

            return bugLog;
        }

        // PUT: api/Albums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBugLog(int id, BugLog bugLog)
        {
            if (id != bugLog.Id)
            {
                return BadRequest();
            }


            return (IActionResult)await _repository.Update(id, bugLog);
        }

        // POST: api/Albums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostBugLog(BugLog bugLog)
        {
            return (IActionResult)_repository.Create(bugLog);
        }

        // DELETE: api/Albums/5
        [HttpDelete("{id}")]
        public async Task<Album> DeleteAlbum(int id)
        {
            return await _repository.Delete(id);
        }
    }
}
