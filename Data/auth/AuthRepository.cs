using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        private readonly string _connectionString;

        public AuthRepository(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private UserProfile MapToValue(SqlDataReader reader)
        {
            return new UserProfile()
            {
                USER_ID = (decimal)reader["USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
                ACTIVE_FLAG = reader["ACTIVE_FLAG"].ToString(),
                PASSWORD_HASH = (byte[])reader["PASSWORD_HASH"],
                PASSWORD_SALT = (byte[])reader["PASSWORD_SALT"],
            };
        }

        public async Task<UserProfile> Login(string USER_NAME, string PASSWORD)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_CHECK_USER", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_NAME", USER_NAME));
                    UserProfile response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue(reader);
                        }
                    }
                    if (response == null)
                        return null;

                    if (response.ACTIVE_FLAG == "I")
                        return null;
                    //byte[] passwordHash, passwordSalt;

                    if (!VerifyPasswordHash(PASSWORD, response.PASSWORD_HASH, response.PASSWORD_SALT))
                        return null;

                    return response;
                }
            }
        }

        private bool VerifyPasswordHash(string PASSWORD, byte[] PASSWORD_HASH, byte[] PASSWORD_SALT)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(PASSWORD_SALT))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(PASSWORD));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != PASSWORD_HASH[i]) return false;
                }
            }
            return true;
        }

        public async Task<PPM_GL_MST_USERS> Register(PPM_GL_MST_USERS user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MST_USERS]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_NAME", user.USER_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_DESC", user.USER_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_DEPT ", user.USER_DEPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_LEVEL", user.USER_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_EPR_NO", user.USER_EPR_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_PHONE_NO", user.USER_PHONE_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_EMAIL", user.USER_EMAIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_ACTIVE_FLAG", user.ACTIVE_FLAG));
                    cmd.Parameters.Add(new SqlParameter("@IN_ENTERED_BY", user.ENTERED_BY));
                    cmd.Parameters.Add(new SqlParameter("@IN_MODIFIED_BY", user.MODIFIED_BY));
                    cmd.Parameters.Add(new SqlParameter("@IN_PASSWORD_HASH", passwordHash));
                    cmd.Parameters.Add(new SqlParameter("@IN_PASSWORD_SALT", passwordSalt));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return user;
                }
            }
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExists(string USER_NAME)
        {
            USER_NAME = USER_NAME.ToLower();
            if (await _context.PPM_GL_MST_USERS.AnyAsync(x => x.USER_NAME == USER_NAME))
                return true;
            else
                return false;
        }

        public async Task<bool> UserEPRNOExists(decimal USER_EPR_NO)
        {
            if (await _context.PPM_GL_MST_USERS.AnyAsync(x => x.USER_EPR_NO == USER_EPR_NO))
                return true;
            else
                return false;
        }

        public async Task<bool> UserResetStatus(string USER_NAME)
        {
            USER_NAME = USER_NAME.ToLower();
            if (await _context.PPM_GL_MST_USERS.AnyAsync(x => x.USER_NAME == USER_NAME && x.PASSWORD_FLAG == "OTP"))
                return true;
            else
                return false;
        }
    }
}