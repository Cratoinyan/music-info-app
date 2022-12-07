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
    public class UsersController : ControllerBase
    {
        private readonly IGenericRepository<User> _repository;

        public UsersController(IGenericRepository<User> repository)
        {
            _repository = repository;
        }

        // GET: api/Users
        [HttpGet]
        public IQueryable<User> GetUsers()
        {
            return _repository.GetAll();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _repository.GetByID(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }


            return (IActionResult)await _repository.Update(id, user);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostUser(User user)
        {
            return (IActionResult)_repository.Create(song);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<User> DeleteUser(int id)
        {
            return await _repository.Delete(id);
        }
    }
}
