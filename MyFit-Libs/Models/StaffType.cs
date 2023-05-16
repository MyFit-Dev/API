using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;

public class StaffType
{
    public byte Id { get; set; }
    public string Name { get; set; }

    public StaffType() {}

    public StaffType(string name)
    {
        Name = name;
    }

    public StaffType(byte id, string name)
    {
        Id = id;
        Name = name;
    }
}