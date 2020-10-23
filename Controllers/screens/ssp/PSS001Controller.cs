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
    public class PSS001Controller : ControllerBase
    {
        private readonly PSS001Repository _repository;

        public PSS001Controller(PSS001Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PSS001Model>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpPost]
        public async Task Post(PSS001SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
