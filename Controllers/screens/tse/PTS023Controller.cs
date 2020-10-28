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
