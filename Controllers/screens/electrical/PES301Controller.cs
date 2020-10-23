using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using itsppisapi.Dtos;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PES301Controller : ControllerBase
    {
        private readonly PES301Repository _repository;
        public PES301Controller(PES301Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<PES301Model>>> Put(TransactionDateDto data)
        {
            return await _repository.getData(data);
        }

        [HttpPut]
        [Route("dv")]
        public async Task<ActionResult<IEnumerable<PES301DVModel>>> Get(TransactionDateDto data)
        {
            return await _repository.getDVData(data);
        }

        [HttpPost]
        public async Task Post(PES301SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
