using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;

public class Gym
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long IdStaff { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int CivicNumber { get; set; }
    public int CAP { get; set; }

    public Gym(string name, long idStaff, string state, string city, string street, int civicNumber, int cAP)
    {
        Name = name;
        IdStaff = idStaff;
        State = state;
        City = city;
        Street = street;
        CivicNumber = civicNumber;
        CAP = cAP;
    }

    public Gym(long id, string name, long idStaff, string state, string city, string street, int civicNumber, int cAP)
    {
        Id = id;
        Name = name;
        IdStaff = idStaff;
        State = state;
        City = city;
        Street = street;
        CivicNumber = civicNumber;
        CAP = cAP;
    }
}