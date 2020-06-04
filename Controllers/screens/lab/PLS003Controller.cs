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
    public class PLS003Controller
    {
        private readonly PLS003Repository _repository;
        public PLS003Controller(PLS003Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<PLS003Model>>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter,data.Btn);
        }

    }
}