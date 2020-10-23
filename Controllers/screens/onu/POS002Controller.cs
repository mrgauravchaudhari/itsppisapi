using System;
using System.Threading.Tasks;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class POS002Controller : ControllerBase
    {
        private readonly POS002Repository _repository;

        public POS002Controller(POS002Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<POS002Model>>> Put(POS002Dto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(POS002SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
