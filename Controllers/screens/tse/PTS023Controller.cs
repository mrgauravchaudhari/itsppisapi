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
    public class PTS023Controller : ControllerBase
    {
        private readonly PTS023Repository _repository;

        public PTS023Controller(PTS023Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<List<PTS023Model>>> Put()
        {
            return await _repository.putData();
        }

        [HttpPost]
        public async Task Post(PTS023SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
