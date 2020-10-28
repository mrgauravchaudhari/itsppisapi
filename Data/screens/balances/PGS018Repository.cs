using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PGS018Repository
    {
        private readonly string _connectionString;
        public PGS018Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS018Model MapToValue(SqlDataReader reader)
        {
            return new PGS018Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A1_TRANS_DATE = reader["A1_TRANS_DATE"].ToString(),
                A1_UNIT_ID = reader["A1_UNIT_ID"].ToString(),
                TXT_AMM_OP = (decimal)reader["TXT_AMM_OP"],
                A1_AMM_PROD = (decimal)reader["A1_AMM_PROD"],
                A1_AMM_STOCK = (decimal)reader["A1_AMM_STOCK"],
                A1_AMM_SUPP_UREA = (decimal)reader["A1_AMM_SUPP_UREA"],
                A1_AMM_IMPORTF_UNIT2 = (decimal)reader["A1_AMM_IMPORTF_UNIT2"],
                TXT_AMM_PROD = (decimal)reader["TXT_AMM_PROD"],
                A1_AMM_SUPP_UNIT2 = (decimal)reader["A1_AMM_SUPP_UNIT2"],
                A1_AMM_SALE = (decimal)reader["A1_AMM_SALE"],
                TXT_AMM_CONSP = (decimal)reader["TXT_AMM_CONSP"],
                TXT_BULK_OP = (decimal)reader["TXT_BULK_OP"],
                TXT_BAGG_OP = (decimal)reader["TXT_BAGG_OP"],
                TXT_TOTAL_OP = (decimal)reader["TXT_TOTAL_OP"],
                U1_U11_UREA_PROD = (decimal)reader["U1_U11_UREA_PROD"],
                U1_U21_UREA_PROD = (decimal)reader["U1_U21_UREA_PROD"],
                U1_TOT_UREA_PROD = (decimal)reader["U1_TOT_UREA_PROD"],
                TXT_PROD = (decimal)reader["TXT_PROD"],
                B_DESP_RAIL = (decimal)reader["B_DESP_RAIL"],
                B_DESP_ROAD = (decimal)reader["B_DESP_ROAD"],
                B_DESP_TOTAL = (decimal)reader["B_DESP_TOTAL"],
                B_TOTAL_BAGG_QTY = (decimal)reader["B_TOTAL_BAGG_QTY"],
                B_TOTAL_BAGG_STOCK = (decimal)reader["B_TOTAL_BAGG_STOCK"],
                B_UREA_RECD_MKTG = (decimal)reader["B_UREA_RECD_MKTG"],
                B_BULK_STOCK = (decimal)reader["B_BULK_STOCK"],
                B_TOTAL_STOCK = (decimal)reader["B_TOTAL_STOCK"]
            };
        }

        public async Task<PGS018Model> putData(StringParamWbtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM1_AMM_UREA_BAL_PGS018", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS018Model response = null;
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
