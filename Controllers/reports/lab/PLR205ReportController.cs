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
    public class PLR205ReportController : ControllerBase
    {
        private readonly PLR205ReportRepository _repository;

        public PLR205ReportController(PLR205ReportRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/PLR205Report/
        [HttpGet]
        public async Task<ActionResult<List<PLR205ReportModel>>> Get()
        {
            var response = await _repository.GetById();
            if (response == null)
            {
                return NotFound();
            }
            return response;
        }
    }
}
