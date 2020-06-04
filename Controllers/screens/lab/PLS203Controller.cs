using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using itsppisapi.Dtos;

namespace itsppisapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS203Controller : ControllerBase
    {
        private readonly PLS203Repository _repository;

        public PLS203Controller(PLS203Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<List<PLS203Model>>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter,data.Btn);
        }
    }
}
