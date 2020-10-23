using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PTS227Controller : ControllerBase
    {
        private readonly PTS227Repository _repository;

        public PTS227Controller(PTS227Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PTS227Model>> Put(PTS227Dto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(PTS227SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
