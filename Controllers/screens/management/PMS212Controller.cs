using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;
using itsppisapi.SaveDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PMS212Controller : ControllerBase
    {
        private readonly PMS212Repository _repository;

        public PMS212Controller(PMS212Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PMS212Model>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPost]
        public async Task Post(PMS212SaveDto data)
        {
            await _repository.saveData(data);
        }

    }
}
