using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ListAccessModuleController : ControllerBase
    {
        private readonly ListAccessModuleRepository _repository;

        public ListAccessModuleController(ListAccessModuleRepository repository)
        { 
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListAccessModuleModel>>> Get()
        {
            return await _repository.getData();
        }
    }
}
