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
    public class PUS003Controller : ControllerBase
    {
        private readonly PUS003Repository _repository;

        public PUS003Controller(PUS003Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PUS003Model>> Put(StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }

        [HttpGet("GetList")]
        public async Task<ActionResult<List<BREAKDOWN_LISTDto>>> GetList()
        {
            return await _repository.getDataList();
        }

        [HttpPost]
        public async Task Post(PUS003Dto data)
        {
            await _repository.saveData(data);
        }
    }
}
