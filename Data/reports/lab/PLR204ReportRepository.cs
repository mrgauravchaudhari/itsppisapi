
using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace itsppisapi.Data
{
    public class PLR204ReportRepository
    {
        private readonly string _connectionString;
        public PLR204ReportRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLR204ReportModel MapToValue(SqlDataReader reader)
        {
            return new PLR204ReportModel()
            {
                TRANS_DATE = reader["TRANS_DATE"].ToString(),
                TIME = reader["TIME"].ToString(),
                USER_ID = (decimal)reader["USER_ID"],
                DATE_MOD = reader["DATE_MOD"].ToString(),
                TEMP = (decimal)reader["TEMP"],
                DENSITY = (decimal)reader["DENSITY"],
                DENSITY_15C = (decimal)reader["DENSITY_15C"],
                DAYTANK_SULPHUR = (decimal)reader["DAYTANK_SULPHUR"],
                AROMATICS = (decimal)reader["AROMATICS"],
                BR_NO = (decimal)reader["BR_NO"],
                OLEFINES = (decimal)reader["OLEFINES"],
                IBP = (decimal)reader["IBP"],
                NRA_50 = (decimal)reader["NRA_50"],
                NRA_95 = (decimal)reader["NRA_95"],
                FBP = (decimal)reader["FBP"],
                CH_RATIO = (decimal)reader["CH_RATIO"],
                RESIDUE = (decimal)reader["RESIDUE"],
                RECOVERY = (decimal)reader["RECOVERY"],
                LIQUID_REMAIN = (decimal)reader["LIQUID_REMAIN"],
                LOSS = (decimal)reader["LOSS"],
                NET_CV = (decimal)reader["NET_CV"],
                GROSS_CV = (decimal)reader["GROSS_CV"],
                SNDT_SULPHUR = (decimal)reader["SNDT_SULPHUR"],
                SULPHUR_OUTLET = (decimal)reader["SULPHUR_OUTLET"]
            };
        }

        public async Task<List<PLR204ReportModel>> GetById(string TDATE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB_NAPTHA_COMPOS_ANALS_M_LEDGER", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@DT", TDATE));
                    var response = new List<PLR204ReportModel>();
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
