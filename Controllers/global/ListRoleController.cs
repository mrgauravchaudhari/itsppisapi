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
    public class ListRoleController : ControllerBase
    {
        private readonly ListRoleRepository _repository;

        public ListRoleController(ListRoleRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListRoleModel>>> Get()
        {
            return await _repository.getData();
        }
        
        [HttpGet]
        [Route("ListRoleActive")]
        public async Task<ActionResult<IEnumerable<ListRoleModel>>> Get2()
        {
            return await _repository.getData2();
        }
    }
}
