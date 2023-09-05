using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using stockrain.api.Model;

namespace stockrain.api.Controllers
{
    [ApiController]
    public class RepositoryController : BaseApiController
    {

        private readonly IConfiguration _configuration;

        public RepositoryController(IConfiguration config)
        {
            _configuration = config;
        }
        
        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] UsuarioTest req)
        {
            if (req.Username == "dianita" && req.Password == "123")
            {
                var jwt = _configuration.GetSection("Jwt").Get<Jwt>();
                
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, jwt?.Subject),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString())
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
                var singIn = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: null, audience: null,
                    claims,
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: singIn
                );
                
                
                return Ok(new { Token = new JwtSecurityTokenHandler().WriteToken(token) });
            }
            else
            {
                return BadRequest("Usuario no existe o es incorrecto!");
            }
        }
    }
}

