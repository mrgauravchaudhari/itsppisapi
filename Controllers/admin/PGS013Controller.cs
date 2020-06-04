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
    public class PGS013Controller : ControllerBase
    {
        private readonly PGS013Repository _repository;
        public PGS013Controller(PGS013Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PGS013Model>>> Get()
        {
            return await _repository.getData();
        }

        //POST api/PGS013
        [HttpPost]
        public async Task Post(PGS013SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
