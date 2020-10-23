using itsppisapi.Data;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PUS301Controller : ControllerBase
    {
        private readonly PUS301Repository _repository;
        public PUS301Controller(PUS301Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PUS301Model>> Put(TransactionDateBtnDto data)
        {
            return await _repository.put(data);
        }

        [HttpPut]
        [Route("dv")]
        public async Task<ActionResult<PUS301DVModel>> PutDV(TransactionDateDto data)
        {
            return await _repository.putDV(data);
        }

        [HttpPost]
        public async Task Post(PUS301SaveDto data)
        {
            await _repository.save(data);
        }
    }
}
