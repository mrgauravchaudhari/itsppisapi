using Microsoft.Extensions.Configuration;
using cfclapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using cfclapi.Dtos;

namespace cfclapi.Data
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
                // GP-I Fields
                mindt = reader["mindt"].ToString(),
                maxdt = reader["maxdt"].ToString(),

                GP1_L_TRANS_DATE = reader["GP1_L_TRANS_DATE"].ToString(),
                GP1_L_TIME = reader["GP1_L_TIME"].ToString(),
                GP1_L_UNIT_ID = reader["GP1_L_UNIT_ID"].ToString(),
                GP1_L_USER_ID = (decimal)reader["GP1_L_USER_ID"],
                USERNAME = reader["USERNAME"].ToString(),
                GP1_L_DATE_MOD = reader["GP1_L_DATE_MOD"].ToString(),
                GP1_L_N2 = (decimal)reader["GP1_L_N2"],
                GP1_L_CH4 = (decimal)reader["GP1_L_CH4"],
                GP1_L_C2H6 = (decimal)reader["GP1_L_C2H6"],
                GP1_L_CO2 = (decimal)reader["GP1_L_CO2"],
                GP1_L_C3H8 = (decimal)reader["GP1_L_C3H8"],
                GP1_L_NC4H10 = (decimal)reader["GP1_L_NC4H10"],
                GP1_L_IC4H10 = (decimal)reader["GP1_L_IC4H10"],
                GP1_L_NG_GROSS_CV = (decimal)reader["GP1_L_NG_GROSS_CV"],
                GP1_L_NG_NET_CV = (decimal)reader["GP1_L_NG_NET_CV"],
                GP1_L_H2S = reader["GP1_L_H2S"].ToString(),
                GP1_L_ZNO_BED = reader["GP1_L_ZNO_BED"].ToString(),
                GP1_L_MOL_WT = (decimal)reader["GP1_L_MOL_WT"],
                GP1_L_FREEZE_FLG = reader["GP1_L_FREEZE_FLG"].ToString(),
                GP1_L_FREEZE_TIME = reader["GP1_L_FREEZE_TIME"].ToString(),
                GP1_L_PLANT_ID = reader["GP1_L_PLANT_ID"].ToString(),

                PRV_GP1_L_TRANS_DATE = reader["PRV_GP1_L_TRANS_DATE"].ToString(),
                PRV_GP1_L_TIME = reader["PRV_GP1_L_TIME"].ToString(),
                PRV_GP1_L_UNIT_ID = reader["PRV_GP1_L_UNIT_ID"].ToString(),
                PRV_GP1_L_USER_ID = (decimal)reader["PRV_GP1_L_USER_ID"],
                PRV_GP1_L_DATE_MOD = reader["PRV_GP1_L_DATE_MOD"].ToString(),
                PRV_GP1_L_N2 = (decimal)reader["PRV_GP1_L_N2"],
                PRV_GP1_L_CH4 = (decimal)reader["PRV_GP1_L_CH4"],
                PRV_GP1_L_C2H6 = (decimal)reader["PRV_GP1_L_C2H6"],
                PRV_GP1_L_CO2 = (decimal)reader["PRV_GP1_L_CO2"],
                PRV_GP1_L_C3H8 = (decimal)reader["PRV_GP1_L_C3H8"],
                PRV_GP1_L_NC4H10 = (decimal)reader["PRV_GP1_L_NC4H10"],
                PRV_GP1_L_IC4H10 = (decimal)reader["PRV_GP1_L_IC4H10"],
                PRV_GP1_L_NG_GROSS_CV = (decimal)reader["PRV_GP1_L_NG_GROSS_CV"],
                PRV_GP1_L_NG_NET_CV = (decimal)reader["PRV_GP1_L_NG_NET_CV"],
                PRV_GP1_L_H2S = reader["PRV_GP1_L_H2S"].ToString(),
                PRV_GP1_L_ZNO_BED = reader["PRV_GP1_L_ZNO_BED"].ToString(),
                PRV_GP1_L_MOL_WT = (decimal)reader["PRV_GP1_L_MOL_WT"],
                PRV_GP1_L_FREEZE_FLG = reader["PRV_GP1_L_FREEZE_FLG"].ToString(),
                PRV_GP1_L_FREEZE_TIME = reader["PRV_GP1_L_FREEZE_TIME"].ToString(),
                PRV_GP1_L_PLANT_ID = reader["PRV_GP1_L_PLANT_ID"].ToString(),

                // GP-II Fields
                GP2_L_TRANS_DATE = reader["GP2_L_TRANS_DATE"].ToString(),
                GP2_L_TIME = reader["GP2_L_TIME"].ToString(),
                GP2_L_UNIT_ID = reader["GP2_L_UNIT_ID"].ToString(),
                GP2_L_USER_ID = (decimal)reader["GP2_L_USER_ID"],
                GP2_L_DATE_MOD = reader["GP2_L_DATE_MOD"].ToString(),
                GP2_L_N2 = (decimal)reader["GP2_L_N2"],
                GP2_L_CH4 = (decimal)reader["GP2_L_CH4"],
                GP2_L_C2H6 = (decimal)reader["GP2_L_C2H6"],
                GP2_L_CO2 = (decimal)reader["GP2_L_CO2"],
                GP2_L_C3H8 = (decimal)reader["GP2_L_C3H8"],
                GP2_L_NC4H10 = (decimal)reader["GP2_L_NC4H10"],
                GP2_L_IC4H10 = (decimal)reader["GP2_L_IC4H10"],
                GP2_L_NG_GROSS_CV = (decimal)reader["GP2_L_NG_GROSS_CV"],
                GP2_L_NG_NET_CV = (decimal)reader["GP2_L_NG_NET_CV"],
                GP2_L_H2S = reader["GP2_L_H2S"].ToString(),
                GP2_L_ZNO_BED = reader["GP2_L_ZNO_BED"].ToString(),
                GP2_L_MOL_WT = (decimal)reader["GP2_L_MOL_WT"],
                GP2_L_FREEZE_FLG = reader["GP2_L_FREEZE_FLG"].ToString(),
                GP2_L_FREEZE_TIME = reader["GP2_L_FREEZE_TIME"].ToString(),
                GP2_L_PLANT_ID = reader["GP2_L_PLANT_ID"].ToString(),

                PRV_GP2_L_TRANS_DATE = reader["PRV_GP2_L_TRANS_DATE"].ToString(),
                PRV_GP2_L_TIME = reader["PRV_GP2_L_TIME"].ToString(),
                PRV_GP2_L_UNIT_ID = reader["PRV_GP2_L_UNIT_ID"].ToString(),
                PRV_GP2_L_USER_ID = (decimal)reader["PRV_GP2_L_USER_ID"],
                PRV_GP2_L_DATE_MOD = reader["PRV_GP2_L_DATE_MOD"].ToString(),
                PRV_GP2_L_N2 = (decimal)reader["PRV_GP2_L_N2"],
                PRV_GP2_L_CH4 = (decimal)reader["PRV_GP2_L_CH4"],
                PRV_GP2_L_C2H6 = (decimal)reader["PRV_GP2_L_C2H6"],
                PRV_GP2_L_CO2 = (decimal)reader["PRV_GP2_L_CO2"],
                PRV_GP2_L_C3H8 = (decimal)reader["PRV_GP2_L_C3H8"],
                PRV_GP2_L_NC4H10 = (decimal)reader["PRV_GP2_L_NC4H10"],
                PRV_GP2_L_IC4H10 = (decimal)reader["PRV_GP2_L_IC4H10"],
                PRV_GP2_L_NG_GROSS_CV = (decimal)reader["PRV_GP2_L_NG_GROSS_CV"],
                PRV_GP2_L_NG_NET_CV = (decimal)reader["PRV_GP2_L_NG_NET_CV"],
                PRV_GP2_L_H2S = reader["PRV_GP2_L_H2S"].ToString(),
                PRV_GP2_L_ZNO_BED = reader["PRV_GP2_L_ZNO_BED"].ToString(),
                PRV_GP2_L_MOL_WT = (decimal)reader["PRV_GP2_L_MOL_WT"],
                PRV_GP2_L_FREEZE_FLG = reader["PRV_GP2_L_FREEZE_FLG"].ToString(),
                PRV_GP2_L_FREEZE_TIME = reader["PRV_GP2_L_FREEZE_TIME"].ToString(),
                PRV_GP2_L_PLANT_ID = reader["PRV_GP2_L_PLANT_ID"].ToString(),

                // GP-III Fields
                GP3_L_TRANS_DATE = reader["GP3_L_TRANS_DATE"].ToString(),
                GP3_L_TIME = reader["GP3_L_TIME"].ToString(),
                GP3_L_UNIT_ID = reader["GP3_L_UNIT_ID"].ToString(),
                GP3_L_USER_ID = (decimal)reader["GP3_L_USER_ID"],
                GP3_L_DATE_MOD = reader["GP3_L_DATE_MOD"].ToString(),
                GP3_L_N2 = (decimal)reader["GP3_L_N2"],
                GP3_L_CH4 = (decimal)reader["GP3_L_CH4"],
                GP3_L_C2H6 = (decimal)reader["GP3_L_C2H6"],
                GP3_L_CO2 = (decimal)reader["GP3_L_CO2"],
                GP3_L_C3H8 = (decimal)reader["GP3_L_C3H8"],
                GP3_L_NC4H10 = (decimal)reader["GP3_L_NC4H10"],
                GP3_L_IC4H10 = (decimal)reader["GP3_L_IC4H10"],
                GP3_L_NG_GROSS_CV = (decimal)reader["GP3_L_NG_GROSS_CV"],
                GP3_L_NG_NET_CV = (decimal)reader["GP3_L_NG_NET_CV"],
                GP3_L_H2S = reader["GP3_L_H2S"].ToString(),
                GP3_L_ZNO_BED = reader["GP3_L_ZNO_BED"].ToString(),
                GP3_L_MOL_WT = (decimal)reader["GP3_L_MOL_WT"],
                GP3_L_FREEZE_FLG = reader["GP3_L_FREEZE_FLG"].ToString(),
                GP3_L_FREEZE_TIME = reader["GP3_L_FREEZE_TIME"].ToString(),
                GP3_L_PLANT_ID = reader["GP3_L_PLANT_ID"].ToString(),

                PRV_GP3_L_TRANS_DATE = reader["PRV_GP3_L_TRANS_DATE"].ToString(),
                PRV_GP3_L_TIME = reader["PRV_GP3_L_TIME"].ToString(),
                PRV_GP3_L_UNIT_ID = reader["PRV_GP3_L_UNIT_ID"].ToString(),
                PRV_GP3_L_USER_ID = (decimal)reader["PRV_GP3_L_USER_ID"],
                PRV_GP3_L_DATE_MOD = reader["PRV_GP3_L_DATE_MOD"].ToString(),
                PRV_GP3_L_N2 = (decimal)reader["PRV_GP3_L_N2"],
                PRV_GP3_L_CH4 = (decimal)reader["PRV_GP3_L_CH4"],
                PRV_GP3_L_C2H6 = (decimal)reader["PRV_GP3_L_C2H6"],
                PRV_GP3_L_CO2 = (decimal)reader["PRV_GP3_L_CO2"],
                PRV_GP3_L_C3H8 = (decimal)reader["PRV_GP3_L_C3H8"],
                PRV_GP3_L_NC4H10 = (decimal)reader["PRV_GP3_L_NC4H10"],
                PRV_GP3_L_IC4H10 = (decimal)reader["PRV_GP3_L_IC4H10"],
                PRV_GP3_L_NG_GROSS_CV = (decimal)reader["PRV_GP3_L_NG_GROSS_CV"],
                PRV_GP3_L_NG_NET_CV = (decimal)reader["PRV_GP3_L_NG_NET_CV"],
                PRV_GP3_L_H2S = reader["PRV_GP3_L_H2S"].ToString(),
                PRV_GP3_L_ZNO_BED = reader["PRV_GP3_L_ZNO_BED"].ToString(),
                PRV_GP3_L_MOL_WT = (decimal)reader["PRV_GP3_L_MOL_WT"],
                PRV_GP3_L_FREEZE_FLG = reader["PRV_GP3_L_FREEZE_FLG"].ToString(),
                PRV_GP3_L_FREEZE_TIME = reader["PRV_GP3_L_FREEZE_TIME"].ToString(),
                PRV_GP3_L_PLANT_ID = reader["PRV_GP3_L_PLANT_ID"].ToString()
            };
        }

        public async Task<List<PLS005Model>> getData(TransactionDateDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_LB_GET_PPT_LB_AMM_NATURAL_GAS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", data.TransactionDate));
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
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPT_LB_AMM_NATURAL_GAS]", sql))
                {
                    // GP1
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_TRANS_DATE", value.GP1_L_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_TIME", value.GP1_L_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_UNIT_ID", value.GP1_L_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_USER_ID", value.GP1_L_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_DATE_MOD", value.GP1_L_DATE_MOD));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_N2", value.GP1_L_N2));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_CH4", value.GP1_L_CH4));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_C2H6", value.GP1_L_C2H6));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_CO2", value.GP1_L_CO2));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_C3H8", value.GP1_L_C3H8));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_NC4H10", value.GP1_L_NC4H10));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_IC4H10", value.GP1_L_IC4H10));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_NG_GROSS_CV", value.GP1_L_NG_GROSS_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_NG_NET_CV", value.GP1_L_NG_NET_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_H2S", value.GP1_L_H2S));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_ZNO_BED", value.GP1_L_ZNO_BED));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_MOL_WT", value.GP1_L_MOL_WT));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_FREEZE_FLG", value.GP1_L_FREEZE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_FREEZE_TIME", value.GP1_L_FREEZE_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP1_L_PLANT_ID", value.GP1_L_PLANT_ID));
                    // GP2
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_TRANS_DATE", value.GP2_L_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_TIME", value.GP2_L_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_UNIT_ID", value.GP2_L_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_USER_ID", value.GP2_L_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_DATE_MOD", value.GP2_L_DATE_MOD));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_N2", value.GP2_L_N2));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_CH4", value.GP2_L_CH4));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_C2H6", value.GP2_L_C2H6));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_CO2", value.GP2_L_CO2));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_C3H8", value.GP2_L_C3H8));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_NC4H10", value.GP2_L_NC4H10));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_IC4H10", value.GP2_L_IC4H10));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_NG_GROSS_CV", value.GP2_L_NG_GROSS_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_NG_NET_CV", value.GP2_L_NG_NET_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_H2S", value.GP2_L_H2S));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_ZNO_BED", value.GP2_L_ZNO_BED));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_MOL_WT", value.GP2_L_MOL_WT));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_FREEZE_FLG", value.GP2_L_FREEZE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_FREEZE_TIME", value.GP2_L_FREEZE_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP2_L_PLANT_ID", value.GP2_L_PLANT_ID));
                    // GP3
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_TRANS_DATE", value.GP3_L_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_TIME", value.GP3_L_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_UNIT_ID", value.GP3_L_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_USER_ID", value.GP3_L_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_DATE_MOD", value.GP3_L_DATE_MOD));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_N2", value.GP3_L_N2));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_CH4", value.GP3_L_CH4));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_C2H6", value.GP3_L_C2H6));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_CO2", value.GP3_L_CO2));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_C3H8", value.GP3_L_C3H8));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_NC4H10", value.GP3_L_NC4H10));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_IC4H10", value.GP3_L_IC4H10));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_NG_GROSS_CV", value.GP3_L_NG_GROSS_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_NG_NET_CV", value.GP3_L_NG_NET_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_H2S", value.GP3_L_H2S));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_ZNO_BED", value.GP3_L_ZNO_BED));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_MOL_WT", value.GP3_L_MOL_WT));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_FREEZE_FLG", value.GP3_L_FREEZE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_FREEZE_TIME", value.GP3_L_FREEZE_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_GP3_L_PLANT_ID", value.GP3_L_PLANT_ID));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
