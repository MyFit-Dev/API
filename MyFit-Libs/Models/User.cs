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
    public string Street { get; set; }
    public int CivicNumber { get; set; }
    public int CAP { get; set; }

    public int IdPlan { get; set;}

    public int IdGym { get; set;}

    public bool IntermittentFasting { get; set;}

    public User(string name, string surname, string mail, string state, string city, string street, int civicNumber, int cAP, int idPlan, int idGym, bool intermittentFasting)
    {
        Name = name;
        Surname = surname;
        Mail = mail;
        State = state;
        City = city;
        Street = street;
        CivicNumber = civicNumber;
        CAP = cAP;
        IdPlan = idPlan;
        IdGym = idGym;
        IntermittentFasting = intermittentFasting;
    }

    public User(long id, string name, string surname, string mail, string state, string city, string street, int civicNumber, int cAP, int idPlan, int idGym, bool intermittentFasting)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Mail = mail;
        State = state;
        City = city;
        Street = street;
        CivicNumber = civicNumber;
        CAP = cAP;
        IdPlan = idPlan;
        IdGym = idGym;
        IntermittentFasting = intermittentFasting;
    }

}