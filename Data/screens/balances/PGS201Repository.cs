using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PGS201Repository
    {
        private readonly string _connectionString;
        public PGS201Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS201Model MapToValue(SqlDataReader reader)
        {
            return new PGS201Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                AM2_TRANS_DATE = reader["AM2_TRANS_DATE"].ToString(),
                AM2_FW_CONSP_ACT = (decimal)reader["AM2_FW_CONSP_ACT"],
                AM2_FW_CONSP_UCT = (decimal)reader["AM2_FW_CONSP_UCT"],
                AM2_SW_CONSP = (decimal)reader["AM2_SW_CONSP"],
                AM2_DW_CONSP = (decimal)reader["AM2_DW_CONSP"],
                AM2_FIRE_CONSP = (decimal)reader["AM2_FIRE_CONSP"],
                AM2_FW_TOT_NON_PLT_CONSP = (decimal)reader["AM2_FW_TOT_NON_PLT_CONSP"],
                AM2_FW_TOT_CONSP = (decimal)reader["AM2_FW_TOT_CONSP"],
                AM2_PW_GPI_DRAW = (decimal)reader["AM2_PW_GPI_DRAW"],
                AM2_PW_CONSP_RGB = (decimal)reader["AM2_PW_CONSP_RGB"],
                AM2_PW_CONSP_DESPR_HTR = (decimal)reader["AM2_PW_CONSP_DESPR_HTR"],
                AM2_PW_TOT_CONSP_AM2 = (decimal)reader["AM2_PW_TOT_CONSP_AM2"],
                AM2_PW_CONSP_DESUP1 = (decimal)reader["AM2_PW_CONSP_DESUP1"],
                AM2_PW_CONSP_DESUP2 = (decimal)reader["AM2_PW_CONSP_DESUP2"],
                AM2_PW_CONSP_AB = (decimal)reader["AM2_PW_CONSP_AB"],
                AM2_PW_CONSP_UREA2 = (decimal)reader["AM2_PW_CONSP_UREA2"],
                AM2_PW_TOT_CONSP_GPII = (decimal)reader["AM2_PW_TOT_CONSP_GPII"],
                AM2_ATC = (decimal)reader["AM2_ATC"],
                AM2_UTC = (decimal)reader["AM2_UTC"],
                AM2_ACTTC = (decimal)reader["AM2_ACTTC"],
                AM2_UCTTC = (decimal)reader["AM2_UCTTC"],
                AM2_TOT_TC = (decimal)reader["AM2_TOT_TC"],
                AM2_USC = (decimal)reader["AM2_USC"],
                AM2_ASC = (decimal)reader["AM2_ASC"],
                AM2_TOT_SC = (decimal)reader["AM2_TOT_SC"],
                AM2_APC = (decimal)reader["AM2_APC"],
                AM2_UPC = (decimal)reader["AM2_UPC"],
                AM2_TOT_PC = (decimal)reader["AM2_TOT_PC"],
                AM2_TOT_COND_TO_GPI = (decimal)reader["AM2_TOT_COND_TO_GPI"],
                AM2_DW_MAKEUP_GPII = (decimal)reader["AM2_DW_MAKEUP_GPII"],
                AM2_REGEN_LOSS = (decimal)reader["AM2_REGEN_LOSS"]
            };
        }

        public async Task<PGS201Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_WATER_BAL_PGS201", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS201Model response = null;
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
