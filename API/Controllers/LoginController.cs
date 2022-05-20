using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly APIDbContext _context;
        private readonly IConfiguration _configuration;


        public LoginController(APIDbContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }


        [HttpPost, Route("Register")]
        public async Task<IActionResult> Register(RegistroDTO registroDTO)
        {
            var u = _context.Usuarios
                .FirstOrDefault(x=> x.Username == registroDTO.Username);

            if (u != null) return BadRequest("User Exists!");

            User usuario = new User();
            usuario.Username = registroDTO.Username;
            CreatePasswordHash(registroDTO.Password, 
               out byte[] passwordHash, out byte[] passwordSalt);

            usuario.PasswordHash = passwordHash;
            usuario.PasswordSalt = passwordSalt;

            _context.Add(usuario);
            await _context.SaveChangesAsync();

            return Ok("User Registered");
        }

        [HttpPost, Route("Login")]
        public async Task<IActionResult> Login(RegistroDTO registroDTO)
        {
            var u = _context.Usuarios
                .FirstOrDefault(u=>u.Username == registroDTO.Username);

            if (u == null) return BadRequest("User Not Exists!");

            if (!VerifyPasswordHash(registroDTO.Password, 
                u.PasswordHash, u.PasswordSalt)) return BadRequest("Bad Password!");
            
            string tk = CreateToken(u);
            return Ok($"Login Successfull! Token: {tk}");

        }


        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, 
            byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, "Free")
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var credential = new SigningCredentials(key, 
                SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credential
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
