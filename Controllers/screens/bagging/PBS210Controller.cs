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
    public class PBS210Controller : ControllerBase
    {
        private readonly PBS210Repository _repository;

        public PBS210Controller(PBS210Repository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<PBS210Model>> Put([FromBody] TransactionDateBtnDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(PBS210SaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
