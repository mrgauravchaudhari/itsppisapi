using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;

namespace cfclapi.Controllers.ledgers.electrical
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]

    public class PER002Controller : ControllerBase
    {
        private string _connectionString;

        private readonly itsppisapi.Models.DataContext _context;
        public PER002Controller(itsppisapi.Models.DataContext context)
        {
            _context = context;

        }

        [HttpGet("{mnth}")]
        public async Task<DataTable> get(string mnth)
        {
            try
            {
               string strqry = "ppis.PPU_P_EL1_ML_ELECT_DTL";

                _connectionString = _context.Database.GetDbConnection().ConnectionString.ToString();

                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strqry, sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_MNTH", mnth));

                        await sql.OpenAsync();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        return dt;

                    }
                }
            }
            catch (Exception ex)
            {
                // DataTable dt = new DataTable(ex.Message.ToString());
                DataSet ds = new DataSet(ex.Message.ToString());
                DataTable dt = new DataTable();
                ds.AcceptChanges();
                return dt;
            }
        }
    }

}