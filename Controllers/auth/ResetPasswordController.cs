using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using itsppisapi.Data;
using itsppisapi.Models;
using System.Net.Http;
using System.Net;
using itsppisapi.Dtos;

namespace itsppisapi.Controllers
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

        [HttpPut]
        public async Task<ActionResult<ResetPasswordModel>> Put(ResetPasswordDto data)
        {
            return await _repository.getData(data);
        }
    }
}
