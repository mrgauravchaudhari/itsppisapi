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
    public class POS019Controller : ControllerBase
    {
        private readonly POS019Repository _repository;

        public POS019Controller(POS019Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<POS019Model>> Put([FromBody] POS019ParamDto data)
        {
            return await _repository.putData(data.IN_DATE, data.IN_UNIT, data.Btn);
        }

        [HttpPost]
        public async Task Post(POS019SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
