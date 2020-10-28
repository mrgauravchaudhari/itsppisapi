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
    public class POS003Controller : ControllerBase
    {
        private readonly POS003Repository _repository;

        public POS003Controller(POS003Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<POS003Model>> Put(TransactionDateBtnDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPut]
        [Route("Function")]
        public async Task<ActionResult<Func_IN_STK_Model>> Put(Func_IN_STK_Dto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(POS003SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
