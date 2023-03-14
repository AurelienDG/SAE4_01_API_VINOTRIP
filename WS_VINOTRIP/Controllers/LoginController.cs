using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WS_VINOTRIP.Models.EntityFramework;
using WS_VINOTRIP.Models.Repository;

namespace WS_VINOTRIP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;

        private List<User1> appUsers1 = new List<User1>
        {
            new User1 { FullName = "Vincent COUTURIER", UserName = "vince", Password = "1234", UserRole = "Admin" },
            new User1 { FullName = "Marc MACHIN", UserName = "marc", Password = "1234", UserRole = "User" }
        };
        private List<User> appUsers = new List<User>
        {
            new User { Pseudo = "Connard",Prenom="Irwin",Role="Admin",Mdp="1234"},
            new User { Pseudo = "TG",Prenom="JOSIANNE",Role="User",Mdp="1234"}

        };

        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] User login)
        {
            IActionResult response = Unauthorized();
            User user = AuthenticateUser(login);
            if (user != null)
            {
                var tokenString = GenerateJwtToken(user);
                response = Ok(new
                {
                    token = tokenString,
                    userDetails = user,
                });
            }
            return response;
        }


        private User AuthenticateUser(User user)
        {
            return appUsers.SingleOrDefault(x => x.Pseudo.ToUpper() == user.Pseudo.ToUpper() && x.Mdp == user.Mdp);
        }


        private string GenerateJwtToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.Pseudo),
                new Claim("tel", userInfo.Pseudo.ToString()),
                new Claim("role",userInfo.Role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
