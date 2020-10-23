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
    public class PAS301Controller : ControllerBase
    {
        private readonly PAS301Repository _repository;

        public PAS301Controller(PAS301Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS301Model>> Put(TransactionDateBtnDto data)
        {
            return await _repository.putData(data);
        } 

        [HttpPut]
        [Route("DV")]
        public async Task<ActionResult<PAS301ModelDV>> Put2(TransactionDateDto data)
        {
            return await _repository.putData2(data);
        }

        [HttpPost]
        public async Task Post(PAS301SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
