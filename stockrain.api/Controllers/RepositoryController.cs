using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using stockrain.api.Model;
using stockrain.infrestructure.Services.Implementations;

namespace stockrain.api.Controllers
{
    public class RepositoryController : BaseApiController
    {

        private readonly IConfiguration _configuration;

        public RepositoryController(IConfiguration config)
        {
            _configuration = config;
        }
        
        [HttpPost]
        public IActionResult Login([FromBody] UsuarioTest req)
        {
            if (req.Username == "dianita" && req.Password == "123")
            {
                var Jwt = _configuration.GetSection("Jwt").Get<Jwt>();
                return Ok("Usuario logeado con exito!");
            }
            else
            {
                return BadRequest("Usuario no existe o es incorrecto!");
            }
        }
    }
}

