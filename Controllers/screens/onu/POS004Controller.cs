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
    public class POS004Controller : ControllerBase
    {
        private readonly POS004Repository _repository;

        public POS004Controller(POS004Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<POS004Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPost]
        public async Task Post(POS004SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
