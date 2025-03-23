using Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProjectApi.Entities.DTOs;
using ProjectApi.Entities.Models;

namespace ProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersUnitofworkController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersUnitofworkController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // *********** GET: api/Users ***********
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _unitOfWork.Users.GetAll();
            return Ok(users);
        }

        // *********** GET: api/Users/5 ***********
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _unitOfWork.Users.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // *********** POST: api/Users ***********
        [HttpPost]
        public IActionResult CreateUser([FromBody] Users user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.Users.Add(user);
            _unitOfWork.Save();

            return CreatedAtAction("GetUser", new { id = user.UserId }, user);
        }

        // *********** PUT: api/Users/5 ***********
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] Users user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            var existingUser = _unitOfWork.Users.GetById(id);
            if (existingUser == null)
            {
                return NotFound();
            }

            existingUser.UserName = user.UserName;
            existingUser.FullName = user.FullName;
            existingUser.Email = user.Email;
            existingUser.Password = user.Password;
            existingUser.Role = user.Role;
            existingUser.TelephoneNumber = user.TelephoneNumber;
            existingUser.DateOfBirth = user.DateOfBirth;
            existingUser.Gender = user.Gender;

            _unitOfWork.Users.Update(existingUser);
            _unitOfWork.Save();

            return NoContent();
        }

        // *********** DELETE: api/Users/5 ***********
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _unitOfWork.Users.GetById(id);
            if (user == null)
            {
                return NotFound();
            }

            _unitOfWork.Users.Delete(user);
            _unitOfWork.Save();

            return NoContent();
        }

        [HttpPost]
        public IActionResult Register([FromBody] UserRegister user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Users newuser = new Users()
            {
                 UserName = user.UserName,
                 FullName = user.FullName,
                 Email = user.Email,
                 Password = user.Password,
                 Role = user.Role,
                 TelephoneNumber = user.TelephoneNumber,
                 DateOfBirth = user.DateOfBirth,
                 Gender = user.Gender,
            };
            _unitOfWork.Users.Add(newuser);
            _unitOfWork.Save();

            return CreatedAtAction("GetUser", new { id = newuser.UserId }, user);
        }
    }
}
