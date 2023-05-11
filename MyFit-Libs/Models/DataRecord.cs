using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models;

public class DataRecord
{

    public long Id { get; set; }
    public int IdRecord { get; set; }
    public long IdUser { get; set; }
    public string Name { get; set; }
    
    public DataRecord(long id, int idRecord, long idUser, string name)
    {
        Id = id;
        IdRecord = idRecord;
        IdUser = idUser;
        Name = name;
    }

    public DataRecord(int idRecord, long idUser, string name)
    {
        IdRecord = idRecord;
        IdUser = idUser;
        Name = name;
    }

}