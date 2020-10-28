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
    public class POS008Controller : ControllerBase
    {
        private readonly POS008Repository _repository;

        public POS008Controller(POS008Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<POS008Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPost]
        public async Task Post(POS008SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
