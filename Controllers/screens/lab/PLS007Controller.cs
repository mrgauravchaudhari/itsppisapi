using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS007Controller : ControllerBase
    {
        private readonly PLS007Repository _repository;
        public PLS007Controller(PLS007Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PLS007Model>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }
    }
}
