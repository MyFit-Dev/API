using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;
public class GenericExercise
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description {  get; set; }
    public string Method {  get; set; }
    public string Image {  get; set; }
    public string Video {  get; set; }
    public int Duration {  get; set; }
    public byte Difficulty {  get; set; }
    public int Calories {  get; set; }
    public string Target { get; set; }

    public GenericExercise() {}

    public GenericExercise(int id, string name, string description, string method, string image, string video, int duration, byte difficulty, int calories, string target)
    {
        Id = id;
        Name = name;
        Description = description;
        Method = method;
        Image = image;
        Video = video;
        Duration = duration;
        Difficulty = difficulty;
        Calories = calories;
        Target = target;
    }
    
    public GenericExercise(string name, string description, string method, string image, string video, int duration, byte difficulty, int calories, string target)
    {
        Name = name;
        Description = description;
        Method = method;
        Image = image;
        Video = video;
        Duration = duration;
        Difficulty = difficulty;
        Calories = calories;
        Target = target;
    }
    

}
