using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PUS201Controller : ControllerBase
    {
        private readonly PUS201Repository _repository;

        public PUS201Controller(PUS201Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PUS201Model>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPut]
        [Route("DV2")]
        public async Task<ActionResult<PUS201DVDto>> PutDV1(StringParameterDto data)
        {
            return await _repository.putDataDV2(data.StringParameter);
        }

        [HttpPost]
        public async Task Post(PUS201Dto data)
        {
            await _repository.saveData(data);
        }
    }
}
