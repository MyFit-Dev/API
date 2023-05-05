using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models
{

/*
  CREATE TABLE Alimentazioni(
    Id int(18) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Id_utente int(18) NOT NULL,
    Lista_alimenti VARCHAR(500) NOT NULL,
    Giorno DATETIME NOT NULL,
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
  );  
*/

    public class Diets
    {
        public long Id { get; set;}

        public long IdUser { get; set;}

        //Lista alimenti Food;Amount;Past

        public DateTime Date { get; set;} 
    }
}