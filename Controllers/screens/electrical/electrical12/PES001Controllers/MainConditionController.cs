using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers
{
  //[Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class MainConditionController : ControllerBase
  {
    private readonly MainConditionRepository _repository;

    public MainConditionController(MainConditionRepository repository)
    {
      this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    [HttpGet]
    public async Task<ActionResult<List<MainConditionModel>>> Get()
    {
      return await _repository.getData();
    }

    [HttpPost]
    public async Task Post(MainConditionDto data)
    {
      await _repository.saveData(data);
    }
  }
}
