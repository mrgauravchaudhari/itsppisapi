using itsppisapi.Data;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
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

        [HttpPut]
        public async Task<ActionResult<Object>> Put(StringParameterDto data)
        {
            var response = await _repository.getData(data);
            return new
            {
                response.USER_NAME,
                response.MSG
            };
        }
    }
}
