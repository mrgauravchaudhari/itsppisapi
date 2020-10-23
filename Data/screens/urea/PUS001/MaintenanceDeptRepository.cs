using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class MaintenanceDeptRepository
    {
        private readonly string _connectionString;
        public MaintenanceDeptRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private MaintenanceDeptModel MapToValue(SqlDataReader reader)
        {
            return new MaintenanceDeptModel()
            {
                MAINT_DEPT_CODE = reader["MAINT_DEPT_CODE"].ToString(),
                MAINT_DEPT_DESC = reader["MAINT_DEPT_DESC"].ToString(),
                DATE_MOD = reader["DATE_MOD"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<List<MaintenanceDeptModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_GET_PPM_GL_MAINT_DEPARTMENT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
                    var response = new List<MaintenanceDeptModel>();
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

        public async Task saveData(MaintenanceDeptDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_SAVE_PPM_GL_MAINT_DEPARTMENT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MAINT_DEPT_CODE", value.MAINT_DEPT_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_MAINT_DEPT_DESC", value.MAINT_DEPT_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", value.USER_ID));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
