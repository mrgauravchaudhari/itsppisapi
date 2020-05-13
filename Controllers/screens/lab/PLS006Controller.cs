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

namespace itsppisapi.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS006Controller : ControllerBase
    {
        private readonly PLS006Repository _repository;
        public PLS006Controller(PLS006Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<List<PLS006Model>>> Put(TdateQueryModel data)
        {
            return await _repository.putData(data.IN_DATE);
        }
    }
}
