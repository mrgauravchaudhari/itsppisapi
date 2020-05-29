using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using itsppisapi.Dtos;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PGS010Controller : ControllerBase
    {
        private readonly PGS010Repository _repository;
        public PGS010Controller(PGS010Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PGS010Model>>> Get()
        {
            return await _repository.getData();
        }

        [HttpPut]
        public async Task<ActionResult<PGS010Model>> Put(StringParameterDto data)
        {
            return await _repository.putData(data);
        }

        //POST api/PGS010
        [HttpPost]
        public async Task Post(PGS010SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
