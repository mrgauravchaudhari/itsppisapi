using itsppisapi.Data;
using itsppisapi.Dtos;
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
    public class TripMasterController : ControllerBase
    {
        private readonly TripMasterRepository _repository;

        public TripMasterController(TripMasterRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<List<TripMasterModel>>> Get()
        {
            return await _repository.getData();
        }

        [HttpPost]
        public async Task Post(TripMasterDto data)
        {
            await _repository.saveData(data);
        }
    }
}
