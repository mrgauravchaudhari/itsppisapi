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
    public class PAS213Controller : ControllerBase
    {
        private readonly PAS213Repository _repository;

        public PAS213Controller(PAS213Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS213Model>> Put([FromBody] MonthYearParamDto data)
        {
            return await _repository.putData(data.MONTH, data.YEAR);
        }

        [HttpPut]
        [Route("CalAmmVar")]
        public async Task<ActionResult<PAS213Model2>> Put2([FromBody] string MONTH, string YEAR, string DELETE_FLG, decimal USER_ID)
        {
            return await _repository.calAmmVar(MONTH, YEAR, DELETE_FLG, USER_ID);
        }

        [HttpPost]
        public async Task Post(PAS213SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
