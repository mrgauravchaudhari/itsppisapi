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
			if(response == null) { return NotFound();}
			return response;
		}
	}
}
