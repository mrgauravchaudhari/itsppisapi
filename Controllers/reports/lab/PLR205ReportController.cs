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
