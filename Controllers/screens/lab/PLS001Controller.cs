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
using Microsoft.AspNetCore.Authorization;

namespace cfclapi.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PLS001Controller : ControllerBase
    {
        private readonly PLS001Repository _repository;
        public PLS001Controller(PLS001Repository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
      
        [HttpPut("{L_DEPT_CODE}")]
        public async Task<ActionResult<IEnumerable<rec>>> Get(string L_DEPT_CODE)
        {
            IEnumerable<PLS001Model> tableData;
            IEnumerable<PLS001Model> tblData;
            List<rec> recList = new List<rec>();
            tableData = await _repository.getData(L_DEPT_CODE);
            tblData = await _repository.getData(L_DEPT_CODE);
            foreach (var tableItem in tableData)
            {
                var recListt = new rec
                {
                    L_REPORT_NAME = tableItem.L_REPORT_NAME,
                    L_REP_UNIT = tableItem.L_REP_UNIT,
                    L_REP_PRINT_SEQ = tableItem.L_REP_PRINT_SEQ,
                    L_REPORT_DESC = tableItem.L_REPORT_DESC,
                    L_ACTIVE_FLG = tableItem.L_ACTIVE_FLG,
                    DEPT_NAME = tableItem.DEPT_NAME,
                    L_TIME = tableData.Where(x => x.L_REP_PRINT_SEQ == tableItem.L_REP_PRINT_SEQ).Select(x => x.L_TIME).ToList(),
                    L_DEPT_CODE = tableItem.L_DEPT_CODE
                };
                recList.Add(recListt);
            }
            List<rec> rcList = recList.Distinct().ToList();
            return rcList.ToList();
        }

        [HttpGet]
        public async Task<ActionResult<List<PLS001Model>>> Get()
        {
            return await _repository.getDept();
        }
    }
}
