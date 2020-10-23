using System;
using System.Threading.Tasks;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class POS015Controller : ControllerBase
    {
        private readonly POS015Repository _repository;

        public POS015Controller(POS015Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<List<POS015Model>>> Put([FromBody] StringParameterDto data)
        {
            return await _repository.putData(data.StringParameter);
        }

        [HttpPost]
        public async Task Post(POS015SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
