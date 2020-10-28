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
