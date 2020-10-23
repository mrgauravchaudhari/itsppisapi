using System;
using System.Threading.Tasks;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Dtos;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

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
