using MyFit_API.Exceptions.FoodException;
using MyFit_API.Repositories;
using MyFit_Libs.Models;
using System.Xml.Linq;

namespace MyFit_API.Services
{
    public class FoodService
    { 
        private FoodRepository _foodRepository = new FoodRepository();

        public List<Food> GetAllFoods()
        {
            List<Food>? foods = _foodRepository.GetAllFoods();

            return foods != null ? foods : throw new FoodNotFoundException("Foods not found");
        }

        public List<Food> GetSimilarFoods(string name, int results)
        {
            List<Food>? foods = _foodRepository.GetSimilarFoods(name, results);

            return foods != null ? foods : throw new FoodNotFoundException("Foods not found");
        }

        public long CountFoods()
        {
            return _foodRepository.CountFoods();
        }

        public Food? GetFood(long id)
        {
            Food? food = _foodRepository.GetFood(id);

            return food != null ? food : throw new FoodNotFoundException("Food not found");
        }

        public void AddFood(Food food)
        {
            _foodRepository.AddFood(food);
        }

        public void DeleteFood(long id) 
        {
            if (!_foodRepository.ExistsFood(id))
                throw new FoodNotFoundException("Food not found");

            _foodRepository.DeleteFood(id);
        }

        public void UpdateFood(Food food, long id)
        {
            if (!_foodRepository.ExistsFood(id))
                throw new FoodNotFoundException("Food not found");

            _foodRepository.DeleteFood(id);
            _foodRepository.AddFood(food);
        }
    }
}
