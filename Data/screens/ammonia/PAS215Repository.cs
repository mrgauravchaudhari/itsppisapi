using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS215Repository
    {
        private readonly string _connectionString;
        public PAS215Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS215Model MapToValue(SqlDataReader reader)
        {
            return new PAS215Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                DSP_DEPT_NAME = reader["DSP_DEPT_NAME"].ToString(),
                DSP_MAINT_DEPT_DESC = reader["DSP_MAINT_DEPT_DESC"].ToString(),
                A2_TAG_NO = reader["A2_TAG_NO"].ToString(),
                A2_DATE_TIME_FROM = reader["A2_DATE_TIME_FROM"].ToString(),
                A2_DATE_TIME_TO = reader["A2_DATE_TIME_TO"].ToString(),
                A2_MAINT_HRS = (dynamic)reader["A2_MAINT_HRS"],
                A2_MAINT_TYPE = (dynamic)reader["A2_MAINT_TYPE"],
                A2_DOWNTIME_HRS = (dynamic)reader["A2_DOWNTIME_HRS"],
                A2_JOB_DESC = reader["A2_JOB_DESC"].ToString(),
                A2_MONTH_FLG = reader["A2_MONTH_FLG"].ToString(),
                A2_YEAR_FLG = reader["A2_YEAR_FLG"].ToString(),
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_USER_ID = (dynamic)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
            };
        }

        private ListTagNoModel MapToValueTagNo(SqlDataReader reader)
        {
            return new ListTagNoModel()
            {
                TAG_NO = reader["TAG_NO"].ToString(),
                TAG_DESC = reader["TAG_DESC"].ToString()
            };
        }

        public async Task<List<ListTagNoModel>> getTagNo(string DEPT_CODE)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT TAG_NO,TAG_DESC FROM [PPIS].[PPM_GL_TAG] WHERE DEPT_CODE = '" + DEPT_CODE + "'", sql))
                    {
                        var response = new List<ListTagNoModel>();
                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                response.Add(MapToValueTagNo(reader));
                            }
                        }
                        return response;
                    }
                }
            }
            catch (Exception ex)
            {
                List<ListTagNoModel> result = new List<ListTagNoModel>();

                ListTagNoModel data = new ListTagNoModel();
                data.TAG_NO = "1";
                data.TAG_DESC = ex.Message;
                result.Add(data);
                return result;
            }
        }

        public async Task<PAS215Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_DAILY_PLANT_MAINT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS215Model response = null;
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

        public async Task saveData(PAS215SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_DAILY_PLANT_MAINT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DEPT_CODE", value.DSP_DEPT_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_MAINT_DEPT_CODE", value.DSP_MAINT_DEPT_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TAG_NO", value.A2_TAG_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DATE_TIME_FROM", value.A2_DATE_TIME_FROM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DATE_TIME_TO", value.A2_DATE_TIME_TO));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_MAINT_HRS", value.A2_MAINT_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_MAINT_TYPE", value.A2_MAINT_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DOWNTIME_HRS ", value.A2_DOWNTIME_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_JOB_DESC", value.A2_JOB_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_MONTH_FLG", value.A2_MONTH_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_YEAR_FLG", value.A2_YEAR_FLG));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
