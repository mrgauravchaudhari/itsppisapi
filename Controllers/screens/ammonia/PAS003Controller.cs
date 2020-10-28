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
    public class PAS003Controller : ControllerBase
    {
        private readonly PAS003Repository _repository;

        public PAS003Controller(PAS003Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS003Model>> Put([FromBody] MonthYearParamDto data)
        {
            return await _repository.putData(data.MONTH, data.YEAR);
        }

        [HttpPost]
        public async Task Post(PAS003SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
