using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.Controllers.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;

        public ChildController(IChildService childService)
        {
            _childService = childService;
        }

        [HttpGet]
        public async Task<IEnumerable<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(int id)
        {
            return await _childService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildModel model)
        {
            ChildDTO childDTO = new ChildDTO()
            {
                Tz = model.Tz,
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                IdUser = model.UserId
            };
            return await _childService.AddAsync(childDTO);
        }

        [HttpPut("{id}")]
        public async Task<ChildDTO> Put(int id, [FromBody] ChildModel model)
        {
            ChildDTO childDTO = new ChildDTO()
            {
                ChildId = id,
                Tz = model.Tz,
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                IdUser = model.UserId
            };
            return await _childService.UpdateAsync(childDTO);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childService.DeleteAsync(id);
        }

    }
}

