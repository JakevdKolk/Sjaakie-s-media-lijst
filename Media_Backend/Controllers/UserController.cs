using AutoMapper;
using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Media_Backend.Repositories;
using backend.Models;

namespace Media_Backend.Controllers{

    [ApiController]
    [Route("api/user")]
    public class UserController : BaseController
    {

        private readonly IRepository<User> _userRepository;
        public UserController(ILogger<UserController> logger, IMapper mapper, MediaListDbContext dbcontext, IRepository<User> repository)
            : base(logger, mapper, dbcontext)
        {
            _userRepository = repository;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userRepository.All();
            var dtos = _mapper.Map<IEnumerable<User>>(users);
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {   var user = _userRepository.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            var dtos = _mapper.Map<User>(user);

            return Ok(dtos);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _userRepository.Insert(user);
            _userRepository.Save();
            var dto = _mapper.Map<User>(user);

            return CreatedAtAction(nameof(GetUserById), new { id = dto.Id }, dto);

        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User user)
        {
            if (user == null || user.Id != id)
            {
                return BadRequest();
            }
            var existingUser = _userRepository.GetById(id);
            if (existingUser == null)
            {
                return NotFound();
            }
            _userRepository.Update(user);
            _userRepository.Save();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _userRepository.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            _userRepository.Delete(id);
            _userRepository.Save();
            return NoContent();
        }

    }
}
