using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cfclapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cfclapi.Data;
using Microsoft.AspNetCore.Authorization;

namespace cfclapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ListReportNameController : ControllerBase
    {
        private readonly ListReportNameRepository _repository;

        public ListReportNameController(ListReportNameRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListReportNameModel>>> Get()
        {
            return await _repository.getData();
        }
    }
}