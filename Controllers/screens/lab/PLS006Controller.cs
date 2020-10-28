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
    public class PLS006Controller : ControllerBase
    {
        private readonly PLS006Repository _repository;
        public PLS006Controller(PLS006Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<List<PLS006Model>>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }
    }
}
