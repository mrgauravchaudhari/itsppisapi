using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class ResetPasswordRepository
    {
        private readonly string _connectionString;
        public ResetPasswordRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ResetPasswordModel MapToValue(SqlDataReader reader)
        {
            return new ResetPasswordModel()
            {
                MSG = reader["MSG"].ToString(),
            };
        }

        public async Task<ResetPasswordModel> getData(ResetPasswordDto data)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(data.newpassword, out passwordHash, out passwordSalt);

            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.TEMP_PWS_UPDATE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_UserName", data.username));
                    cmd.Parameters.Add(new SqlParameter("@IN_TempPwd", data.temppassword));
                    cmd.Parameters.Add(new SqlParameter("@IN_NewPwd", data.newpassword));
                    cmd.Parameters.Add(new SqlParameter("@IN_PwdHash", passwordHash));
                    cmd.Parameters.Add(new SqlParameter("@IN_PwdSalt", passwordSalt));
                    ResetPasswordModel response = null;
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
        private void CreatePasswordHash(string authnpassword, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(authnpassword));
            }
        }
    }
}
