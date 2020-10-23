using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using itsppisapi.Dtos;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class WorkRepository
    {
        private readonly string _connectionString;
        public WorkRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private WorkModel MapToValue(SqlDataReader reader)
        {
            return new WorkModel()
            {
                B_WORK_CODE = reader["B_WORK_CODE"].ToString(),
                B_WORK_DESC = reader["B_WORK_DESC"].ToString(),
                B_LOADING_TYPE = reader["B_LOADING_TYPE"].ToString(),
                B_CONTR_CODE = reader["B_CONTR_CODE"].ToString(),
                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),
                DSP_B_CONTR_NAME = reader["DSP_B_CONTR_NAME"].ToString(),
                B_PRINT_SEQ = (decimal)reader["B_PRINT_SEQ"],
                B_ACTIVE_FLG = reader["B_ACTIVE_FLG"].ToString(),
                B_UOM = reader["B_UOM"].ToString(),
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_USER_ID = (decimal)reader["B_USER_ID"],
                B_USER_NAME = reader["B_USER_NAME"].ToString()
            };
        }

        public async Task<List<WorkModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_GET_PPM_BG_WORK", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<WorkModel>();
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

        public async Task saveData(WorkDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG_SAVE_PPM_BG_WORK", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WORK_CODE", value.B_WORK_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CONTR_CODE", value.B_CONTR_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.B_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WORK_DESC", value.B_WORK_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_LOADING_TYPE", value.B_LOADING_TYPE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_PRINT_SEQ", value.B_PRINT_SEQ));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_ACTIVE_FLG", value.B_ACTIVE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WORK_RATE", value.B_WORK_RATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UOM", value.B_UOM));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
