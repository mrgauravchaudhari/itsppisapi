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
    public class PLR201ReportController : ControllerBase
    {
        private readonly PLR201ReportRepository _repository;

        public PLR201ReportController(PLR201ReportRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/PLR002Report/
        [HttpGet("{TDATE}")]
        public async Task<ActionResult<PLR201ReportModel>> Get(string TDATE)
        {
            var response = await _repository.GetById(TDATE);
            if (response == null) { return NotFound(); }
            return response;
        }
    }
}
