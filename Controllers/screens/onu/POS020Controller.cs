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
    public class POS020Controller : ControllerBase
    {
        private readonly POS020Repository _repository;

        public POS020Controller(POS020Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<POS020Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(POS020SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
