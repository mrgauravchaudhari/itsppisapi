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
    public class PAS215Controller : ControllerBase
    {
        private readonly PAS215Repository _repository;

        public PAS215Controller(PAS215Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PAS215Model>> Put([FromBody] StringParamWbtnDto data)
        {
            return await _repository.putData(data.StringParameter, data.Btn);
        }


        [HttpPut]
        [Route("GetTags")]
        public async Task<ActionResult<IEnumerable<ListTagNoModel>>> PutTagNo(StringParameterDto data)
        {
            return await _repository.getTagNo(data.StringParameter);
        }

        [HttpPost]
        public async Task Post(PAS215SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
