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
    public class PMS201Controller : ControllerBase
    {
        private readonly PMS201Repository _repository;

        public PMS201Controller(PMS201Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PMS201Model>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPost]
        public async Task Post(PMS201SaveDto data)
        {
            await _repository.saveData(data);
        }

    }
}
