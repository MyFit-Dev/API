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
            _userRepository.SetUserName(id, name);

            User? user = _userRepository.GetUserById(id);

            if (user == null)
                throw new UserNotFoundException("User not found"); 
        }

        public void SetUserSurname(long id, string surname)
        {
            _userRepository.SetUserSurname(id, surname);

            User? user = _userRepository.GetUserById(id);

            if (user == null)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserMail(long id, string mail)
        {
            _userRepository.SetUserMail(id, mail);

            User? user = _userRepository.GetUserById(id);

            if (user == null)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserState(long id, string state)
        {
            _userRepository.SetUserState(id, state);

            User? user = _userRepository.GetUserById(id);

            if (user == null)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserCity(long id, string city)
        {
            _userRepository.SetUserCity(id, city);

            User? user = _userRepository.GetUserById(id);

            if (user == null)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserPlan(long id, int? idPlan)
        {
            _userRepository.SetUserPlan(id, idPlan);

            User? user = _userRepository.GetUserById(id);

            if (user == null)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserGym(long id, int? idGym)
        {
            _userRepository.SetUserGym(id, idGym);

            User? user = _userRepository.GetUserById(id);

            if (user == null)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserIntermittentFasting(long id, bool? intermittentFasting)
        {
            _userRepository.SetUserIntermittentFasting(id, intermittentFasting);

            User? user = _userRepository.GetUserById(id);

            if (user == null)
                throw new UserNotFoundException("User not found");
        }

        public void DeleteUserById(long id)
        {
            _userRepository.DeleteUserById(id);

            User? user = _userRepository.GetUserById(id);

            if (user == null)
                throw new UserNotFoundException("User not found");
        }

        public void DeleteUserByMail(string mail)
        {
            _userRepository.DeleteUserByMail(mail);

            User? user = _userRepository.GetUserByMail(mail);

            if (user == null)
                throw new UserNotFoundException("User not found");
        }

        public long CountUsers()
        {
            return _userRepository.CountUsers();
        }

    }
}
