using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models
{
    public class Food
    {

        public long Id { get; set;}
        public string Nome { get; set;}
        public string? Description { get; set;}
        public int Weight { get; set;}
        public byte Calories { get; set;}
        public byte Carbs { get; set;}
        public byte Sugars { get; set;}
        public byte Proteins { get; set;}
        public byte Fats { get; set;}
        public byte Salt { get; set;}
        public byte Magnesium { get; set;}
        public byte Iron { get; set;}
        public byte Potassium { get; set;}
        public string? Image { get; set;}


        public Food()
        {

        }
        
        public Food(long id, string nome, string? description, int weight, byte calories, byte carbs, byte sugars, byte proteins, byte fats, byte salt, byte magnesium, byte iron, byte potassium, string image)
        {
            Id = id;
            Nome = nome;
            Description = description;
            Weight = weight;
            Calories = calories;
            Carbs = carbs;
            Sugars = sugars;
            Proteins = proteins;
            Fats = fats;
            Salt = salt;
            Magnesium = magnesium;
            Iron = iron;
            Potassium = potassium;
            Image = image;
        }

        public Food(string nome, string? description, int weight, byte calories, byte carbs, byte sugars, byte proteins, byte fats, byte salt, byte magnesium, byte iron, byte potassium, string image)
        {
            Nome = nome;
            Description = description;
            Weight = weight;
            Calories = calories;
            Carbs = carbs;
            Sugars = sugars;
            Proteins = proteins;
            Fats = fats;
            Salt = salt;
            Magnesium = magnesium;
            Iron = iron;
            Potassium = potassium;
            Image = image;
        }
        
    }
}