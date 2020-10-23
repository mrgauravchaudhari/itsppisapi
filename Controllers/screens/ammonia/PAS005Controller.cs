using System;
using System.Threading.Tasks;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Dtos;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PAS005Controller : ControllerBase
    {
        private readonly PAS005Repository _repository;

        public PAS005Controller(PAS005Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS005Model>> Put(MonthYearParamDto data)
        {
            return await _repository.putData(data);
        }
    }
}
