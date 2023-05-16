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

        public User? GetUserByName(string name)
        { 
            return _userRepository.GetUserByEmail(name);
        }

        public Plan GetUserPlan(long id)
        {
            return _userRepository.GetUserPlan(id);
        }

        public Gym? GetUserGym(long id)
        {
            return _userRepository.GetUserGym(id);
        }

        public string? GetUserFoodListOnDate(long id, DateTime date)
        {
            return _userRepository.GetUserFoodListOnDate(id, date);
        }

        public bool IsUserOnIntermittentFasting(long id)
        {
            return _userRepository.IsUserOnIntermittentFasting(id);
        }

        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }

        public int SetUserName(long id, string name)
        {
            return _userRepository.SetUserName(id, name);
        }

        public int SetUserSurname(long id, string surname)
        {
            return _userRepository.SetUserSurname(id, surname);
        }

        public int SetUserMail(long id, string mail)
        {
            return _userRepository.SetUserMail(id, mail);
        }

        public int SetUserState(long id, string state)
        {
            return _userRepository.SetUserState(id, state);
        }

        public int SetUserCity(long id, string city)
        {
            return _userRepository.SetUserCity(id, city);
        }

        public int SetUserPlan(long id, int idPlan)
        {
            return _userRepository.SetUserPlan(id, idPlan);
        }

        public int SetUserGym(long id, int? idGym)
        {
            return _userRepository.SetUserGym(id, idGym);
        }

        public int SetUserIntermittentFasting(long id, bool intermittentFasting)
        {
            return _userRepository.SetUserIntermittentFasting(id, intermittentFasting);
        }

        public int DeleteUserById(long id)
        {
            return _userRepository.DeleteUserById(id);
        }

        public int DeleteUserByMail(string mail)
        {
            return _userRepository.DeleteUserByMail(mail);
        }

    }
}
