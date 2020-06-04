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
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PGS011Controller : ControllerBase
    {
        private readonly PGS011Repository _repository;
        public PGS011Controller(PGS011Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PGS011Model>>> Get()
        {
            return await _repository.getData();
        }

        [HttpPut]
        public async Task<ActionResult<PGS011Model>> Put(StringParameterDto data)
        {
            return await _repository.putData(data);
        }

        //POST api/PGS011
        [HttpPost]
        public async Task Post(PGS011SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
