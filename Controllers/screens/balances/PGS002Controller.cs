using System;
using System.Threading.Tasks;
using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace itsppisapi.Controllers {
    [Authorize (AuthenticationSchemes = "Bearer")]
    [Route ("api/[controller]")]
    [ApiController]
    public class PGS002Controller : ControllerBase {
        private readonly PGS002Repository _repository;

        public PGS002Controller (PGS002Repository repository) {
            this._repository = repository ??
                throw new ArgumentNullException (nameof (repository));
        }

        [HttpPut]
        public async Task<ActionResult<PGS002Model>> Put (TriParamDto data) {
            return await _repository.putData(data);
        }
    }
}