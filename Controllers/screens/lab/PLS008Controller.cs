using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS008Controller : ControllerBase
    {
        private readonly PLS008Repository _repository;
        public PLS008Controller(PLS008Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<List<PLS008Model>>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter,data.Btn);
        }
    }
}
