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
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Meal()
        {
        }

        public Meal(Food food, int amount, int hour, int minute)
        {
            Food = food;
            Amount = amount;
            Hour = hour;
            Minute = minute;
        }

    }
}
