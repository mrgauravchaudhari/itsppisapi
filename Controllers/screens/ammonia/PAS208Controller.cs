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
    public class PAS208Controller : ControllerBase
    {
        private readonly PAS208Repository _repository;

        public PAS208Controller(PAS208Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS208Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPost]
        public async Task Post(PAS208SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
