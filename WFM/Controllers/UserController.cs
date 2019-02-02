﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WFM.Services.Interfaces;
using WFM.Services.Services;
using WFM.WebAPI.DTOs;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WFM.WebAPI.Controllers
{
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
        [HttpGet]
        public IEnumerable<UserResponse> Get()
        {
            try
            {
                //get all users
                var result = _userService.getAllUsers();
                var users = _mapper.Map<List<UserResponse>>(result);
                return users;
            }
            catch (Exception)
            {

                return null; 
            }
           
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
