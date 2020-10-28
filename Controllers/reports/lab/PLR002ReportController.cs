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
    public class PLR002ReportController : ControllerBase
    {
        private readonly PLR002ReportRepository _repository;
        public PLR002ReportController(PLR002ReportRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/PLR002Report/
        [HttpGet("{TDATE}")]
        public async Task<ActionResult<PLR002ReportModel>> Get(string TDATE)
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
