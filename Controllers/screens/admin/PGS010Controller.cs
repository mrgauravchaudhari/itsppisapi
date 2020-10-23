using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using itsppisapi.Data;
using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace itsppisapi.Controllers {
    [Authorize (AuthenticationSchemes = "Bearer")]
    [Route ("api/[controller]")]
    [ApiController]
    public class PGS010Controller : ControllerBase {
        private readonly PGS010Repository _repository;

        public PGS010Controller (PGS010Repository repository) {
            _repository = repository ??
                throw new ArgumentNullException (nameof (repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PGS010Model>>> Get () {
            return await _repository.getData ();
        }

        //POST api/PGS010
        [HttpPost]
        public async Task<IActionResult> Post (PGS010SaveDto data) {
            if (data.USER_ID == 0) {
                if (await _repository.UserExists (data.USER_NAME)) {
                    return BadRequest ("UserName already Exists.");
                } else if (await _repository.UserEPRNOExists (data.USER_EPR_NO)) {
                    return BadRequest ("EprNo already Exists.");
                } else {
                    await _repository.saveData (data);
                    return StatusCode (200);
                }
            } else {
                await _repository.saveData (data);
                return StatusCode (200);
            }
        }
    }
}