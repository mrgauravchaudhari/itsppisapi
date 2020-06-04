using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ListModuleController : ControllerBase
    {
        private readonly ListModuleRepository _repository;

        public ListModuleController(ListModuleRepository repository)
        { 
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListModuleModel>>> Get()
        {
            return await _repository.getData();
        }
        [HttpGet]
        [Route("ListActiveModule")]
        public async Task<ActionResult<IEnumerable<ListModuleModel>>> Get2()
        {
            return await _repository.getData2();
        }
    }
}
