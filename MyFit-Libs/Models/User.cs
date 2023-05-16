using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;

public class User {

    public long Id { get; set;}
    public string Name { get; set;}
    public string Surname { get; set;}
    public string Mail { get; set;}
    public string State { get; set; }
    public string City { get; set; }
    public int IdPlan { get; set;}
    public int? IdGym { get; set;}
    public bool IntermittentFasting { get; set;}

    public User() {}

    public User(string name, string surname, string mail, string state, string city, int idPlan, int? idGym, bool intermittentFasting)
    {
        Name = name;
        Surname = surname;
        Mail = mail;
        State = state;
        City = city;
        IdPlan = idPlan;
        IdGym = idGym;
        IntermittentFasting = intermittentFasting;
    }

    public User(long id, string name, string surname, string mail, string state, string city, int idPlan, int? idGym, bool intermittentFasting)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Mail = mail;
        State = state;
        City = city;
        IdPlan = idPlan;
        IdGym = idGym;
        IntermittentFasting = intermittentFasting;
    }

}