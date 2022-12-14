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
    public class ArtistsController : ControllerBase
    {
        private readonly IGenericRepository<Artist> _repository;

        public ArtistsController(IGenericRepository<Artist> repository)
        {
            _repository = repository;
        }

        // GET: api/Artists
        [HttpGet]
        public  IQueryable<Artist> GetArtists()
        {
            return _repository.GetAll();
        }

        // GET: api/Artists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> GetArtist(int id)
        {
            var artist = await _repository.GetByID(id);

            if (artist == null)
            {
                return NotFound();
            }

            return artist;
        }

        // PUT: api/Artists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtist(int id, Artist artist)
        {
            if (id != artist.Id)
            {
                return BadRequest();
            }


            return (IActionResult)await _repository.Update(id, artist);

        }

        // POST: api/Artists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostArtist(Artist artist)
        {
            return (IActionResult)_repository.Create(artist);
        }

        // DELETE: api/Artists/5
        [HttpDelete("{id}")]
        public async Task<Artist> DeleteArtist(int id)
        {
            return await  _repository.Delete(id);
        }
    }
}
