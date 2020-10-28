using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PGS203Repository
    {
        private readonly string _connectionString;
        public PGS203Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS203Model MapToValue(SqlDataReader reader)
        {
            return new PGS203Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                AM2_TRANS_DATE = reader["AM2_TRANS_DATE"].ToString(),
                AM2_BAL_NAP_TFRT_DAYTANK = (decimal)reader["AM2_BAL_NAP_TFRT_DAYTANK"],
                AM2_DAY_TANK_OP_STK = (dynamic)reader["AM2_DAY_TANK_OP_STK"],
                AM2_DAY_TANK_CL = (decimal)reader["AM2_DAY_TANK_CL"],
                AM2_NAP_CONSP_HYD_FURN = (decimal)reader["AM2_NAP_CONSP_HYD_FURN"],
                AM2_NAP_CONSP_DESUL_FURN = (decimal)reader["AM2_NAP_CONSP_DESUL_FURN"],
                AM2_NAP_CONSP_TUNNEL_BURNER = (decimal)reader["AM2_NAP_CONSP_TUNNEL_BURNER"],
                AM2_NAP_CONSP_ARCH_BURNER = (decimal)reader["AM2_NAP_CONSP_ARCH_BURNER"],
                AM2_NAP_CONSP_SHEATER_BURNER = (decimal)reader["AM2_NAP_CONSP_SHEATER_BURNER"],
                AM2_TOT_FUELNAP_TO_AMM2 = (decimal)reader["AM2_TOT_FUELNAP_TO_AMM2"],
                AM2_NAP_CONSP_AB = (decimal)reader["AM2_NAP_CONSP_AB"],
                AM2_TOT_FUEL_GP2 = (decimal)reader["AM2_TOT_FUEL_GP2"],
                AM2_NAP_CONSP_HDS = (decimal)reader["AM2_NAP_CONSP_HDS"],
                AM2_TOT_NAP_CONSP_GP2 = (decimal)reader["AM2_TOT_NAP_CONSP_GP2"],
                AM2_SNAP_PROD = (decimal)reader["AM2_SNAP_PROD"],
                AM2_SNDT_OP_STK = (decimal)reader["AM2_SNDT_OP_STK"],
                AM2_SNDT_STOCK = (decimal)reader["AM2_SNDT_STOCK"],
                AM2_SNT_RECPT = (decimal)reader["AM2_SNT_RECPT"],
                AM2_SNT_TFR = (decimal)reader["AM2_SNT_TFR"],
                AM2_BAL_SNAP_CONSP_PREF = (decimal)reader["AM2_BAL_SNAP_CONSP_PREF"],
                AM2_NAP_AVAIL_CONSP = (decimal)reader["AM2_NAP_AVAIL_CONSP"]
            };
        }

        public async Task<PGS203Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_NAP_BAL_PGS203", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS203Model response = null;
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
