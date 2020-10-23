using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace itsppisapi.Controllers.global
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class ListLabReportController : ControllerBase
    {
        private readonly string _connectionString;

        public ListLabReportController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        [HttpGet]
        public async Task<DataSet> get()
        {
            try
            {
                string paramVal = "ALL";

                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB1_GET_PPM_LB_REPORT_SAMPLES", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@L_REPORT_ID", paramVal));
                        await sql.OpenAsync();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        DataSet ds1 = new DataSet();
                        DataSet ds2 = new DataSet();
                        da.Fill(ds);                        

                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                DataSet ds = new DataSet(ex.Message.ToString());
                return ds;
            }
        }



    }
}