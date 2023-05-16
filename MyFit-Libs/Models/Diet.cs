using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models
{
    public class Diet
    {
        public long Id { get; set;}

        public long IdUser { get; set;}

        //Lista alimenti Food;Amount;Past
        public DateTime Date { get; set;} 

        public Diet() {}
    }
}