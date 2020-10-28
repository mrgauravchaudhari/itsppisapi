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
    public class POS011Controller : ControllerBase
    {
        private readonly POS011Repository _repository;

        public POS011Controller(POS011Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<POS011Model>> Put(TransactionDateBtnDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(POS011SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
