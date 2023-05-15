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
    public DateTime Date { get; set; }
    
    public DataRecord() { 
    
    }

    public DataRecord(long id, int idRecord, long idUser, DateTime date)
    {
        Id = id;
        IdRecord = idRecord;
        IdUser = idUser;
        Date = date;
    }

    public DataRecord(int idRecord, long idUser, DateTime date)
    {
        IdRecord = idRecord;
        IdUser = idUser;
        Date = date;
    }

}