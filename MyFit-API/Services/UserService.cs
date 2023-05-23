using MyFit_API.Exceptions.GymException;
using MyFit_API.Exceptions.PlanException;
using MyFit_API.Exceptions.UserException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class UserService
    {
        private UserRepository _userRepository = new UserRepository();

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(long id)
        {
            User? user = _userRepository.GetUserById(id);

            if (user == null) 
                throw new UserNotFoundException("User not found");

            return user;
        }

        public User GetUserByMail(string mail)
        { 
            User user = _userRepository.GetUserByMail(mail);

            if (user == null)
                throw new UserNotFoundException("User not found");

            return user;
        }

        public Plan GetUserPlan(long id)
        {
            Plan? plan = _userRepository.GetUserPlan(id);

            if (plan == null)
                throw new PlanNotFoundException("Plan not found");

            return plan;
        }

        public Gym GetUserGym(long id)
        {
            Gym? gym = _userRepository.GetUserGym(id);

            if (gym == null)
                throw new GymNotFoundException("Gym not found");

            return gym;
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
            if (_userRepository.GetUserByMail(user.Mail) == null)
                _userRepository.AddUser(user);
            else
                throw new UserAlredyFoundException("User alredy exists");
        }

        public void SetUserName(long id, string name)
        {
            if (!_userRepository.ExistsUserById(id))
                throw new UserNotFoundException("User not found");

            _userRepository.SetUserName(id, name);
        }

        public void SetUserSurname(long id, string surname)
        {
            if (!_userRepository.ExistsUserById(id))
                throw new UserNotFoundException("User not found");

            _userRepository.SetUserSurname(id, surname);
        }

        public void SetUserMail(long id, string mail)
        {
            if (!_userRepository.ExistsUserById(id))
                throw new UserNotFoundException("User not found");

            _userRepository.SetUserMail(id, mail);
        }

        public void SetUserState(long id, string state)
        {
            if (!_userRepository.ExistsUserById(id))
                throw new UserNotFoundException("User not found");

            _userRepository.SetUserState(id, state);
        }

        public void SetUserCity(long id, string city)
        {
            if (!_userRepository.ExistsUserById(id))
                throw new UserNotFoundException("User not found");

            _userRepository.SetUserCity(id, city);
        }

        public void SetUserPlan(long id, int? idPlan)
        {
            if (!_userRepository.ExistsUserById(id))
                throw new UserNotFoundException("User not found");

            _userRepository.SetUserPlan(id, idPlan);
        }

        public void SetUserGym(long id, int? idGym)
        {
            if (!_userRepository.ExistsUserById(id))
                throw new UserNotFoundException("User not found");

            _userRepository.SetUserGym(id, idGym);
        }

        public void SetUserIntermittentFasting(long id, bool? intermittentFasting)
        {
            if (!_userRepository.ExistsUserById(id))
                throw new UserNotFoundException("User not found");

            _userRepository.SetUserIntermittentFasting(id, intermittentFasting);
        }

        public void DeleteUserById(long id)
        {
            if (!_userRepository.ExistsUserById(id))
                throw new UserNotFoundException("User not found");

            _userRepository.DeleteUserById(id);
        }

        public void DeleteUserByMail(string mail)
        {
            if (!_userRepository.ExistsUserByMail(mail))
                throw new UserNotFoundException("User not found");

            _userRepository.DeleteUserByMail(mail);
        }

        public long CountUsers()
        {
            return _userRepository.CountUsers();
        }

    }
}
