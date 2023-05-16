﻿using MyFit_API.Exceptions.GymException;
using MyFit_API.Exceptions.PlanException;
using MyFit_API.Exceptions.UserException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;

namespace MyFit_API.Services
{
    public class UserService
    {
        private UserRepository _userRepository = new UserRepository();

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
            int rows = _userRepository.SetUserName(id, name);

            if (rows == 0)
                throw new UserNotFoundException("User not found"); ;
        }

        public void SetUserSurname(long id, string surname)
        {
            int rows = _userRepository.SetUserSurname(id, surname);

            if (rows == 0)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserMail(long id, string mail)
        {
            int rows = _userRepository.SetUserMail(id, mail);

            if (rows == 0)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserState(long id, string state)
        {
            int rows = _userRepository.SetUserState(id, state);

            if (rows == 0)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserCity(long id, string city)
        {
            int rows = _userRepository.SetUserCity(id, city);

            if (rows == 0)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserPlan(long id, int? idPlan)
        {
            int rows = _userRepository.SetUserPlan(id, idPlan);

            if (rows == 0)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserGym(long id, int? idGym)
        {
            int rows = _userRepository.SetUserGym(id, idGym);

            if (rows == 0)
                throw new UserNotFoundException("User not found");
        }

        public void SetUserIntermittentFasting(long id, bool? intermittentFasting)
        {
            int rows = _userRepository.SetUserIntermittentFasting(id, intermittentFasting);

            if (rows == 0)
                throw new UserNotFoundException("User not found");
        }

        public void DeleteUserById(long id)
        {
            int rows = _userRepository.DeleteUserById(id);

            if (rows == 0)
                throw new UserNotFoundException("User not found");
        }

        public void DeleteUserByMail(string? mail)
        {
            int rows = _userRepository.DeleteUserByMail(mail);

            if (rows == 0)
                throw new UserNotFoundException("User not found");
        }

    }
}
