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
    public class PBS015Controller : ControllerBase
    {
        private readonly PBS015Repository _repository;

        public PBS015Controller(PBS015Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PBS015Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPost]
        public async Task Post(PBS015Dto data)
        {
            await _repository.saveData(data);
        }
    }
}
