using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PGS007Controller : ControllerBase
    {
        private readonly PGS007Repository _repository;

        public PGS007Controller(PGS007Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<List<PGS007Model>>> Put()
        {
            return await _repository.putData();
        }

        [HttpPost]
        public async Task Post(PGS007SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
