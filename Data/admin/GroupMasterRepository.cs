using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class GroupMasterRepository
    {
        private readonly string _connectionString;
        public GroupMasterRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private GroupMasterModel MapToValue(SqlDataReader reader)
        {
            return new GroupMasterModel()
            {
                GROUP_NAME = reader["GROUP_NAME"].ToString(),
                MODULE_NAME = reader["MODULE_NAME"].ToString(),
                MODULE_DESC = reader["MODULE_DESC"].ToString()
            };
        }

        public async Task<List<GroupMasterModel>> getData(StringParameterDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_GROUP_MODULES]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_GROUP_NAME", data.StringParameter));
                    var response = new List<GroupMasterModel>();
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

        public async Task saveData(GroupMasterSaveDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MODULE]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_GROUP_NAME", data.GROUP_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_NAME", data.MODULE_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODULE_DESC", data.MODULE_DESC));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        //public async Task<GroupMasterModel> getData(StringParameterDto data)
        //{
        //  using (SqlConnection sql = new SqlConnection(_connectionString))
        //  {
        //    using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_GROUP_MODULES]", sql))
        //    {
        //      cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //      cmd.Parameters.Add(new SqlParameter("@IN_GROUP_NAME", data.StringParameter));
        //      GroupMasterModel response = null;
        //      await sql.OpenAsync();
        //      using (var reader = await cmd.ExecuteReaderAsync())
        //      {
        //        while (await reader.ReadAsync())
        //        {
        //          response = MapToValue(reader);
        //        }
        //      }
        //      return response;
        //    }
        //  }
        //}

    }
}
