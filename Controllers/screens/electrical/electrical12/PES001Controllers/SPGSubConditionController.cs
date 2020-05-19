using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;

namespace itsppisapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SPGSubConditionController : ControllerBase
  {
    private readonly SPGSubConditionRepository _repository;

    public SPGSubConditionController(SPGSubConditionRepository repository)
    {
      this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    [HttpGet("GetCondList")]
    public async Task<ActionResult<List<SPGSubConditionModel>>> Get()
    {
      return await _repository.getCondList();
    }

    [HttpGet("getData")]
    public async Task<ActionResult<List<SPGSubConditionModel>>> get()
    {
      return await _repository.getData();
    }

    [HttpPost]
    public async Task Post(SPGSubConditionDto data)
    {
      await _repository.saveData(data);
    }

    [HttpGet("GetSubCondList")]
    public async Task<ActionResult<List<SPGSubConditionModel>>> GetSubCond()
    {
      return await _repository.getSubCondList();
    }
  }
}
