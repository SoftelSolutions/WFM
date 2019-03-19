using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WFM.Entity;
using WFM.Services.Interfaces;
using WFM.WebAPI.DTOs.LoginDTOs;
using WFM.WebAPI.Helpers;
using WFM.WebAPI.ValidateModel;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WFM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ValidateModel]
    public class LoginController : Controller
    {
        private readonly AppSettings _appSettings;

        ILoginService _loginService;
        private readonly IMapper _mapper;

        public LoginController(ILoginService loginService, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _loginService = loginService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest login)
        {
            List<LoginResponse> loginResp = new List<LoginResponse>();

            var userDetail = _loginService.Login(login.userName, login.password);

            if (userDetail == null)
                return NotFound();
            else
            {
                string token = getToken(userDetail);
                loginResp.Add(new LoginResponse { token = token });
            }
            return Ok(loginResp);
        }

        private string getToken(User user)
        {

           var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.secretKey));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokeOptions = new JwtSecurityToken(
                issuer: "http://localhost:64259",
                audience: "http://localhost:64259",
                claims: new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
                },
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signinCredentials
            );

            var token = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

            return token;
        }
    }

}
