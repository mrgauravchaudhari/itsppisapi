using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Models;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PGS205Repository
    {
        private readonly string _connectionString;
        public PGS205Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS205Model MapToValue(SqlDataReader reader)
        {
            return new PGS205Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                AM2_TRANS_DATE = reader["AM2_TRANS_DATE"].ToString(),
                AM2_AMM_PROD = (decimal)reader["AM2_AMM_PROD"],
                AM2A_VPR2_TO_AMM2 = (decimal)reader["AM2A_VPR2_TO_AMM2"],
                AM2_TOT_HOT_VAPOR = (decimal)reader["AM2_TOT_HOT_VAPOR"],
                AM2_COLD_AMM_TO_STORAGE = (decimal)reader["AM2_COLD_AMM_TO_STORAGE"],
                AM2_AMM_SUPP_UREA2 = (decimal)reader["AM2_AMM_SUPP_UREA2"],
                AM2_TOT_COLD_HOT = (decimal)reader["AM2_TOT_COLD_HOT"],
                AM2_OPENING_STOCK = (dynamic)reader["AM2_OPENING_STOCK"],
                AM2_LOGICAL_STOCK = (dynamic)reader["AM2_LOGICAL_STOCK"],
                AM2_AMM_SALE = (decimal)reader["AM2_AMM_SALE"],
                AM2_RECD_AMM_STORAGE = (decimal)reader["AM2_RECD_AMM_STORAGE"],
                AM2_TFR_AMM_STORAGE = (decimal)reader["AM2_TFR_AMM_STORAGE"],
                AM2_SILO_OPENING_STOCK = (dynamic)reader["AM2_SILO_OPENING_STOCK"],
                AM2_BAGGED_OPENING_STOCK = (dynamic)reader["AM2_BAGGED_OPENING_STOCK"],
                AM2_TOTAL_STOCK_SILO_BAGG = (dynamic)reader["AM2_TOTAL_STOCK_SILO_BAGG"],
                AM2_TRAINA_PROD = (decimal)reader["AM2_TRAINA_PROD"],
                AM2_TRAINB_PROD = (decimal)reader["AM2_TRAINB_PROD"],
                AM2_TOT_TRAINA_TRAINB_PROD = (decimal)reader["AM2_TOT_TRAINA_TRAINB_PROD"],
                AM2_DESP_RAIL = (decimal)reader["AM2_DESP_RAIL"],
                AM2_DESP_ROAD = (decimal)reader["AM2_DESP_ROAD"],
                AM2_RAIL_ROAD = (decimal)reader["AM2_RAIL_ROAD"],
                AM2_SIOL_CL_STK = (dynamic)reader["AM2_SIOL_CL_STK"],
                AM2_BAGG_CL_STK = (dynamic)reader["AM2_BAGG_CL_STK"],
                AM2_TOTAL_CL_BAG_SILO_STK = (dynamic)reader["AM2_TOTAL_CL_BAG_SILO_STK"]
            };
        }

        public async Task<PGS205Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AMM2_UREA2_BAL_PGS205", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS205Model response = null;
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
