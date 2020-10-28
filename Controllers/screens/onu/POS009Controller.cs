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
    public class POS009Controller : ControllerBase
    {
        private readonly POS009Repository _repository;

        public POS009Controller(POS009Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<POS009Model>> Put(TransactionDateBtnDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPut]
        [Route("Function")]
        public async Task<ActionResult<Func_HS_CF_CALC_Model>> Put(Func_HS_CF_CALC_Dto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(POS009SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
