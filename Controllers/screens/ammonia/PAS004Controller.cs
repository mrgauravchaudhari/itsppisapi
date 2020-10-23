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
    public class PAS004Controller : ControllerBase
    {
        private readonly PAS004Repository _repository;

        public PAS004Controller(PAS004Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS004Model>> Put([FromBody] MonthYearParamDto data)
        {
            return await _repository.putData(data.MONTH, data.YEAR);
        }

        [HttpPut]
        [Route("CalAmmVar")]
        public async Task<ActionResult<PAS004Model2>> Put2([FromBody] string MONTH, string YEAR, string DELETE_FLG, decimal USER_ID)
        {
            return await _repository.calAmmVar(MONTH, YEAR, DELETE_FLG, USER_ID);
        }

        [HttpPost]
        public async Task Post(PAS004SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
