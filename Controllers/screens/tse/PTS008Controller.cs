using itsppisapi.Data;
using itsppisapi.Models;
using itsppisapi.SaveDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class PTS008Controller : ControllerBase
    {
        private readonly PTS008Repository _repository;

        public PTS008Controller(PTS008Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PTS008Model>> Put(TSEParmDto data)
        {
            return await _repository.putData(data.T_YEAR, data.T_MONTH, data.T_VERSION, data.Btn);
        }

        [HttpPut]
        [Route("GETDV")]
        public async Task<ActionResult<PTS008DVModel>> PutDV(PTS008DVParmDto data)
        {
            return await _repository.getDV2(data.in_water_type, data.IN_MONTH, data.IN_YEAR);
        }

        [HttpPost]
        public async Task Post(PTS008SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
