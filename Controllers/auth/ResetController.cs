using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cfclapi.Data;
using cfclapi.Dtos;
using cfclapi.Models;

namespace cfclapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResetController : ControllerBase
    {
        private readonly ResetRepository _repository;

        public ResetController(ResetRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        
        // [HttpPost("username")]
        // public async Task<ActionResult<ResetModel>> Post(StringParameterDto data)
        // {
        //     return await _repository.getData(data);
        // }

        [HttpPut]
        public async Task<ActionResult<ResetModel>> Put(StringParameterDto data)
        {
            return await _repository.getData(data);
        }
    }
}
