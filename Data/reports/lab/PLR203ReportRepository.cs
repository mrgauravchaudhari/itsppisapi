
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace itsppisapi.Data
{
    public class PLR203ReportRepository
    {
        private readonly string _connectionString;
        public PLR203ReportRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLR203ReportModel MapToValue(SqlDataReader reader)
        {
            return new PLR203ReportModel()
            {
                TRANS_DATE = reader["TRANS_DATE"].ToString(),
                SHIFT = reader["SHIFT"].ToString(),
                L_TIME = reader["L_TIME"].ToString(),
                L_TEMP = reader["L_TEMP"].ToString(),
                DENSITY = reader["DENSITY"].ToString(),
                DENS_15C = reader["DENS_15C"].ToString(),
                BR_NO = reader["BR_NO"].ToString(),
                OLEFINES = reader["OLEFINES"].ToString(),
                AROMATICS = reader["AROMATICS"].ToString(),
                IBP = reader["IBP"].ToString(),
                IN_Sulpher = reader["IN_Sulpher"].ToString(),
                OUT_Sulpher = reader["OUT_Sulpher"].ToString()
            };
        }

        public async Task<List<PLR203ReportModel>> GetById(string IN_DATE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB_SWEET_NAP_DTANK_ANALS_D_RPT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DT", IN_DATE));
                    var response = new List<PLR203ReportModel>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue(reader));
                        }
                    }
                    return response;
                }
            }
        }
    }
}
