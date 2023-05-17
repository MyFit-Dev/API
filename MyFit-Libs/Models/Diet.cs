using MyFit_Libs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models
{
    public class Diet
    {
        public long Id { get; set;}

        public long IdUser { get; set;}

        public Dictionary<long, Meal> FoodList { get; set; }

        public DateTime Date { get; set;} 

        public Diet() {}

        public Diet(long id, long idUser, Dictionary<long, Meal> foodList, DateTime date)
        {
            Id = id;
            IdUser = idUser;
            FoodList = foodList;
            Date = date;
        }

        public Diet(long idUser, Dictionary<long, Meal> foodList, DateTime date)
        {
            IdUser = idUser;
            FoodList = foodList;
            Date = date;
        }
    }
}