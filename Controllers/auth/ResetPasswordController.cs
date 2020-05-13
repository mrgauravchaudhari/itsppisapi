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
using cfclapi.Dtos;

namespace cfclapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResetPasswordController : ControllerBase
    {
        private readonly ResetPasswordRepository _repository;

        public ResetPasswordController(ResetPasswordRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // [HttpPost("{username}/{temppwd}/{newpwd}")]
        // public async Task<ActionResult<ResetPasswordModel>> Put(ResetPasswordDto data)
        // {
        //     return await _repository.getData(data);
        // }

        [HttpPut]
        public async Task<ActionResult<ResetPasswordModel>> Put(ResetPasswordDto data)
        {
            return await _repository.getData(data);
        }
    }
}
