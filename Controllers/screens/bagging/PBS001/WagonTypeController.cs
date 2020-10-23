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
    public class WagonTypeController : ControllerBase
    {
        private readonly WagonTypeRepository _repository;

        public WagonTypeController(WagonTypeRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<List<WagonTypeModel>>> Get()
        {
            return await _repository.getData();
        }

        [HttpPost]
        public async Task Post(WagonTypeDto data)
        {
            await _repository.saveData(data);
        }
    }
}
