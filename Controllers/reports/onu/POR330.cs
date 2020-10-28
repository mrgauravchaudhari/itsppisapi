using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace cfclapi.Controllers.ledgers.electrical
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class POR330Controller : ControllerBase
    {
        private string _connectionString;

        private readonly itsppisapi.Models.DataContext _context;
        public POR330Controller(itsppisapi.Models.DataContext context)
        {
            _context = context;
        }

        [HttpGet("{month}")]
        public async Task<DataSet> get(string month)
        {
            try
            {
                string strqry = "PPIS.PPU_P_OU3_DR_REC_CONSP_NG_CONSUM_POR330";

                _connectionString = _context.Database.GetDbConnection().ConnectionString.ToString();

                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strqry, sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_DT", month));
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