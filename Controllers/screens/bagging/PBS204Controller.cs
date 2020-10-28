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
    public class PBS204Controller : ControllerBase
    {
        private readonly PBS204Repository _repository;

        public PBS204Controller(PBS204Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<PBS204Model>>> Put(PBS204Dto data)
        {
            return await _repository.putData(data);
        }

        [HttpPut]
        [Route("getrakeno")]
        public async Task<ActionResult<IEnumerable<RakeNoModel>>> Put2(StringParameterDto data)
        {
            return await _repository.putData2(data);
        }

        [HttpPost]
        public async Task Post(PBS204SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
