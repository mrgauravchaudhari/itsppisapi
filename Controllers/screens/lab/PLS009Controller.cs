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

namespace cfclapi.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS009Controller : ControllerBase
    {
        private readonly PLS009Repository _repository;
        public PLS009Controller(PLS009Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

         [HttpPut]
         public async Task<ActionResult<List<PLS009Model>>> Put(TdateQueryModel data)
         {
             return await _repository.putData(data.IN_DATE);
         }
    }
}
