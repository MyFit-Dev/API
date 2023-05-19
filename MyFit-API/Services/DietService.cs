using MyFit_API.Exceptions.DietException;
using MyFit_API.Exceptions.UserException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;
using MyFit_Libs.Utils;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFit_API.Services
{
    public class DietService
    {
        private DietRepository _dietRepository = new DietRepository();
        private UserRepository _userRepository = new UserRepository();

        public List<Diet> GetAllDiets()
        {
            List<Diet?>? diets = _dietRepository.GetAllDiets();

            if (diets == null || diets.Count == 0)
                throw new DietNotFoundException("Diets not found");

            return diets;
        }

        public List<Diet> GetAllUserDiets(long idUser)
        {
            User? user = _userRepository.GetUserById(idUser);
            List<Diet?>? diets = _dietRepository.GetAllDiets();

            if (user == null)
                throw new UserNotFoundException("User not found");

            if (diets == null || diets.Count == 0)
                throw new DietNotFoundException("Diets not found");

            return diets;
        }

        public Diet GetUserDietByDate(long idUser, DateTime date)
        {
            User? user = _userRepository.GetUserById(idUser);
            Diet? diet = _dietRepository.GetUserDietByDate(idUser, date);

            if (user == null)
                throw new UserNotFoundException("User not found");

            if (diet == null)
                throw new DietNotFoundException("Diet not found");

            return diet;
        }

        public Diet GetDiet(long id)
        {
            Diet? diet = _dietRepository.GetDiet(id);

            if (diet == null)
                throw new DietNotFoundException("Diet not found");

            return diet;
        }

        public Dictionary<string, List<Meal>> GetFoodList(long id)
        {
            Diet? diet = _dietRepository.GetDiet(id);
            string? foodList = _dietRepository.GetFoodList(id);

            if (diet == null)
                throw new DietNotFoundException("Diet not found");

            Dictionary<string, List<Meal>>? _foodList = JsonConvert.DeserializeObject<Dictionary<string, List<Meal>>>(foodList);

            return _foodList != null ? _foodList : new Dictionary<string, List<Meal>>();
        }

        public List<Dictionary<string, List<Meal>>> GetAllUserFoodLists(long idUser)
        {
            User? user = _userRepository.GetUserById(idUser);

            if (user == null)
                throw new UserNotFoundException("User not found");

            List<string>? foodLists = _dietRepository.GetAllUserFoodLists(idUser);

            if (foodLists == null)
                return new List<Dictionary<string, List<Meal>>>();

            List<Dictionary<string, List<Meal>>>? _foodLists = new List<Dictionary<string, List<Meal>>>();

            foreach (string foodList in foodLists)
                if (foodList != null)
                    _foodLists.Add(JsonConvert.DeserializeObject<Dictionary<string, List<Meal>>>(foodList));

            return _foodLists;
        }

        public Dictionary<string, List<Meal>> GetUserFoodListsByDate(long idUser, DateTime date)
        {
            User? user = _userRepository.GetUserById(idUser);

            if (user == null)
                throw new UserNotFoundException("User not found");

            string? foodList = _dietRepository.GetUserFoodListByDate(idUser, date);

            if (foodList == null)
                return new Dictionary<string, List<Meal>>();

            return JsonConvert.DeserializeObject<Dictionary<string, List<Meal>>>(foodList);
        }

        public List<Dictionary<string, List<Meal>>> GetUserFoodListsBetweenDates(long idUser, DateTime startDate, DateTime endDate)
        {
            User? user = _userRepository.GetUserById(idUser);

            if (user == null)
                throw new UserNotFoundException("User not found");

            List<string>? foodLists = _dietRepository.GetUserFoodListBetweenDates(idUser, startDate, endDate);

            if (foodLists == null)
                return new List<Dictionary<string, List<Meal>>>();

            List<Dictionary<string, List<Meal>>>? _foodLists = new List<Dictionary<string, List<Meal>>>();

            foreach (string foodList in foodLists)
                if (foodList != null)
                    _foodLists.Add(JsonConvert.DeserializeObject<Dictionary<string, List<Meal>>>(foodList));

            return _foodLists;
        }

        public void AddDiet(Diet diet)
        {
            if (_dietRepository.GetUserDietByDate(diet.IdUser, diet.Date) == null)
                _dietRepository.AddDiet(diet);
        }

        public void AddFoodToFoodListOfUser(long idUser, DateTime date, Meal meal)
        {
            User? user = _userRepository.GetUserById(idUser);

            if (user == null)
                throw new UserNotFoundException("User not found");

            Diet? diet = _dietRepository.GetUserDietByDate(idUser, date);

            if (diet == null)
            {
                diet = new Diet(idUser, new Dictionary<string, List<Meal>>(), date);
                _dietRepository.AddDiet(diet);
            }

            if (!diet.FoodList.Keys.Contains<string>(date.ToString("HH:mm")))
                diet.FoodList.Add(date.ToString("HH:mm"), new List<Meal>());
            else
                diet.FoodList[date.ToString("HH:mm")].Add(meal);

            _dietRepository.SetFoodListOfUser(idUser, date, diet.FoodList);
        }

        public void RemoveFoodToFoodListOfUser(long idUser, DateTime date, Meal meal)
        {
            User? user = _userRepository.GetUserById(idUser);
            string dateTime = date.ToString("HH:mm");

            if (user == null)
                throw new UserNotFoundException("User not found");

            Diet? diet = _dietRepository.GetUserDietByDate(idUser, date);

            if (diet == null)
                return;

            if (diet.FoodList[dateTime] != null)
            {
                List<Meal> list = diet.FoodList[dateTime];
                if (list.Contains(meal))
                    list.Remove(meal);

                if (list.Count == 0)
                    diet.FoodList.Remove(dateTime);
            }

            _dietRepository.SetFoodListOfUser(idUser, date, diet.FoodList);
        }

        public void DeleteDiet(long id)
        {
            Diet? diet = _dietRepository.GetDiet(id);

            if (diet == null)
                throw new DietNotFoundException("Diet not found");

            _dietRepository.DeleteDiet(diet.Id);
        }

        public void DeleteDietOfUserAndDate(long idUser, DateTime date)
        {
            User? user = _userRepository.GetUserById(idUser);
            Diet? diet = _dietRepository.GetUserDietByDate(idUser, date);

            if (user == null)
                throw new UserNotFoundException("User not found");

            if (diet == null)
                throw new DietNotFoundException("Diet not found");

            _dietRepository.DeleteDietOfUserAndDate(idUser, date);
        }

        public void DeleteDietsOfUser(long idUser) 
        {
            User? user = _userRepository.GetUserById(idUser);

            if (user == null)
                throw new UserNotFoundException("User not found");

            _dietRepository.DeleteDietsOfUser(idUser);
        }

        public void DeleteDietsOfUserBetweenDate(long idUser, DateTime startDate, DateTime endDate)
        {
            User? user = _userRepository.GetUserById(idUser);

            if (user == null)
                throw new UserNotFoundException("User not found");

            _dietRepository.DeleteDietsOfUserBetweenDate(idUser, startDate, endDate);
        }


    }
}
