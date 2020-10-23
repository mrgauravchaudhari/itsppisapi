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
	[Authorize(AuthenticationSchemes = "Bearer")]
	[Route("api/[controller]")]
	[ApiController]
	public class PLR001ReportController : ControllerBase
	{
		private readonly PLR001ReportRepository _repository;
		public PLR001ReportController(PLR001ReportRepository repository)
		{
			this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
		}

        [HttpGet("{TDATE}")]
        public async Task<ActionResult<List<PLR001ReportModel>>> Get(string TDATE)
        {
            return await _repository.getData(TDATE);
        }
	}
}
