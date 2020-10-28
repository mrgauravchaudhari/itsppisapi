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
    public class ContractorDemurrageController : ControllerBase
    {
        private readonly ContractorDemurrageRepository _repository;

        public ContractorDemurrageController(ContractorDemurrageRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<ContractorDemurrage>>> Put(threeParamDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(ContractorDemurrageSaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
