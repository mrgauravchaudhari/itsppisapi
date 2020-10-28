using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListDepartmentController : ControllerBase
    {
        private readonly ListDepartmentRepository _repository;

        public ListDepartmentController(ListDepartmentRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListDepartmentModel>>> Get()
        {
            return await _repository.getData();
        }
    }
}
