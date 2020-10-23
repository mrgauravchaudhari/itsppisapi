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
    public class PGS006Controller : ControllerBase
    {
        private readonly PGS006Repository _repository;

        public PGS006Controller(PGS006Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<List<PGS006Model>>> Put()
        {
            return await _repository.putData();
        }

        [HttpPost]
        public async Task Post(PGS006SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
