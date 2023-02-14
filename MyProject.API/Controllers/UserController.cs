using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userervice;

        public UserController(IUserService userService)
        {
            _userervice = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<UserDTO>> Get()
        {
            return await _userervice.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _userervice.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel model)
        {
            UserDTO userDTO = new UserDTO()
            {
                Tz=model.Tz,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = (Common.DTOs.eGender)model.Gender,
                HMO = (Common.DTOs.eHMODTO)model.HMO
            };
            return await _userervice.AddAsync(userDTO);
        }

        [HttpPut("{id}")]
        public async Task<UserDTO> Put(int id, [FromBody] UserModel model)
        {
            UserDTO userDTO = new UserDTO()
            {
                UserId = id,
                Tz=model.Tz,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = (Common.DTOs.eGender)model.Gender,
                HMO = (Common.DTOs.eHMODTO)model.HMO
            };
            return await _userervice.UpdateAsync(userDTO);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userervice.DeleteAsync(id);
        }
    }
}
