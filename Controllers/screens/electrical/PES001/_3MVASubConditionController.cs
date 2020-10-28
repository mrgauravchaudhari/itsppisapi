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
    public class _3MVASubConditionController : ControllerBase
    {
        private readonly _3MVASubConditionRepository _repository;

        public _3MVASubConditionController(_3MVASubConditionRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("GetCondList")]
        public async Task<ActionResult<List<_3MVASubConditionModel>>> Get()
        {
            return await _repository.getCondList();
        }

        [HttpGet("getData")]
        public async Task<ActionResult<List<_3MVASubConditionModel>>> get()
        {
            return await _repository.getData();
        }

        [HttpPost]
        public async Task Post(_3MVASubConditionDto data)
        {
            await _repository.saveData(data);
        }

        [HttpGet("GetSubCondList")]
        public async Task<ActionResult<List<_3MVASubConditionModel>>> GetSub()
        {
            return await _repository.getSubCondList();
        }
    }
}
