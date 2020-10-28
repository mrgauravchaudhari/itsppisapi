using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PGS002Repository
    {
        private readonly string _connectionString;
        public PGS002Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS002Model MapToValue(SqlDataReader reader)
        {
            return new PGS002Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),
                OU1_NAP_IMPORTF_UNIT2 = (decimal)reader["OU1_NAP_IMPORTF_UNIT2"],
                OU1_NAP_TOT_RECEIPT = (decimal)reader["OU1_NAP_TOT_RECEIPT"],
                OU1_NAP_CONSP_AB1 = (decimal)reader["OU1_NAP_CONSP_AB1"],
                OU1_NAP_CONSP_AB2 = (decimal)reader["OU1_NAP_CONSP_AB2"],
                OU1_NAP_CONSP_GT1 = (decimal)reader["OU1_NAP_CONSP_GT1"],
                OU1_NAP_CONSP_GT2 = (decimal)reader["OU1_NAP_CONSP_GT2"],
                OU1_NAP_CONSP_AB = (decimal)reader["OU1_NAP_CONSP_AB"],
                OU1_NAP_CONSP_GT = (decimal)reader["OU1_NAP_CONSP_GT"],
                OU1_NAP_CONSP_SPG = (decimal)reader["OU1_NAP_CONSP_SPG"],
                OU1_NAP_CONSP_UNIT2 = (decimal)reader["OU1_NAP_CONSP_UNIT2"],
                OU1_NAP_CONSP_TOTAL = (decimal)reader["OU1_NAP_CONSP_TOTAL"],
                OU1_NAP_NET_CV = (decimal)reader["OU1_NAP_NET_CV"],
                OU1_DAYTANK_MEAS_STOCK = (decimal)reader["OU1_DAYTANK_MEAS_STOCK"],
                OU1_DAYTANK_CALC_STOCK = (decimal)reader["OU1_DAYTANK_CALC_STOCK"],
                OU1_NAP_STOCK = (decimal)reader["OU1_NAP_STOCK"],
                OU1_NAP_CONSP_AMM_REFMR = (decimal)reader["OU1_NAP_CONSP_AMM_REFMR"],
                OU1_NAP_CONSP_AMM_HEATER = (decimal)reader["OU1_NAP_CONSP_AMM_HEATER"],
                OU1_NAP_CONSP_AMM = (decimal)reader["OU1_NAP_CONSP_AMM"],
                OP_STOCK = (decimal)reader["OP_STOCK"],
                OP_STOCK_GPII = (decimal)reader["OP_STOCK_GPII"],
                OP_STOCK_TOTAL = (decimal)reader["OP_STOCK_TOTAL"],
                NAP_RECEIPT = (decimal)reader["NAP_RECEIPT"],
                NAP_RECEIPT_GPII = (decimal)reader["NAP_RECEIPT_GPII"],
                NAP_RECEIPT_TOTAL = (decimal)reader["NAP_RECEIPT_TOTAL"],
                OU1_NAP_STOCK_GPII = (decimal)reader["OU1_NAP_STOCK_GPII"],
                OU1_NAP_TOT_STOCK = (decimal)reader["OU1_NAP_TOT_STOCK"]
            };
        }

        public async Task<PGS002Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_NAP_BAL_PGS002", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS002Model response = null;
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
