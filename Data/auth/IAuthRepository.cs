using itsppisapi.Models;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public interface IAuthRepository
    {
        Task<PPM_GL_MST_USERS> Register(PPM_GL_MST_USERS User, string Password);
        Task<PPM_GL_MST_USERS> Login(string USER_NAME, string PASSWORD);
        //Task<UserProfile> Profile(string USER_NAME);
        Task<bool> UserExists(string UserName);
    }
}