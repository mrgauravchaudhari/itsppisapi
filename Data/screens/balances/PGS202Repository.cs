using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Models;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PGS202Repository
    {
        private readonly string _connectionString;
        public PGS202Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS202Model MapToValue(SqlDataReader reader)
        {
            return new PGS202Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                AM2_TRANS_DATE = reader["AM2_TRANS_DATE"].ToString(),
                AM2_NG_GAIL_RECPT = (decimal)reader["AM2_NG_GAIL_RECPT"],
                AM2_NG_CONSP_FEED_AMM2 = (decimal)reader["AM2_NG_CONSP_FEED_AMM2"],
                AM2_NG_FUEL_ABURNER = (decimal)reader["AM2_NG_FUEL_ABURNER"],
                AM2_NG_FUEL_TBURNER = (decimal)reader["AM2_NG_FUEL_TBURNER"],
                AM2_NG_FUEL_BA101 = (decimal)reader["AM2_NG_FUEL_BA101"],
                AM2_NG_FUEL_BA102 = (decimal)reader["AM2_NG_FUEL_BA102"],
                AM2_BAL_NG_FUEL_SH_BURNER = (decimal)reader["AM2_BAL_NG_FUEL_SH_BURNER"],
                AM2_BAL_NG_TOT_CONSP_AMM2 = (decimal)reader["AM2_BAL_NG_TOT_CONSP_AMM2"],
                AM2_NG_CONSP_AB = (decimal)reader["AM2_NG_CONSP_AB"],
                AM2_NG_CONSP_AB_AMM2 = (decimal)reader["AM2_NG_CONSP_AB_AMM2"],
                AM2_TOT_CONSP_NG_FUEL = (decimal)reader["AM2_TOT_CONSP_NG_FUEL"],
                AM2_NG_FUEL_FLARE = (decimal)reader["AM2_NG_FUEL_FLARE"]
            };
        }

        public async Task<PGS202Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_NG_BAL_PGS202", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS202Model response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue(reader);
                        }
                    }
                    return response;
                }
            }
        }
    }
}
