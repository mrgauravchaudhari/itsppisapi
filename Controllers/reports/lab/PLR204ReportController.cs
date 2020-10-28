using itsppisapi.Data;
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
    public class PLR204ReportController : ControllerBase
    {
        private readonly PLR204ReportRepository _repository;

        public PLR204ReportController(PLR204ReportRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/PLR204Report/
        [HttpGet("{TDATE}")]
        public async Task<ActionResult<List<PLR204ReportModel>>> Get(string TDATE)
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
