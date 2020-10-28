using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class TagMasterRepository
    {
        private readonly string _connectionString;
        public TagMasterRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private TagMasterModel MapToValue(SqlDataReader reader)
        {
            return new TagMasterModel()
            {
                DEPT_CODE = reader["DEPT_CODE"].ToString(),
                DEPT_DESC = reader["DEPT_DESC"].ToString(),
                TAG_NO = reader["TAG_NO"].ToString(),
                TAG_DESC = reader["TAG_DESC"].ToString(),
                DATE_MOD = reader["DATE_MOD"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        private TagMasterPUS004 MapToValuePUS004(SqlDataReader reader)
        {
            return new TagMasterPUS004()
            {
                TAG_NO = reader["TAG_NO"].ToString(),
                TAG_DESC = reader["TAG_DESC"].ToString()
            };
        }

        private TagMasterModel MapToValueDeptList(SqlDataReader reader)
        {
            return new TagMasterModel()
            {
                DEPT_CODE = reader["DEPT_CODE"].ToString(),
                DEPT_DESC = reader["DEPT_DESC"].ToString(),
                DATE_MOD = reader["DATE_MOD"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<List<TagMasterModel>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_GET_PPM_GL_TAG", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
                    var response = new List<TagMasterModel>();
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

        public async Task<List<TagMasterPUS004>> getDataPUS004()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_GET_PPM_GL_TAG", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
                    var response = new List<TagMasterPUS004>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValuePUS004(reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task<List<TagMasterModel>> getDeptList()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_GET_PPM_GL_TAG_DEPT_LIST", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@parameter", parameter));
                    var response = new List<TagMasterModel>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValueDeptList(reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(TagMasterDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_UR1_SAVE_PPM_GL_TAG", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_TAG_NO", value.TAG_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_TAG_DESC", value.TAG_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", value.USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_DEPT_CODE", value.DEPT_CODE));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
