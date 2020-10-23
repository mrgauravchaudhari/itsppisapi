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
    [Authorize(AuthenticationSchemes = "Bearer")]
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
        public async Task<ActionResult<IEnumerable<PLS005Model>>> Put(threeParamDto data)
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
