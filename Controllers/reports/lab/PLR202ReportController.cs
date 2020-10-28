using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PLR202ReportController : ControllerBase
    {
        private readonly PLR202ReportRepository _repository;

        public PLR202ReportController(PLR202ReportRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/PLR002Report/
        [HttpGet("{TDATE}")]
        public async Task<ActionResult<PLR202ReportModel>> Get(string TDATE)
        {
            var response = await _repository.GetById(TDATE);
            if (response == null) { return NotFound(); }
            return response;
        }
    }
}
