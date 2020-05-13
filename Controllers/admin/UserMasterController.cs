using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cfclapi.Data;
using cfclapi.Models;
using cfclapi.Dtos;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace cfclapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserMasterController : ControllerBase
    {
        private readonly UserMasterRepository _repository;
        public UserMasterController(UserMasterRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<UserMasterModel>> Put(StringParameterDto data)
        {
            return await _repository.getData(data);
        }

        //POST api/UserMaster
        [HttpPost]
        public async Task Post(UserMasterSaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}