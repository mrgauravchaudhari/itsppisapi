using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PUS004Repository
    {
        private readonly string _connectionString;
        public PUS004Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PUS004Model MapToValue(SqlDataReader reader)
        {
            return new PUS004Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                U1_TRANS_DATE = reader["U1_TRANS_DATE"].ToString(),
                DSP_DEPT_NAME = reader["DSP_DEPT_NAME"].ToString(),
                DSP_MAINT_DEPT_DESC = reader["DSP_MAINT_DEPT_DESC"].ToString(),
                U1_TAG_NO = reader["U1_TAG_NO"].ToString(),
                U1_JOB_DESC = reader["U1_JOB_DESC"].ToString(),
                U1_MONTH_FLG = reader["U1_MONTH_FLG"].ToString(),
                U1_YEAR_FLG = reader["U1_YEAR_FLG"].ToString(),
                DATE_MOD = reader["U1_DATE_MOD"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<PUS004Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_GET_PPT_UR_DAILY_MAINT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PUS004Model response = null;
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

        public async Task saveData(PUS004Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_SAVE_PPT_UR_DAILY_MAINT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_U1_MONTH_FLG", value.U1_MONTH_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_TRANS_DATE", value.U1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_UNIT_ID", value.U1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_TAG_NO", value.U1_TAG_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_MAINT_DEPT_CODE", value.U1_MAINT_DEPT_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_DEPT_CODE", value.U1_DEPT_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_YEAR_FLG", value.U1_YEAR_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", value.USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_U1_JOB_DESC", value.U1_JOB_DESC));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
