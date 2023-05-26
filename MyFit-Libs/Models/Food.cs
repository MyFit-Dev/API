using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models
{
    public class Food
    {

        public long Id { get; set;}
        public string Name { get; set;}
        public string? Description { get; set;}
        public int Weight { get; set;}
        public int Calories { get; set;}
        public byte Carbs { get; set;}
        public byte? Fibers { get; set;}
        public byte Sugars { get; set;}
        public byte Proteins { get; set;}
        public byte Fats { get; set;}
        public byte? Saturated_Fats { get; set;}
        public byte? Polyunsaturated_Fats { get; set;}
        public byte? Monounsaturated_Fats { get; set;}
        public byte? Cholesterol { get; set;}
        public byte? Trans_Fats { get; set;}
        public byte Salt { get; set;}
        public byte? Magnesium { get; set;}
        public byte? Calcium { get; set;}
        public byte? Iron { get; set;}
        public byte? Potassium { get; set;}
        public byte? Vitamin_A { get; set;}
        public byte? Vitamin_B1 { get; set;}
        public byte? Vitamin_B2 { get; set;}
        public byte? Vitamin_B6 { get; set;}
        public byte? Vitamin_B12 { get; set;}
        public byte? Vitamin_C { get; set;}
        public byte? Vitamin_D { get; set;}
        public byte? Vitamin_E { get; set;}
        public string? Image { get; set;}


        public Food() {}

        public Food(long id, string name, string? description, int weight, int calories, byte carbs, byte? fibers, byte sugars, byte proteins, byte fats, byte? saturated_Fats, byte? polyunsaturated_Fats, byte? monounsaturated_Fats, byte? cholesterol, byte? trans_Fats, byte salt, byte? magnesium, byte? calcium, byte? iron, byte? potassium, byte? vitamin_A, byte? vitamin_B1, byte? vitamin_B2, byte? vitamin_B6, byte? vitamin_B12, byte? vitamin_C, byte? vitamin_D, byte? vitamin_E, string? image)
        {
            Id = id;
            Name = name;
            Description = description;
            Weight = weight;
            Calories = calories;
            Carbs = carbs;
            Fibers = fibers;
            Sugars = sugars;
            Proteins = proteins;
            Fats = fats;
            Saturated_Fats = saturated_Fats;
            Polyunsaturated_Fats = polyunsaturated_Fats;
            Monounsaturated_Fats = monounsaturated_Fats;
            Cholesterol = cholesterol;
            Trans_Fats = trans_Fats;
            Salt = salt;
            Magnesium = magnesium;
            Calcium = calcium;
            Iron = iron;
            Potassium = potassium;
            Vitamin_A = vitamin_A;
            Vitamin_B1 = vitamin_B1;
            Vitamin_B2 = vitamin_B2;
            Vitamin_B6 = vitamin_B6;
            Vitamin_B12 = vitamin_B12;
            Vitamin_C = vitamin_C;
            Vitamin_D = vitamin_D;
            Vitamin_E = vitamin_E;
            Image = image;
        }

        public Food(string name, string? description, int weight, int calories, byte carbs, byte? fibers, byte sugars, byte proteins, byte fats, byte? saturated_Fats, byte? polyunsaturated_Fats, byte? monounsaturated_Fats, byte? cholesterol, byte? trans_Fats, byte salt, byte? magnesium, byte? calcium, byte? iron, byte? potassium, byte? vitamin_A, byte? vitamin_B1, byte? vitamin_B2, byte? vitamin_B6, byte? vitamin_B12, byte? vitamin_C, byte? vitamin_D, byte? vitamin_E, string? image)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Calories = calories;
            Carbs = carbs;
            Fibers = fibers;
            Sugars = sugars;
            Proteins = proteins;
            Fats = fats;
            Saturated_Fats = saturated_Fats;
            Polyunsaturated_Fats = polyunsaturated_Fats;
            Monounsaturated_Fats = monounsaturated_Fats;
            Cholesterol = cholesterol;
            Trans_Fats = trans_Fats;
            Salt = salt;
            Magnesium = magnesium;
            Calcium = calcium;
            Iron = iron;
            Potassium = potassium;
            Vitamin_A = vitamin_A;
            Vitamin_B1 = vitamin_B1;
            Vitamin_B2 = vitamin_B2;
            Vitamin_B6 = vitamin_B6;
            Vitamin_B12 = vitamin_B12;
            Vitamin_C = vitamin_C;
            Vitamin_D = vitamin_D;
            Vitamin_E = vitamin_E;
            Image = image;
        }

    }
}