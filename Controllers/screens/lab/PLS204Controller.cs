using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using itsppisapi.Dtos;

namespace itsppisapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS204Controller : ControllerBase
    {
        private readonly PLS204Repository _repository;

        public PLS204Controller(PLS204Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PLS204Model>> Put(StringParamWbtnDto data)
        {
            return await _repository.getData(data.StringParameter,data.Btn);
        }
    }
}
