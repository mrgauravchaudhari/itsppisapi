using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cfclapi.Data;
using cfclapi.Models;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using cfclapi.Dtos;

namespace cfclapi.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class ModuleMasterController : ControllerBase
  {
    private readonly ModuleMasterRepository _repository;
    public ModuleMasterController(ModuleMasterRepository repository)
    {
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    [HttpPut]
    public async Task<ActionResult<ModuleMasterModel>> Put(StringParameterDto data)
    {
      return await _repository.getData(data.StringParameter);
    }

    // public async Task<ActionResult<IEnumerable<ModuleMasterModel>>> Put(TdateQueryModel data)
    // {
    //     return await _repository.getData(data.TDATE);
    // }

    //POST api/ModuleMaster
    [HttpPost]
    public async Task Post(ModuleMasterSaveDto data)
    {
      await _repository.saveData(data);
    }

  }
}
