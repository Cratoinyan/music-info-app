using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using music_info_app.DAL.Interface;
using music_info_app.DB;
using music_info_app.Entities;

namespace music_info_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly IAlbumRepository _repository;

        public AlbumsController(IAlbumRepository repository)
        {
            _repository= repository;
        }

        // GET: api/Albums
        [HttpGet]
        public IQueryable<Album> GetAlbums()
        {
            return _repository.GetAll();
        }

        // GET: api/Albums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Album>> GetAlbum(int id)
        {
            var album = await _repository.GetByID(id);

            if (album == null)
            {
                return NotFound();
            }

            return album;
        }

        // PUT: api/Albums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlbum(int id, Album album)
        {
            if (id != album.Id)
            {
                return BadRequest();
            }


            return (IActionResult)await _repository.Update(id, album);
        }

        // POST: api/Albums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Album> PostAlbum(Album album)
        {
            return await _repository.Create(album);
        }

        // DELETE: api/Albums/5
        [HttpDelete("{id}")]
        public async Task<Album> DeleteAlbum(int id)
        {
            return await _repository.Delete(id);
        }
    }
}
