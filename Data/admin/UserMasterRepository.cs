using Microsoft.Extensions.Configuration;
using cfclapi.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using cfclapi.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace cfclapi.Data
{
    public class UserMasterRepository
    {
        private readonly string _connectionString;
     
        public UserMasterRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private UserMasterModel MapToValue(SqlDataReader reader)
        {
            return new UserMasterModel()
            {
                USER_NAME = reader["USER_NAME"].ToString(),
                USER_DESC = reader["USER_DESC"].ToString(),
                USER_LEVEL = (int)reader["USER_LEVEL"],
                USER_DEPT = reader["USER_DEPT"].ToString(),
                STATUS = reader["STATUS"].ToString(),
                EPR_NO = (int)reader["EPR_NO"],
                USER_EMAIL = reader["USER_EMAIL"].ToString(),
            };
        }

        public async Task<UserMasterModel> getData(StringParameterDto data)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_MST_USERS]", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_USER", data.StringParameter));
                        UserMasterModel response = null;
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
            catch (Exception ex)
            {
                UserMasterModel objdata = new UserMasterModel();
                objdata.USER_DESC = "N";
                objdata.USER_LEVEL = 1;
                objdata.USER_DEPT = "N";
                objdata.STATUS = "N";
                objdata.EPR_NO = 1111;
                objdata.USER_EMAIL = "N";
                objdata.USER_NAME = ex.Message;
                return objdata;
            }
        }

        public async Task saveData(UserMasterSaveDto data)
        {
            string PASSWORD = "Temp@12345";
            byte[] PASSWORD_HASH, PASSWORD_SALT;
            CreatePasswordHash(PASSWORD, out PASSWORD_HASH, out PASSWORD_SALT);
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MST_USERS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_NAME", data.USER_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_DESC", data.USER_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_EPR_NO", data.EPR_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_DEPT ", data.USER_DEPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_LEVEL", data.USER_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_STATUS", data.STATUS));
                    cmd.Parameters.Add(new SqlParameter("@IN_EMP_NAME", ""));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_EMAIL", data.USER_EMAIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_PASSWORD_HASH", PASSWORD_HASH));
                    cmd.Parameters.Add(new SqlParameter("@IN_PASSWORD_SALT", PASSWORD_SALT));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
        private void CreatePasswordHash(string PASSWORD, out byte[] PASSWORD_HASH, out byte[] PASSWORD_SALT)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                PASSWORD_SALT = hmac.Key;
                PASSWORD_HASH = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(PASSWORD));
            }
        }

        //public async Task<List<UserMasterModel>> getData(StringParameterDto data)
        //{
        //  using (SqlConnection sql = new SqlConnection(_connectionString))
        //  {
        //    using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_GET_GL_MST_USERS", sql))
        //    {
        //      cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //      cmd.Parameters.Add(new SqlParameter("@IN_USER_NAME", data.StringParameter));
        //      var response = new List<UserMasterModel>();
        //      await sql.OpenAsync();
        //      using (var reader = await cmd.ExecuteReaderAsync())
        //      {
        //        while (await reader.ReadAsync())
        //        {
        //          response.Add(MapToValue(reader));
        //        }
        //      }
        //      return response;
        //    }
        //  }
        //}
    }
}
