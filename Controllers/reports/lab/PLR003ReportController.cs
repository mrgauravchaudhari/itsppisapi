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
    public class PLR003ReportController : ControllerBase
    {
        private readonly PLR003ReportRepository _repository;
        public PLR003ReportController(PLR003ReportRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("{TDATE}")]
        public async Task<ActionResult<List<PLR003ReportModel>>> Get(string TDATE)
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
