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
    public class POS006Controller : ControllerBase
    {
        private readonly POS006Repository _repository;

        public POS006Controller(POS006Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<POS006Model>> Put(TransactionDateBtnDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(POS006SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
