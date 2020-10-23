using System;
using System.Threading.Tasks;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PGS017Controller : ControllerBase
    {
        private readonly PGS017Repository _repository;

        public PGS017Controller(PGS017Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<List<PGS017Model>>> Put()
        {
            return await _repository.putData();
        }

        [HttpPost]
        public async Task Post(PGS017SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
