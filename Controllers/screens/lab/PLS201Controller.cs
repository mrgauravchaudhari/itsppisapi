using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS201Controller : ControllerBase
    {
        private readonly PLS201Repository _repository;

        public PLS201Controller(PLS201Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<List<PLS201Model>>> Put(TdateQueryModel data)
        {
            return await _repository.putData(data.IN_DATE);
        }
    }
}
