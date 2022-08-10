using ECommerce.API.Models;
using ECommerce.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var user = _userService.Validate(loginViewModel.Username, loginViewModel.Password);

            if (user == null)
            {
                return BadRequest(new { message = "Invalid login" });
            }

            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("a-secret-sentence"));
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: "dummy.com.tr",
                audience: "dummy.com.tr",
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddHours(4),
                signingCredentials: credential
                );

            return Ok(new {token = new JwtSecurityTokenHandler().WriteToken(token)});
        }
    }
}
