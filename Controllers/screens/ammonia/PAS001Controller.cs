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
    public class PAS001Controller : ControllerBase
    {
        private readonly PAS001Repository _repository;

        public PAS001Controller(PAS001Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS001Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPut]
        [Route("DV")]
        public async Task<ActionResult<AMM1DVDto>> PutDV([FromBody] StringParameterDto data)
        {
            return await _repository.putDataDV(data.StringParameter);
        }

        [HttpPost]
        public async Task Post(PAS001SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
