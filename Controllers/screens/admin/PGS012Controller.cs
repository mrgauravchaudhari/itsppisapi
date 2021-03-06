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
    public class PGS012Controller : ControllerBase
    {
        private readonly PGS012Repository _repository;
        public PGS012Controller(PGS012Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PGS012Model>>> Gut()
        {
            return await _repository.getData();
        }

        [HttpPut]
        public async Task<ActionResult<PGS012Model2>> Put(StringParameterDto data)
        {
            return await _repository.putData(data);
        }

        [HttpGet]
        [Route("ListGroup")]
        public async Task<ActionResult<IEnumerable<ListGroupNameModel>>> Get()
        {
            return await _repository.getData2();
        }

        //POST api/PGS012
        [HttpPost]
        public async Task Post(PGS012SaveDto data)
        {
            await _repository.saveRole(data);
        }
    }
}
