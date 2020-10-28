using itsppisapi.Dtos;
using itsppisapi.Helpers;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PGS010Repository
    {
        private readonly string _connectionString;
        private readonly DataContext _context;
        private EmailHelper _emailHelper;

        public PGS010Repository(IConfiguration configuration, DataContext context, EmailHelper emailHelper)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
            _context = context;
            _emailHelper = emailHelper;
        }

        private PGS010Model MapToValue(SqlDataReader reader)
        {
            return new PGS010Model()
            {
                USER_ID = (decimal)reader["USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
                USER_DESC = reader["USER_DESC"].ToString(),
                USER_LEVEL = (decimal)reader["USER_LEVEL"],
                USER_DEPT = reader["USER_DEPT"].ToString(),
                USER_EPR_NO = (decimal)reader["USER_EPR_NO"],
                USER_PHONE_NO = reader["USER_PHONE_NO"].ToString(),
                USER_EMAIL = reader["USER_EMAIL"].ToString(),
                ACTIVE_FLAG = reader["ACTIVE_FLAG"].ToString(),
                USER_VALIDITY_DT = reader["USER_VALIDITY_DT"].ToString(),
                ENTERED_BY = (decimal)reader["ENTERED_BY"],
                MODIFIED_BY = (decimal)reader["MODIFIED_BY"],
            };
        }

        public async Task<List<PGS010Model>> getData()
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_MST_USERS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

        public async Task<bool> saveData(PGS010SaveDto data)
        {
            Random rendom = new Random();
            int rendom_number = rendom.Next(10000, 99999);
            string PASSWORD = "User" + data.USER_DEPT + "@" + rendom_number;
            byte[] PASSWORD_HASH, PASSWORD_SALT;
            CreatePasswordHash(PASSWORD, out PASSWORD_HASH, out PASSWORD_SALT);
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MST_USERS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_NAME", data.USER_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_DESC", data.USER_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_DEPT ", data.USER_DEPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_LEVEL", data.USER_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_EPR_NO", data.USER_EPR_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_PHONE_NO", data.USER_PHONE_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_EMAIL", data.USER_EMAIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_ACTIVE_FLAG", data.ACTIVE_FLAG));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_VALIDITY_DT", data.USER_VALIDITY_DT));
                    cmd.Parameters.Add(new SqlParameter("@IN_ENTERED_BY", data.ENTERED_BY));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODIFIED_BY", data.MODIFIED_BY));
                    cmd.Parameters.Add(new SqlParameter("@IN_PASSWORD_HASH", PASSWORD_HASH));
                    cmd.Parameters.Add(new SqlParameter("@IN_PASSWORD_SALT", PASSWORD_SALT));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();

                    if (data.USER_ID == 0)
                    {
                        var message = "Hello, " + data.USER_DESC + "<br>" +
                            "<br><p>Welcome to <b>Plant Performance Information System (PPIS)</b> of Chambal Fertilisers and Chemicals Limited. We're glad to have you.</p><br>" +
                            "Here are your PPIS system account details: <br>" +
                            "<ul>" +
                            "<li>UserName : <b>" + data.USER_NAME + "</b></li>" +
                            "<li>Password : <b>" + PASSWORD + "</b></li>" +
                            "</ul>" +
                            "<br>" +
                            "click <a href='http://192.168.201.27:8091'>here</a> for login PPIS system. <br>" +
                            "click <a href='http://192.168.201.27:8091/auth/reset'>here</a> for update login PPIS system account password. <br>";

                        var emailModel = new EmailHelperModel(data.USER_EMAIL, // To  
                            "PPIS Account", // from display name
                            "Welcome to PPIS Application", // Subject  
                            message, // Message  
                            true // IsBodyHTML  
                            );
                        _emailHelper.SendEmail(emailModel);
                    }
                    return true;
                }
            }
        }

        public async Task<bool> UserExists(string USER_NAME)
        {
            USER_NAME = USER_NAME.ToUpper();
            if (await _context.PPM_GL_MST_USERS.AnyAsync(x => x.USER_NAME == USER_NAME))
                return true;

            return false;
        }

        public async Task<bool> UserEPRNOExists(decimal USER_EPR_NO)
        {
            if (await _context.PPM_GL_MST_USERS.AnyAsync(x => x.USER_EPR_NO == USER_EPR_NO))
                return true;

            return false;
        }

        private void CreatePasswordHash(string PASSWORD, out byte[] PASSWORD_HASH, out byte[] PASSWORD_SALT)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                PASSWORD_SALT = hmac.Key;
                PASSWORD_HASH = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(PASSWORD));
            }
        }
    }
}