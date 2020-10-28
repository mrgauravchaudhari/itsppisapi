using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

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
