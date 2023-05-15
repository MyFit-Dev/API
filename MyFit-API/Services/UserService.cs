using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class UserService
    {
        private UserRepository _userRepository = new UserRepository();

        public User? GetUserById(long id)
        {
            return _userRepository.GetUserById(id);
        }

    }
}
