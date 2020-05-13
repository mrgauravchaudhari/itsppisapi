using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cfclapi.Data;
using cfclapi.Models;
using Microsoft.AspNetCore.Authorization;

namespace cfclapi.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLR203ReportController : ControllerBase
    {
        private readonly PLR203ReportRepository _repository;

        public PLR203ReportController(PLR203ReportRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/PLR203Report/
        [HttpGet("{IN_DATE}")]
        public async Task<ActionResult<List<PLR203ReportModel>>> Get(string IN_DATE)
        {
            var response = await _repository.GetById(IN_DATE);
            if (response == null)
            {
                return NotFound();
            }
            return response;
        }
    }
}
