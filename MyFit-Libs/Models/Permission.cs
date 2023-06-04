using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models; 

public class Permission
{
    public int Id { get; set; }
    public string Name { get; set; }
    public byte Value { get; set; }

    public Permission() {} 

    public Permission(int id, string name, byte value)
    {
        Id = id;
        Name = name;
        Value = value;
    }

    public Permission(string name, byte value)
    {
        Name = name;
        Value = value;
    }
}