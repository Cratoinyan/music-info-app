using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using music_info_app.DAL.Interface;
using music_info_app.DB;
using music_info_app.Model;

namespace music_info_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistsController : ControllerBase
    {
        private readonly IGenericRepository<Playlist> _repository;

        public PlaylistsController(IGenericRepository<Playlist> repository)
        {
            _repository = repository;
        }

        // GET: api/Playlists
        [HttpGet]
        public IQueryable<Playlist> GetPlaylists()
        {
            return _repository.GetAll();
        }

        // GET: api/Playlists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Playlist>> GetPlaylist(int id)
        {
            var playList = await _repository.GetByID(id);

            if (playList == null)
            {
                return NotFound();
            }

            return playList;
        }

        // PUT: api/Playlists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlaylist(int id, Playlist playlist)
        {
            if (id != playlist.Id)
            {
                return BadRequest();
            }


            return (IActionResult)await _repository.Update(id, playlist);
        }

        // POST: api/Playlists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostPlaylist(Playlist playlist)
        {
            return (IActionResult)_repository.Create(playlist);
        }

        // DELETE: api/Playlists/5
        [HttpDelete("{id}")]
        public async Task<Playlist> DeletePlaylist(int id)
        {
            return await _repository.Delete(id);
        }
    }
}
