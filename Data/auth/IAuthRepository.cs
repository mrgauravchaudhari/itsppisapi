using itsppisapi.Models;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public interface IAuthRepository
    {
        Task<PPM_GL_MST_USERS> Register(PPM_GL_MST_USERS User, string Password);
        Task<UserProfile> Login(string USER_NAME, string PASSWORD);
        Task<bool> UserExists(string UserName);
        Task<bool> UserEPRNOExists(decimal UserEprno);
        Task<bool> UserResetStatus(string UserName);
    }
}