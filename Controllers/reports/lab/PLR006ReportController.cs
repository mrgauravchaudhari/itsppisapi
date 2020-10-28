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
    public class PLR006ReportController : ControllerBase
    {
        private readonly PLR006ReportRepository _repository;

        public PLR006ReportController(PLR006ReportRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/PLR006Report/
        [HttpGet("{TDATE}")]
        public async Task<ActionResult<List<PLR006ReportModel>>> Get(string TDATE)
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
