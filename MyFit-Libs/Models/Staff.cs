using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models
{
    public class Staff
    {
        public string Id { get; set; }
        public int IdUser { get; set; }
        public int IdType { get; set; }

        public Staff(string id, int idUser, int idType)
        {
            Id = id;
            IdUser = idUser;
            IdType = idType;
        }

        public Staff(int idUser, int idType)
        {
            IdUser = idUser;
            IdType = idType;
        }
    }
}