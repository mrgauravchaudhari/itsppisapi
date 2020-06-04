using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace cfclapi.Controllers.ledgers.electrical
{
    [Route("api/[controller]")]
    [ApiController]

    public class PER001Controller : ControllerBase
    {
        private string _connectionString;

        private readonly itsppisapi.Models.DataContext _context;
        public PER001Controller(itsppisapi.Models.DataContext context)
        {
            _context = context;

        }

        [HttpGet("{Date}/{Id}")]
        public async Task<DataSet> get(string Date, string Id)
        {
            try
            {
               string strqry = "PPIS.PPU_P_EL1_GET_PER001";

                _connectionString = _context.Database.GetDbConnection().ConnectionString.ToString();

                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strqry, sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_DATE", Date));
                        cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", Id));

                        await sql.OpenAsync();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        // DataTable dt = new DataTable();
                        da.Fill(ds);

                        return ds;

                    }
                }
            }
            catch (Exception ex)
            {
                // DataTable dt = new DataTable(ex.Message.ToString());
                DataSet ds = new DataSet(ex.Message.ToString());
                // DataTable dt = new DataTable();
                ds.AcceptChanges();
                return ds;
            }
        }
    }

}