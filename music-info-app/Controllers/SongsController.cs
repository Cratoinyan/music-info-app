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
    public class SongsController : ControllerBase
    {
        private readonly IGenericRepository<Song> _repository;

        public SongsController(IGenericRepository<Song> repository)
        {
            _repository = repository;
        }

        // GET: api/Songs
        [HttpGet]
        public IQueryable<Song> GetSongs()
        {
            return _repository.GetAll();
        }

        // GET: api/Songs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Song>> GetSong(int id)
        {
            var song = await _repository.GetByID(id);

            if (song == null)
            {
                return NotFound();
            }

            return song;
        }

        // PUT: api/Songs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSong(int id, Song song)
        {
            if (id != song.Id)
            {
                return BadRequest();
            }


            return (IActionResult)await _repository.Update(id, song);
        }

        // POST: api/Songs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostSong(Song song)
        {
            return (IActionResult)_repository.Create(song);
        }

        // DELETE: api/Songs/5
        [HttpDelete("{id}")]
        public async Task<Song> DeleteSong(int id)
        {
            return await _repository.Delete(id);
        }
    }
}
