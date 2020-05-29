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
    public class PGS012Controller : ControllerBase
    {
        private readonly PGS012Repository _repository;
        public PGS012Controller(PGS012Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PGS012Model>>> Get()
        {
            return await _repository.getData();
        }

        //POST api/PGS012
        [HttpPost]
        public async Task Post(PGS012SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
