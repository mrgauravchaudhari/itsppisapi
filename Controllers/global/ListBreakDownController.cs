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
    public class ListBreakDownController : ControllerBase
    {
        private readonly ListBreakDownRepository _repository;

        public ListBreakDownController(ListBreakDownRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<ListBreakDownModel>>> Put(BreakDownParamDto data)
        {
            return await _repository.putData(data);
        }
    }
}
