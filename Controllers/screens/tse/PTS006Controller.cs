using itsppisapi.Data;
using itsppisapi.Models;
using itsppisapi.SaveDtos;
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
    public class PTS006Controller : ControllerBase
    {
        private readonly PTS006Repository _repository;

        public PTS006Controller(PTS006Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        [Route("GETLIST")]
        public async Task<ActionResult<List<PTSListModel>>> Get()
        {
            return await _repository.getList();
        }

        [HttpPut]
        public async Task<ActionResult<PTS006Model>> Put(TSEParmDto data)
        {
            return await _repository.putData(data.T_YEAR, data.T_MONTH, data.T_VERSION, data.Btn);
        }

        [HttpPost]
        public async Task Post(PTS006SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
