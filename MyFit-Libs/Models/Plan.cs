using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;

public class Plan
{

    public byte Id { get; set; }
    public string Name  { get; set; }
    public byte Value { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }

    public Plan() {}

    public Plan(string name, byte value, float price, string description)
    {
        Name = name;
        Value = value;
        Price = price;
        Description = description;
    }

    public Plan(byte id, string name, byte value, float price, string description)
    {
        Id = id;
        Name = name;
        Value = value;
        Price = price;
        Description = description;
    }
}