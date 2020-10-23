using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using System.Collections.Generic;

namespace itsppisapi.Data
{
    public class POS002Repository
    {
        private readonly string _connectionString;
        public POS002Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private POS002Model MapToValue(SqlDataReader reader)
        {
            return new POS002Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_USER_ID = (dynamic)reader["OU1_USER_ID"],
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),
                OU1_DEPT_CODE = reader["OU1_DEPT_CODE"].ToString(),

                OU1_CATG_NAME = reader["OU1_CATG_NAME"].ToString(),
                OU1_MACH_NAME = reader["OU1_MACH_NAME"].ToString(),
                OU1_PUMP_UNIT_FLG = reader["OU1_PUMP_UNIT_FLG"].ToString(),
                OU1_MACH_RUNHRS = (dynamic)reader["OU1_MACH_RUNHRS"],
            };
        }

        public async Task<List<POS002Model>> putData(POS002Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_MACHINE_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_DEPT_CODE", value.DeptCode));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", value.UnitId));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    var response = new List<POS002Model>();
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
        public async Task saveData(POS002SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_MACHINE_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DEPT_CODE", value.OU1_DEPT_CODE));

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CATG_NAME", value.OU1_CATG_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_MACH_NAME", value.OU1_MACH_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PUMP_UNIT_FLG", value.OU1_PUMP_UNIT_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_MACH_RUNHRS", value.OU1_MACH_RUNHRS));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
