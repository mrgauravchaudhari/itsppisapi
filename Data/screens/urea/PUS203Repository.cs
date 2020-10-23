using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PUS203Repository
    {
        private readonly string _connectionString;
        public PUS203Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PUS203Model MapToValue(SqlDataReader reader)
        {
            return new PUS203Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                U2_TRANS_DATE = reader["U2_TRANS_DATE"].ToString(),
                U2_DEPT_CODE = reader["U2_DEPT_CODE"].ToString(),
                U2_MAINT_DEPT_CODE = reader["U2_MAINT_DEPT_CODE"].ToString(),
                U2_DATE_TIME_FROM = reader["U2_DATE_TIME_FROM"].ToString(),
                U2_DATE_TIME_TO = reader["U2_DATE_TIME_TO"].ToString(),
                U2_MAINT_HRS = (decimal)reader["U2_MAINT_HRS"],
                U2_UREA_STREAM = reader["U2_UREA_STREAM"].ToString(),
                U2_MAINT_TYPE = reader["U2_MAINT_TYPE"].ToString(),
                U2_TAG_NO = reader["U2_TAG_NO"].ToString(),
                U2_DOWNTIME_HRS = (decimal)reader["U2_DOWNTIME_HRS"],
                U2_JOB_DESC = reader["U2_JOB_DESC"].ToString(),
                U2_MONTH_FLG = reader["U2_MONTH_FLG"].ToString(),
                U2_YEAR_FLG = reader["U2_YEAR_FLG"].ToString(),
                DATE_MOD = reader["U2_DATE_MOD"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<List<PUS203Model>> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR2_GET_PPT_UR2_DAILY_PLANT_MAINT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    var response = new List<PUS203Model>();
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

        public async Task saveData(PUS203SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR2_SAVE_PPT_UR2_DAILY_PLANT_MAINT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TRANS_DATE", value.U2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_DEPT_CODE", value.U2_DEPT_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_MAINT_DEPT_CODE", value.U2_MAINT_DEPT_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_TAG_NO", value.U2_TAG_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_DATE_TIME_FROM", value.U2_DATE_TIME_FROM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_DATE_TIME_TO", value.U2_DATE_TIME_TO));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_MAINT_HRS", value.U2_MAINT_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_UREA_STREAM", value.U2_UREA_STREAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_MAINT_TYPE", value.U2_MAINT_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_DOWNTIME_HRS", value.U2_DOWNTIME_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_JOB_DESC", value.U2_JOB_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_MONTH_FLG", value.U2_MONTH_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_YEAR_FLG", value.U2_YEAR_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_U2_USER_ID", value.U2_USER_ID));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
