using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using itsppisapi.Dtos;

namespace itsppisapi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class FuncNcvOnuNgController : ControllerBase
    {
        private readonly FuncNcvOnuNgRepository _repository;

        public FuncNcvOnuNgController(FuncNcvOnuNgRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<FuncNcvOnuNgModel>> Put(FuncNcvOnuNgParamDto data)
        {
            return await _repository.putData(data);
        }
    }
}
