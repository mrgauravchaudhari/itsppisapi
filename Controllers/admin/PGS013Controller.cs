using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using itsppisapi.Dtos;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PGS013Controller : ControllerBase
    {
        private readonly PGS013Repository _repository;
        public PGS013Controller(PGS013Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PGS013Model>> Put(NumberParameterDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPut]
        [Route("ListAccessModule")]
        public async Task<ActionResult<ListAccessModuleModel>> Put2(NumberParameterDto data)
        {
            return await _repository.putData2(data);
        }

        [HttpGet]
        [Route("ListModule")]
        public async Task<ActionResult<IEnumerable<ListModuleModel>>> Get3()
        {
            return await _repository.getData3();
        }

        [HttpGet]
        [Route("ListActiveGroup")]
        public async Task<ActionResult<IEnumerable<ListGroupModel>>> Get4()
        {
            return await _repository.getData4();
        }

        //POST api/PGS013
        [HttpPost]
        public async Task Post(PGS013SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
