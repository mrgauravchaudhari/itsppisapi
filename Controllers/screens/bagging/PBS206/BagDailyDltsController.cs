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
    public class BagDailyDltsController : ControllerBase
    {
        private readonly BagDailyDltsRepository _repository;

        public BagDailyDltsController(BagDailyDltsRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BagTypeNSize>>> Gut()
        {
            return await _repository.getData();
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<BagDailyDlts>>> Put(threeParamDto data)
        {
            return await _repository.putData(data);
        }
        
        [HttpPost]
        public async Task Post(BagDailyDltsSaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
