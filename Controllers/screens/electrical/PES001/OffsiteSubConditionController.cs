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
    public class OffsiteSubConditionController : ControllerBase
    {
        private readonly OffsiteSubConditionRepository _repository;

        public OffsiteSubConditionController(OffsiteSubConditionRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("GetCondList")]
        public async Task<ActionResult<List<OffsiteSubConditionModel>>> Get()
        {
            return await _repository.getCondList();
        }

        [HttpGet("getData")]
        public async Task<ActionResult<List<OffsiteSubConditionModel>>> get()
        {
            return await _repository.getData();
        }

        [HttpPost]
        public async Task Post(OffsiteSubConditionDto data)
        {
            await _repository.saveData(data);
        }

        [HttpGet("GetSubCondList")]
        public async Task<ActionResult<List<OffsiteSubConditionModel>>> GetSub()
        {
            return await _repository.getSubCondList();
        }
    }
}
