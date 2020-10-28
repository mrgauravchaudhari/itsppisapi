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
    public class PBS203Controller : ControllerBase
    {
        private readonly PBS203Repository _repository;

        public PBS203Controller(PBS203Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        [Route("M2")]
        public async Task<List<PBS203Model>> PutData2([FromBody] StringParamWbtnDto data)
        {
            return await _repository.put2(data.StringParameter, data.Btn);
        }

        // [HttpPost]
        // public async Task Post(PBS203Dto data)
        // {
        //     await _repository.saveData(data);
        // }
    }
}
