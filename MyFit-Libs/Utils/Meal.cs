using MyFit_Libs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFit_Libs.Utils
{
    public class Meal
    {

        public Food Food { get; set; }
        public int Amount { get; set; }

        public Meal()
        {
        }

        public Meal(Food food, int amount)
        {
            Food = food;
            Amount = amount;
        }

        public override bool Equals(object? obj)
        {
            return obj is Meal meal &&
                   EqualityComparer<Food>.Default.Equals(Food, meal.Food) &&
                   Amount == meal.Amount;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
