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
			if(response == null) { return NotFound();}
			return response;
		}
	}
}
