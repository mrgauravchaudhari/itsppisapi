using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace itsppisapi.Data
{
    public class PGS010Repository
    {
        private readonly string _connectionString;

        public PGS010Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PGS010Model MapToValue(SqlDataReader reader)
        {
            return new PGS010Model()
            {
                USER_ID = (int)reader["USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
                USER_DESC = reader["USER_DESC"].ToString(),
                USER_LEVEL = (int)reader["USER_LEVEL"],
                USER_DEPT = reader["USER_DEPT"].ToString(),
                STATUS = reader["STATUS"].ToString(),
                EPR_NO = (int)reader["EPR_NO"],
                USER_EMAIL = reader["USER_EMAIL"].ToString(),
            };
        }

        private PGS010Model MapToValue2(SqlDataReader reader)
        {
            return new PGS010Model()
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

        public async Task<List<PGS010Model>> getData()
        {

            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [PPIS].[PPM_GL_MST_USERS]", sql))
                {
                    var response = new List<PGS010Model>();
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

        public async Task<PGS010Model> putData(StringParameterDto data)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_MST_USERS]", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_USER", data.StringParameter));
                        PGS010Model response = null;
                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                response = MapToValue2(reader);
                            }
                        }
                        return response;
                    }
                }
            }
            catch (Exception ex)
            {
                PGS010Model objdata = new PGS010Model();
                objdata.USER_DESC = "";
                objdata.USER_LEVEL = 0;
                objdata.USER_DEPT = "";
                objdata.STATUS = "";
                objdata.EPR_NO = 0;
                objdata.USER_EMAIL = "";
                objdata.USER_NAME = ex.Message;
                return objdata;
            }
        }

        public async Task saveData(PGS010SaveDto data)
        {
            string PASSWORD = "Temp@12345";
            byte[] PASSWORD_HASH, PASSWORD_SALT;
            CreatePasswordHash(PASSWORD, out PASSWORD_HASH, out PASSWORD_SALT);
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MST_USERS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", data.USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_NAME", data.USER_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_DESC", data.USER_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_DEPT ", data.USER_DEPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_LEVEL", data.USER_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_EPR_NO",  data.EPR_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_STATUS", data.STATUS));
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

        //public async Task<List<PGS010Model>> getData(StringParameterDto data)
        //{
        //  using (SqlConnection sql = new SqlConnection(_connectionString))
        //  {
        //    using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_GET_GL_MST_USERS", sql))
        //    {
        //      cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //      cmd.Parameters.Add(new SqlParameter("@IN_USER_NAME", data.StringParameter));
        //      var response = new List<PGS010Model>();
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
