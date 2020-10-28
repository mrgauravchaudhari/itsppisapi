using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Threading.Tasks;

namespace cfclapi.Controllers.ledgers.electrical
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]

    public class PBR225AController : ControllerBase
    {
        private string _connectionString;

        private readonly itsppisapi.Models.DataContext _context;
        public PBR225AController(itsppisapi.Models.DataContext context)
        {
            _context = context;
        }

        [HttpGet("{FDATE}/{TO_DATE}/{unit_id}/{contr_code}")]
        public async Task<DataSet> get(string FDATE, string TO_DATE, string unit_id, string contr_code)
        {
            try
            {
                string strqry = "[PPIS].[PPU_P_BG_MR_COMBINED_RACK_LOAD_PBR225A]";

                _connectionString = _context.Database.GetDbConnection().ConnectionString.ToString();

                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strqry, sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_FDATE", FDATE));
                        cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", TO_DATE));
                        cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", unit_id));
                        cmd.Parameters.Add(new SqlParameter("@IN_CONTR_CODE", contr_code));
                        await sql.OpenAsync();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                DataSet ds = new DataSet(ex.Message.ToString());
                ds.AcceptChanges();
                return ds;
            }
        }
    }

}