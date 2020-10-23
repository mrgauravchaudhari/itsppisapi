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
    public class PAS302Controller : ControllerBase
    {
        private readonly PAS302Repository _repository;

        public PAS302Controller(PAS302Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS302Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPut]
        [Route("PUT2")]
        public async Task<ActionResult<List<PAS302_2Model>>> Put2([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData2(data.StringParameter, data.Btn);
        }

        [HttpPost]
        public async Task Post(PAS302SaveDto data)
        {
            await _repository.saveData(data);
        }

        [HttpPost]
        [Route("SAVE2")]
        public async Task Post2(PAS302_2SaveDto data)
        {
            await _repository.saveData2(data);
        }
    }
}
