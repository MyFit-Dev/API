using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public long IdUser { get; set; }
        public byte IdType { get; set; }

        public long IdGym { get; set; }

        public Staff() {}

        public Staff(int id, long idUser, byte idType, long idGym)
        {
            Id = id;
            IdUser = idUser;
            IdType = idType;
            IdGym = idGym;
        }

        public Staff(long idUser, byte idType, long idGym)
        {
            IdUser = idUser;
            IdType = idType;
            IdGym = idGym;
        }
    }
}