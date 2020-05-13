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
  public class GroupMasterController : ControllerBase
  {
    private readonly GroupMasterRepository _repository;
    public GroupMasterController(GroupMasterRepository repository)
    {
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    [HttpPut]
    //public async Task<ActionResult<GroupMasterModel>> Put(StringParameterDto data)
    //{
    //  return await _repository.getData(data.StringParameter);
    //}

    public async Task<ActionResult<IEnumerable<GroupMasterModel>>> Put(StringParameterDto data)
    {
      return await _repository.getData(data);
    }

    //POST api/GroupMaster
    [HttpPost]
    public async Task Post(GroupMasterSaveDto data)
    {
      await _repository.saveData(data);
    }

  }
}
