using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using itsppisapi.Dtos;

namespace itsppisapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS004Controller : ControllerBase
    {
        private readonly PLS004Repository _repository;
        public PLS004Controller(PLS004Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PLS004Model>> Put(StringParameterDto data)
        {
            return await _repository.putData(data.StringParameter);
        }
    }
}
