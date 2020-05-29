using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CommunicationController : ControllerBase
    {
        private readonly CommunicationRepository _repository;

        public CommunicationController(CommunicationRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<List<CommunicationModel>>> Get()
        {
            return await _repository.getData();
        }

        [HttpPost]
        public async Task Post(CommunicationDto data)
        {
            await _repository.saveData(data);
        }
    }
}
