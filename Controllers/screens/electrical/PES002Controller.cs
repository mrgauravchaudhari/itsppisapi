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
    public class PES002Controller : ControllerBase
    {
        private readonly PES002Repository _repository;

        public PES002Controller(PES002Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PES002Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPut("DV")]
        public async Task<ActionResult<PES002DVDto>> PutDV([FromBody] TdateQueryModel data)
        {
            return await _repository.putDataDV(data.IN_DATE);
        }

        [HttpPut("DV2")]
        public async Task<ActionResult<PES002DV2Dto>> PutDV2([FromBody] TdateQueryModel data)
        {
            return await _repository.putDataDV2(data.IN_SUB_COND_ID, data.IN_TAB);

        }

        [HttpPost]
        public async Task Post(PES002Model data)
        {
            await _repository.saveData(data);
        }
    }
}
