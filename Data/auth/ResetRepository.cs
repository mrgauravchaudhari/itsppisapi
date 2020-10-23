using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using itsppisapi.Helpers;

namespace itsppisapi.Data
{
    public class ResetRepository
    {
        private readonly string _connectionString;
        private EmailHelper _emailHelper;

        public ResetRepository(IConfiguration configuration, EmailHelper emailHelper)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
            _emailHelper = emailHelper;
        }

        private ResetModel MapToValue(SqlDataReader reader)
        {
            return new ResetModel()
            {
                PASSWORD_TEMP = reader["PASSWORD_TEMP"].ToString(),
                USER_NAME = reader["USER_NAME"].ToString(),
                USER_DESC = reader["USER_DESC"].ToString(),
                USER_EMAIL = reader["USER_EMAIL"].ToString(),
                MSG = reader["MSG"].ToString(),
            };
        }

        public async Task<ResetModel> getData(StringParameterDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.TEMP_PWD_SET", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_UserName", data.StringParameter));
                    ResetModel response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue(reader);
                        }
                    }
                    if (response.MSG == "OK")
                    {
                        var message = "Hello, " + response.USER_DESC + "<br>" +
                           "You requested a password reset for your <b>PPIS</b> Application account.<br>" +
                           "<br><p>Please use following OTP to reset password:</p> <br>" +
                           "<b style='color: #313131; text-align: center; font-size: 40px; letter-spacing: 15px; line-height: 120px;'>" +
                           response.PASSWORD_TEMP + "</b><br>" +
                           "If you need any assistance, please contact CFCL IT Team";

                        var emailModel = new EmailHelperModel(response.USER_EMAIL, // To  
                            "PPIS Password Recovery", // from display name
                            "PPIS System - Reset Password OTP", // Subject  
                            message, // Message  
                            true // IsBodyHTML  
                            );
                        _emailHelper.SendEmail(emailModel);
                    }
                    return response;
                }
            }
        }
    }
}
