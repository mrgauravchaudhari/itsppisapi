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
    public class TagMasterController : ControllerBase
    {
        private readonly TagMasterRepository _repository;

        public TagMasterController(TagMasterRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("GetDeptList")]
        public async Task<ActionResult<List<TagMasterModel>>> GetDeptList()
        {
            return await _repository.getDeptList();
        }

        [HttpGet]
        public async Task<ActionResult<List<TagMasterModel>>> Get()
        {
            return await _repository.getData();
        }

        [HttpGet]
        [Route("PUS004")]
        public async Task<ActionResult<List<TagMasterPUS004>>> GetPUS004()
        {
            return await _repository.getDataPUS004();
        }

        [HttpPost]
        public async Task Post(TagMasterDto data)
        {
            await _repository.saveData(data);
        }
    }
}
