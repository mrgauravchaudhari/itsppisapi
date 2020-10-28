using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PLS005Repository
    {
        private readonly string _connectionString;
        public PLS005Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS005Model MapToValue(SqlDataReader reader)
        {
            return new PLS005Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                USERNAME = reader["USERNAME"].ToString(),

                L_TRANS_DATE = reader["L_TRANS_DATE"].ToString(),
                L_TIME = reader["L_TIME"].ToString(),
                L_UNIT_ID = reader["L_UNIT_ID"].ToString(),
                L_USER_ID = (decimal)reader["L_USER_ID"],
                L_DATE_MOD = reader["L_DATE_MOD"].ToString(),

                L_N2 = (decimal)reader["L_N2"],
                L_CH4 = (decimal)reader["L_CH4"],
                L_C2H6 = (decimal)reader["L_C2H6"],
                L_CO2 = (decimal)reader["L_CO2"],
                L_C3H8 = (decimal)reader["L_C3H8"],
                L_NC4H10 = (decimal)reader["L_NC4H10"],
                L_IC4H10 = (decimal)reader["L_IC4H10"],
                L_NG_GROSS_CV = (decimal)reader["L_NG_GROSS_CV"],
                L_NG_NET_CV = (decimal)reader["L_NG_NET_CV"],
                L_H2S = reader["L_H2S"].ToString(),
                L_ZNO_BED = reader["L_ZNO_BED"].ToString(),
                L_MOL_WT = (decimal)reader["L_MOL_WT"],
                L_FREEZE_FLG = reader["L_FREEZE_FLG"].ToString(),
                L_FREEZE_TIME = reader["L_FREEZE_TIME"].ToString(),
                L_PLANT_ID = reader["L_PLANT_ID"].ToString(),
            };
        }
        public async Task<List<PLS005Model>> getData(threeParamDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB_GET_PPT_LB_AMM_NATURAL_GAS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", data.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", data.UnitId));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", data.Btn));
                    var response = new List<PLS005Model>();
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

        public async Task saveData(PLS005SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB_SAVE_PPT_LB_AMM_NATURAL_GAS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TRANS_DATE", value.L_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_TIME", value.L_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_UNIT_ID", value.L_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_USER_ID", value.L_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_DATE_MOD", value.L_DATE_MOD));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_N2", value.L_N2));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_CH4", value.L_CH4));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_C2H6", value.L_C2H6));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_CO2", value.L_CO2));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_C3H8", value.L_C3H8));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_NC4H10", value.L_NC4H10));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_IC4H10", value.L_IC4H10));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_NG_GROSS_CV", value.L_NG_GROSS_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_NG_NET_CV", value.L_NG_NET_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_H2S", value.L_H2S));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_ZNO_BED", value.L_ZNO_BED));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_MOL_WT", value.L_MOL_WT));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_FREEZE_FLG", value.L_FREEZE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_FREEZE_TIME", value.L_FREEZE_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_L_PLANT_ID", value.L_PLANT_ID));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

    }
}
