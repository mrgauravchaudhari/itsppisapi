using System;
using System.Threading.Tasks;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using itsppisapi.SaveDtos;

namespace itsppisapi.Controllers
{
     [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class POS001Controller : ControllerBase
    {
        private readonly POS001Repository _repository;

        public POS001Controller(POS001Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // PUT METHOD FOR MACHINE MASTER
        [HttpPut]
        [Route("GET_MACHINE")]
        public async Task<ActionResult<List<MachineMasterModel>>> PutMM([FromBody] StringParameterDto data)
        {
            return await _repository.putDataMM(data.StringParameter);
        }

        // PUT METHOD FOR CHEMICAL MASTER
        [HttpPut]
        [Route("GET_CHEMICAL")]
        public async Task<ActionResult<List<ChemicalMasterModel>>> PutCM([FromBody] StringParameterDto data)
        {
            return await _repository.putDataCM(data.StringParameter);
        }

        // PUT METHOD FOR STOCK MASTER
        [HttpPut]
        [Route("GET_STOCK")]
        public async Task<ActionResult<List<StockMasterModel>>> PutSM([FromBody] StringParameterDto data)
        {
            return await _repository.putDataSM(data.StringParameter);
        }

        // SAVE METHOD FOR MACHINE MASTER
        [HttpPost]
        [Route("SAVE_MACHINE")]
        public async Task PostMM(MachineMasterSaveDto data)
        {
            await _repository.saveDataMM(data);
        }

        // SAVE METHOD FOR CHEMICAL MASTER
        [HttpPost]
        [Route("SAVE_CHEMICAL")]
        public async Task PostCM(ChemicalMasterSaveDto data)
        {
            await _repository.saveDataCM(data);
        }

        // SAVE METHOD FOR STOCK MASTER
        [HttpPost]
        [Route("SAVE_STOCK")]
        public async Task PostSM(StockMasterSaveDto data)
        {
            await _repository.saveDataSM(data);
        }
    }
}
