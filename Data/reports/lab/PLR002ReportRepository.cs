using Microsoft.Extensions.Configuration;
using cfclapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace cfclapi.Data
{
    public class PLR002ReportRepository
    {
        private readonly string _connectionString;
        public PLR002ReportRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLR002ReportModel MapToValue(SqlDataReader reader)
        {
            return new PLR002ReportModel()
            {
                NS_L_TRANS_DATE = reader["NS_L_TRANS_DATE"].ToString(),
                NS_L_TANK_A_TEMP = (decimal)reader["NS_L_TANK_A_TEMP"],
                NS_TANK1 = (int)reader["NS_TANK1"],
                NS_L_TANK_A_DENSITY = (decimal)reader["NS_L_TANK_A_DENSITY"],
                NS_L_TANK_A_DENSITY15 = (decimal)reader["NS_L_TANK_A_DENSITY15"],
                NS_L_TANK_B_TEMP = (decimal)reader["NS_L_TANK_B_TEMP"],
                NS_TANK2 = (int)reader["NS_TANK2"],
                NS_L_TANK_B_DENSITY = (decimal)reader["NS_L_TANK_B_DENSITY"],
                NS_L_TANK_B_DENSITY15 = (decimal)reader["NS_L_TANK_B_DENSITY15"],
                NS_L_TANK_C_TEMP = (decimal)reader["NS_L_TANK_C_TEMP"],
                NS_TANK3 = (int)reader["NS_TANK3"],
                NS_L_TANK_C_DENSITY = (decimal)reader["NS_L_TANK_C_DENSITY"],
                NS_L_TANK_C_DENSITY15 = (decimal)reader["NS_L_TANK_C_DENSITY15"],
                NS_L_TANK_D_TEMP = (decimal)reader["NS_L_TANK_D_TEMP"],
                NS_TANK4 = (int)reader["NS_TANK4"],
                NS_L_SNT_TEMP = (decimal)reader["NS_L_SNT_TEMP"],
                NS_TANK5 = (int)reader["NS_TANK5"],
                NS_L_SNT_DENSITY = (decimal)reader["NS_L_SNT_DENSITY"],
                NS_L_SNT_DENSITY15 = (decimal)reader["NS_L_SNT_DENSITY15"],
                NS_L_TANK_D_DENSITY = (decimal)reader["NS_L_TANK_D_DENSITY"],
                NS_L_TANK_D_DENSITY15 = (decimal)reader["NS_L_TANK_D_DENSITY15"],
                NR_L_TRANS_DATE = reader["NR_L_TRANS_DATE"].ToString(),
                NR_L_TIME = reader["NR_L_TIME"].ToString(),
                NR_L_UNIT_ID = reader["NR_L_UNIT_ID"].ToString(),
                NR_L_RAKE_NO = reader["NR_L_RAKE_NO"].ToString(),
                NR_L_TEMP = (decimal)reader["NR_L_TEMP"],
                NR_L_DENSITY = (decimal)reader["NR_L_DENSITY"],
                NR_L_BR_NO = (decimal)reader["NR_L_BR_NO"],
                NR_L_OLEFINES = (decimal)reader["NR_L_OLEFINES"],
                NR_L_AROMATICS = (decimal)reader["NR_L_AROMATICS"],
                NR_L_IBP = (decimal)reader["NR_L_IBP"],
                NR_L_NRA_50 = (decimal)reader["NR_L_NRA_50"],
                NR_L_NRA_95 = (decimal)reader["NR_L_NRA_95"],
                NR_L_FBP = (decimal)reader["NR_L_FBP"],
                NR_L_CH_RATIO = (decimal)reader["NR_L_CH_RATIO"],
                NR_L_NAP_NET_CV = (decimal)reader["NR_L_NAP_NET_CV"],
                NR_L_NAP_GROSS_CV = (decimal)reader["NR_L_NAP_GROSS_CV"],
                NG_L_TIME = reader["NG_L_TIME"].ToString(),
                NG_L_UNIT_ID = reader["NG_L_UNIT_ID"].ToString(),
                NG_L_N2 = (decimal)reader["NG_L_N2"],
                NG_L_CH4 = (decimal)reader["NG_L_CH4"],
                NG_L_C2H6 = (decimal)reader["NG_L_C2H6"],
                NG_L_CO2 = (decimal)reader["NG_L_CO2"],
                NG_L_C3H8 = (decimal)reader["NG_L_C3H8"],
                NG_L_NC4H10 = (decimal)reader["NG_L_NC4H10"],
                NG_L_IC4H10 = (decimal)reader["NG_L_IC4H10"],
                NG_L_NG_GROSS_CV = (decimal)reader["NG_L_NG_GROSS_CV"],
                NG_L_NG_NET_CV = (decimal)reader["NG_L_NG_NET_CV"],
                NG_L_H2S = reader["NG_L_H2S"].ToString(),
                NG_L_ZNO_BED = reader["NG_L_ZNO_BED"].ToString(),
                NG_L_MOL_WT = (decimal)reader["NG_L_MOL_WT"]
            };
        }

        public async Task<PLR002ReportModel> GetById(string TDATE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB_NG_COMPOS_NAP_RAKE_TANK_ANALS_D_RPT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DT", TDATE));
                    PLR002ReportModel response = null;
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
