using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    // [Authorize]
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
			if(response == null) { return NotFound();
		}
			return response;
		}
	}
}
