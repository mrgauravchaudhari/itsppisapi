using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PLS201Repository
    {
        private readonly string _connectionString;
        public PLS201Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLS201Model MapToValue(SqlDataReader reader)
        {
            return new PLS201Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                L_RAKE_NO = reader["L_RAKE_NO"].ToString(),
                L_UNIT_ID = reader["L_UNIT_ID"].ToString(),
                L_TIME = reader["L_TIME"].ToString(),
                L_TEMP = reader["L_TEMP"].ToString(),
                L_DENSITY = reader["L_DENSITY"].ToString(),
                L_DENSITY_15C = reader["L_DENSITY_15C"].ToString(),
                L_BR_NO = reader["L_BR_NO"].ToString(),
                L_OLEFINES = reader["L_OLEFINES"].ToString(),
                L_AROMATICS = reader["L_AROMATICS"].ToString(),
                L_IBP = reader["L_IBP"].ToString(),
                L_NRA_50 = reader["L_NRA_50"].ToString(),
                L_NRA_95 = reader["L_NRA_95"].ToString(),
                L_FBP = reader["L_FBP"].ToString(),
                L_CH_RATIO = reader["L_CH_RATIO"].ToString(),
                L_NAP_NET_CV = reader["L_NAP_NET_CV"].ToString(),
                L_NAP_GROSS_CV = reader["L_NAP_GROSS_CV"].ToString(),
                L_SULPHUR = reader["L_SULPHUR"].ToString(),
                L_RESIDUE = reader["L_RESIDUE"].ToString(),
                L_RECOVERY = reader["L_RECOVERY"].ToString(),
                L_LIQ_REMAIN = reader["L_LIQ_REMAIN"].ToString(),
                L_LOSS = reader["L_LOSS"].ToString(),
                L_AR3A_DENSITY = reader["L_AR3A_DENSITY"].ToString(),
                L_TANK_DENSITY_BF_UNLDG_15C = reader["L_TANK_DENSITY_BF_UNLDG_15C"].ToString(),
                L_TANK_DENSITY_BF_UNLDG = reader["L_TANK_DENSITY_BF_UNLDG"].ToString(),
                L_TANK_DENSITY_AF_UNLDG_15C = reader["L_TANK_DENSITY_AF_UNLDG_15C"].ToString(),
                L_TANK_DENSITY_AF_UNLDG = reader["L_TANK_DENSITY_AF_UNLDG"].ToString()
            };
        }

        public async Task<List<PLS201Model>> putData(string IN_DATE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB2_GET_PPT_LB_NAP_RAKE_ANALYSIS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    var response = new List<PLS201Model>();
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
    }
}
