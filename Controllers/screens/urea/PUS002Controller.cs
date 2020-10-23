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
    public class PUS002Controller : ControllerBase
    {
        private readonly PUS002Repository _repository;

        public PUS002Controller(PUS002Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PUS002Model>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPut("DV1")]
        public async Task<ActionResult<PUS002DVDto>> PutDV1(StringParameterDto data)
        {
            return await _repository.putDataDV1(data.StringParameter);
        }

        [HttpPost]
        public async Task Post(PUS002Dto data)
        {
            await _repository.saveData(data);
        }
    }
}
