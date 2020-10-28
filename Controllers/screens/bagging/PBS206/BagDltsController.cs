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
    public class BagDltsController : ControllerBase
    {
        private readonly BagDltsRepository _repository;

        public BagDltsController(BagDltsRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpPut]
        public async Task<ActionResult<BagDlts>> Put(threeParamDto data)
        {
            return await _repository.putData(data);
        }

        [HttpPost]
        public async Task Post(BagDltsSaveDto data)
        {
            await _repository.saveData(data);
        }
    }
}
