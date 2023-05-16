using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;

public class Record
{

    //TODO Creare un Enum per la difficoltà
    // TODO Creare dei tipi di Goal e inserire con un Dizionario -> Goal:Value -> Reward
    // TODO Stessa cosa per i Reward Reward:Amount

    public int Id { get; set; }
    public string Name { get; set; }
    public string Goal { get; set; }
    public string? Reward { get; set; }
    public int Difficulty { get; set; }

    public Record() {}

    public Record(int id, string name, string goal, string? reward, int difficulty)
    {
        Id = id;
        Name = name;
        Goal = goal;
        Reward = reward;
        Difficulty = difficulty;
    }

    public Record(string name, string goal, string? reward, int difficulty)
    {
        Name = name;
        Goal = goal;
        Reward = reward;
        Difficulty = difficulty;
    }

}