using JWT.Models;
using JWT.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly repository repository;

        public UserController(repository repository)
        {
            this.repository = repository;
        }
        [HttpPost]
        public async Task<ActionResult<User>>Register(UserDto user)
        {
            repository.CreatePasswordHash(user.Password,out byte[]passwordHash, out byte[] passwordSalt)
        }
    }
}
