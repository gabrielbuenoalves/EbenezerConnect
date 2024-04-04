using Microsoft.AspNetCore.Mvc;
using EbenezerConnect.Services;
using EbenezerConnect.Data.Entidades;

namespace EbenezerConnect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            List<Eb_User> users = _userService.GetUsers();
            return Ok(users);
        }

        // GET: api/user/{id}
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            Eb_User user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound("Usuário não encontrado");
            }
            return Ok(user);
        }

        // POST: api/user
        [HttpPost]
        public IActionResult CreateUser(string username, string type)
        {
            _userService.CreateUser(username, type);
            return Ok("Usuário criado com sucesso!");
        }

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, string username, string type)
        {
            bool result = _userService.UpdateUser(id, username, type);
            if (!result)
            {
                return NotFound("Usuário não encontrado");
            }
            return Ok("Usuário atualizado com sucesso!");
        }

        // DELETE: api/user/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            bool result = _userService.DeleteUser(id);
            if (!result)
            {
                return NotFound("Usuário não encontrado");
            }
            return Ok("Usuário excluído com sucesso!");
        }
    }
}