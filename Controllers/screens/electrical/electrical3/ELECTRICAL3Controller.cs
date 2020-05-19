using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using itsppisapi.Dtos;

namespace itsppisapi.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ELECTRICAL3Controller : ControllerBase
    {
        private readonly ELECTRICAL3Repository _repository;
        public ELECTRICAL3Controller(ELECTRICAL3Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<ELECTRICAL3Model>>> Put(TransactionDateDto data)
        {
            return await _repository.getData(data);
        }

        [HttpPut]
        [Route("dv")]
        public async Task<ActionResult<IEnumerable<ELECTRICAL3DVModel>>> Get(TransactionDateDto data)
        {
            return await _repository.getDVData(data);
        }

        [HttpPost]
        public async Task Post(ELECTRICAL3SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
