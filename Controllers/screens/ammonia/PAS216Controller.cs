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
    public class PAS216Controller : ControllerBase
    {
        private readonly PAS216Repository _repository;

        public PAS216Controller(PAS216Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS216Model>> Put(TransactionDateBtnDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(PAS216SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
