using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cfclapi.Data;
using cfclapi.Models;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using cfclapi.Dtos;

namespace cfclapi.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS005Controller : ControllerBase
    {
        private readonly PLS005Repository _repository;
        public PLS005Controller(PLS005Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<PLS005Model>>> Put(TransactionDateDto data)
        {
            return await _repository.getData(data);
        }

        [HttpPost]
        public async Task Post(PLS005SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
