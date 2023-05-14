using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;

public class CustomExercise {

    //TODO Creare un Enum inerente ai muscoli / target

    public int Id { get; set; }
    public long IdUser { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Method{ get; set; }
    public string Image { get; set; }
    public string Video { get; set; }
    public int Duration { get; set; }
    public byte Difficulty { get; set; }
    public int Calories { get; set; }
    public string Target { get; set; }
    public bool Private { get; set; }

    public CustomExercise(int id, int idUser, string name, string description, string method, string image, string video, int duration, byte difficulty, int calories, string target, bool privato)
    {
        Id = id;
        IdUser = idUser;
        Name = name;
        Description = description;
        Method = method;
        Image = image;
        Video = video;
        Duration = duration;
        Difficulty = difficulty;
        Calories = calories;
        Target = target;
        Private = privato;
    }

    public CustomExercise(int idUser, string name, string description, string method, string image, string video, int duration, byte difficulty, int calories, string target, bool privato)
    {
        IdUser = idUser;
        Name = name;
        Description = description;
        Method = method;
        Image = image;
        Video = video;
        Duration = duration;
        Difficulty = difficulty;
        Calories = calories;
        Target = target;
        Private = privato;
    }

}
