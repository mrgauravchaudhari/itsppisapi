using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class DefectTypeController : ControllerBase
    {
        private readonly DefectTypeRepository _repository;

        public DefectTypeController(DefectTypeRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<List<DefectTypeModel>>> Get()
        {
            return await _repository.getData();
        }

        [HttpPost]
        public async Task Post(DefectTypeDto data)
        {
            await _repository.saveData(data);
        }
    }
}
