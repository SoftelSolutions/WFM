using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WFM.Services.Interfaces;
using WFM.Services.Services;
using WFM.WebAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using WFM.WebAPI.DTOs.UserDTOs;
using WFM.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WFM.WebAPI.Controllers
{
    /// <summary>
    /// Get Users
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        // GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<UserResponse> Get()
        //{
        //    //usercontroller
        //    //var identity = HttpContext.User.Identity as ClaimsIdentity;
        //    //if (identity != null)
        //    //{
        //    //    IEnumerable<Claim> claims = identity.Claims;
        //    //    // or
        //    //    //identity.FindFirst("ClaimName").Value;

        //    //}

        //    //get all users 
        //    var result = _userService.getAllUsers();
        //    var users = _mapper.Map<List<UserResponse>>(result);
        //    return users;
        //}

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //get all users 
            var result = await _userService.GetAllUsers();
            var users = _mapper.Map<List<UserResponse>>(result);
            return Ok(users);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            //get user by Id 
            var result = await _userService.GetUserById(id);
            if (result == null)
            {
                return NotFound();
            }
            var users = _mapper.Map<List<UserResponse>>(result);
            return Ok(users);
        }

        // POST api/<controller>
        [HttpPost]
        [Produces(typeof(CreateUserRequest))]
        public async Task<IActionResult> Post([FromBody]CreateUserRequest user)
        {
            List<BaseResponse> baseResp = new List<BaseResponse>();

            var insertUser = _mapper.Map<User>(user);
            bool isInserted = await _userService.CreateUser(insertUser);

            if (!isInserted)
            {
                return NotFound();
            }
            else
            {
                baseResp.Add(new BaseResponse { Status = "true", Message = "user successfully created" });
            }

            return Ok();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        [Produces(typeof(UpdateUserRequest))]
        public async Task<IActionResult> Put(int id, [FromBody]UpdateUserRequest user)
        {

            //update user by Id 
            var updateUser = _mapper.Map<User>(user);
            var result = await _userService.UpdateUser(id, updateUser);
            if (!result.Any())
            {
                return NotFound();
            }
            return Ok(result);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //delete user by Id 
            var result = await _userService.DeleteUser(id);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
