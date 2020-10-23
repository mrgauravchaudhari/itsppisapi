using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
     [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS202Controller : ControllerBase
    {
        private readonly PLS202Repository _repository;

        public PLS202Controller(PLS202Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PLS202Model>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter,data.Btn);
        }

        [HttpPost]
        public async Task Post(PLS202SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
