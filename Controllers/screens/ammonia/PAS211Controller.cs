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
    public class PAS211Controller : ControllerBase
    {
        private readonly PAS211Repository _repository;

        public PAS211Controller(PAS211Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS211Model>> Put(TransactionDateBtnDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(PAS211SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
