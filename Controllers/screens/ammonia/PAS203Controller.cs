using System;
using System.Threading.Tasks;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace itsppisapi.Controllers
{
     [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PAS203Controller : ControllerBase
    {
        private readonly PAS203Repository _repository;

        public PAS203Controller(PAS203Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS203Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPut]
        [Route("PUT2")]
        public async Task<ActionResult<List<PAS203_2Model>>> Put2([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData2(data.StringParameter, data.Btn);
        }

        [HttpPost]
        public async Task Post(PAS203SaveDto data)
        {
            await _repository.saveData(data);
        }

        [HttpPost]
        [Route("SAVE2")]
        public async Task Post2(PAS203_2SaveDto data)
        {
            await _repository.saveData2(data);
        }
    }
}
