using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PLS007Repository
    {
        private readonly string _connectionString;
        public PLS007Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS007Model MapToValue(SqlDataReader reader)
        {
            return new PLS007Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                L_TRANS_DATE = reader["L_TRANS_DATE"].ToString(),
                L_TANK_A_TEMP = reader["L_TANK_A_TEMP"].ToString(),
                L_TANK_A_DENSITY = reader["L_TANK_A_DENSITY"].ToString(),
                L_TANK_A_DENSITY15 = reader["L_TANK_A_DENSITY15"].ToString(),
                L_TANK_B_TEMP = reader["L_TANK_B_TEMP"].ToString(),
                L_TANK_B_DENSITY = reader["L_TANK_B_DENSITY"].ToString(),
                L_TANK_B_DENSITY16 = reader["L_TANK_B_DENSITY16"].ToString(),
                L_TANK_C_TEMP = reader["L_TANK_C_TEMP"].ToString(),
                L_TANK_C_DENSITY = reader["L_TANK_C_DENSITY"].ToString(),
                L_TANK_C_DENSITY17 = reader["L_TANK_C_DENSITY17"].ToString(),
                L_TANK_D_TEMP = reader["L_TANK_D_TEMP"].ToString(),
                L_TANK_D_DENSITY = reader["L_TANK_D_DENSITY"].ToString(),
                L_TANK_D_DENSITY18 = reader["L_TANK_D_DENSITY18"].ToString(),
                L_SNT_TEMP = reader["L_SNT_TEMP"].ToString(),
                L_SNT_DENSITY = reader["L_SNT_DENSITY"].ToString(),
                L_SNT_DENSITY19 = reader["L_SNT_DENSITY19"].ToString()
            };
        }

        public async Task<PLS007Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_1_GET_PPT_LB_NAP_TANK_ANALYSIS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PLS007Model response = null;
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
