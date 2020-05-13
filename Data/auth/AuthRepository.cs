using System;
using System.Threading.Tasks;
using itsppisapi.Models;
using Microsoft.EntityFrameworkCore;

namespace itsppisapi.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<PPM_GL_MST_USERS> Login(string USER_NAME, string PASSWORD)
        {
            var User = await _context.PPM_GL_MST_USERS.FirstOrDefaultAsync(x => x.USER_NAME == USER_NAME);

            if (User == null)
                return null;

            if (User.STATUS == "I")
                return null;

            if (!VerifyPasswordHash(PASSWORD, User.PASSWORD_HASH, User.PASSWORD_SALT))
                return null;

            return User;
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

            user.PASSWORD_HASH = passwordHash;
            user.PASSWORD_SALT = passwordSalt;

            await _context.PPM_GL_MST_USERS.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
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
            if (await _context.PPM_GL_MST_USERS.AnyAsync(x => x.USER_NAME == USER_NAME))
                return true;

            return false;
        }

        //public async Task<UserProfile> Profile(string USER_NAME)
        //{
        //  var User = await _context.UserProfile.FirstOrDefaultAsync(x => x.USER_NAME == USER_NAME);

        //  if (User == null)
        //    return null;

        //  return User;
        //}
    }
}
