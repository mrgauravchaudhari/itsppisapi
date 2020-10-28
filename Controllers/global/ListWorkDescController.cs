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
    public class ListWorkDescController : ControllerBase
    {
        private readonly ListWorkDescRepository _repository;

        public ListWorkDescController(ListWorkDescRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<ListWorkDescModel>>> Put(ListWorkDescDto data)
        {
            return await _repository.putData(data);
        }
    }
}
