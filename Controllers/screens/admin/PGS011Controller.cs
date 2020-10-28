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
    public class PGS011Controller : ControllerBase
    {
        private readonly PGS011Repository _repository;
        public PGS011Controller(PGS011Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PGS011Model>>> Get()
        {
            return await _repository.getData();
        }

        [HttpGet]
        [Route("ListParentModule")]
        public async Task<ActionResult<IEnumerable<ListParentModuleModel>>> Get2()
        {
            return await _repository.getData2();
        }

        //POST api/PGS011
        [HttpPost]
        public async Task Post(PGS011SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
