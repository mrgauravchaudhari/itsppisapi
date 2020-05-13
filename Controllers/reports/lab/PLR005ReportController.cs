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
    public class PLR005ReportController : ControllerBase
    {
        private readonly PLR005ReportRepository _repository;

        public PLR005ReportController(PLR005ReportRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/PLR005Report/
        [HttpGet("{TDATE}")]
        public async Task<ActionResult<List<PLR005ReportModel>>> Get(string TDATE)
        {
            var response = await _repository.GetById(TDATE);
            if (response == null)
            {
                return NotFound();
            }
            return response;
        }
    }
}