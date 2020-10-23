using System;
using System.Threading.Tasks;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
     [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class POS301Controller : ControllerBase
    {
        private readonly POS301Repository _repository;

        public POS301Controller(POS301Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<POS301Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPut]
        [Route("DV")]
        public async Task<ActionResult<POS301DVModel>> PutDV([FromBody] StringParameterDto data)
        {
            return await _repository.putDataDV(data.StringParameter);
        }

        [HttpPut]
        [Route("DV2")]
        public async Task<ActionResult<POS301DV2Model>> PutDV2([FromBody] DynamicParameterDto data)
        {
            return await _repository.getDV2(data.DynamicParameter);
        }

        [HttpPost]
        public async Task Post(POS301SaveDto data)
        {
           await _repository.saveData(data);
        }
    }
}
