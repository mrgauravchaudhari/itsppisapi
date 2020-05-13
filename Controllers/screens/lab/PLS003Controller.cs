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
    public class PLS003Controller
    {
        private readonly PLS003Repository _repository;
        public PLS003Controller(PLS003Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<PLS003Model>>> Put(PLS003Dto data)
        {
            return await _repository.getData(data);
        }

    }
}