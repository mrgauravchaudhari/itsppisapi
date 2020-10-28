using itsppisapi.Data;
using itsppisapi.Dtos;
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
    public class FormAccessController : ControllerBase
    {
        private readonly FormAccessRepository _repository;

        public FormAccessController(FormAccessRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        [Route("AccessForMaster")]
        public async Task<ActionResult<FormAccessModel>> Put(FormAccessParamDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPut]
        [Route("AccessForTransaction")]
        public async Task<ActionResult<FormAccessModel>> Put2(FormAccessParamDto data)
        {
            return await _repository.putData2(data);
        }
    }
}