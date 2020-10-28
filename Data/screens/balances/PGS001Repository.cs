using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PGS001Repository
    {
        private readonly string _connectionString;
        public PGS001Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS001Model MapToValue(SqlDataReader reader)
        {
            return new PGS001Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A1_TRANS_DATE = reader["A1_TRANS_DATE"].ToString(),
                A1_UNIT_ID = reader["A1_UNIT_ID"].ToString(),
                A1_DATE_MOD = reader["A1_DATE_MOD"].ToString(),
                A1_USER_ID = (decimal)reader["A1_USER_ID"],
                A1_USER_NAME = reader["A1_USER_NAME"].ToString(),
                A1_NG_ALLOCATION = (decimal)reader["A1_NG_ALLOCATION"],
                A1_NG_RECPT = (decimal)reader["A1_NG_RECPT"],
                A1_NG_IMPORTF_UNIT2 = (decimal)reader["A1_NG_IMPORTF_UNIT2"],
                A1_NG_TOT_RECEIPT = (decimal)reader["A1_NG_TOT_RECEIPT"],
                A1_MEAS_NG_CONSP_FEED_REFMR = (decimal)reader["A1_MEAS_NG_CONSP_FEED_REFMR"],
                A1_NG_CONSP_FUEL_REFMR = (decimal)reader["A1_NG_CONSP_FUEL_REFMR"],
                A1_BAL_NG_CONSP_FEED_REFMR = (decimal)reader["A1_BAL_NG_CONSP_FEED_REFMR"],
                A1_NG_CONSP_FUEL_HEATER = (decimal)reader["A1_NG_CONSP_FUEL_HEATER"],
                A1_NG_CONSP_AMM = (decimal)reader["A1_NG_CONSP_AMM"],
                A1_NG_CONSP_UNIT2 = (decimal)reader["A1_NG_CONSP_UNIT2"],
                A1_NG_TOT_CONSP = (decimal)reader["A1_NG_TOT_CONSP"],
                A1_ACTL_NG_CV_NET = (decimal)reader["A1_ACTL_NG_CV_NET"],
                A1_NG_CONSP_AB1 = (decimal)reader["A1_NG_CONSP_AB1"],
                A1_NG_CONSP_AB2 = (decimal)reader["A1_NG_CONSP_AB2"],
                A1_NG_CONSP_AB = (decimal)reader["A1_NG_CONSP_AB"],
                A1_NG_CONSP_GT1 = (decimal)reader["A1_NG_CONSP_GT1"],
                A1_NG_CONSP_GT2 = (decimal)reader["A1_NG_CONSP_GT2"],
                A1_NG_CONSP_GT = (decimal)reader["A1_NG_CONSP_GT"],
                A1_NG_CONSP_HRSG1 = (decimal)reader["A1_NG_CONSP_HRSG1"],
                A1_NG_CONSP_HRSG2 = (decimal)reader["A1_NG_CONSP_HRSG2"],
                A1_NG_CONSP_HRSG = (decimal)reader["A1_NG_CONSP_HRSG"],
                A1_NG_CONSP_SPG = (decimal)reader["A1_NG_CONSP_SPG"]

            };
        }

        public async Task<PGS001Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM1_NG_BAL_PGS001", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS001Model response = null;
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
