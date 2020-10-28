using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PLS203Repository
    {
        private readonly string _connectionString;
        public PLS203Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS203Model MapToValue(SqlDataReader reader)
        {
            return new PLS203Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                L_TRANS_DATE = reader["L_TRANS_DATE"].ToString(),
                L_TIME = reader["L_TIME"].ToString(),
                L_TEMP = reader["L_TEMP"].ToString(),
                L_SHIFT = reader["L_SHIFT"].ToString(),
                L_DENSITY = reader["L_DENSITY"].ToString(),
                L_DENSITY_15C = reader["L_DENSITY_15C"].ToString(),
                L_BR_NO = reader["L_BR_NO"].ToString(),
                L_OLEFINES = reader["L_OLEFINES"].ToString(),
                L_AROMATICS = reader["L_AROMATICS"].ToString(),
                L_IBP = reader["L_IBP"].ToString(),
                L_SULPHUR = reader["L_SULPHUR"].ToString(),
                L_SULPHUR_OUTLET = reader["L_SULPHUR_OUTLET"].ToString()
            };
        }

        public async Task<List<PLS203Model>> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB2_GET_PPT_LB_NAP_SNDT_ANALYSIS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    var response = new List<PLS203Model>();
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
