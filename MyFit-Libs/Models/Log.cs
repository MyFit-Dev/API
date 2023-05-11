using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFit_Libs.Models; 

    public class Log
    {
    

    /*
CREATE TABLE Logger(
Id int(32) NOT NULL AUTO_INCREMENT PRIMARY KEY,
Message VARCHAR(255) NOT NULL,
Scopo VARCHAR(64) NOT NULL,
Giorno DATETIME NOT NULL,
Id_utente int(18) NOT NULL,
Valore int(3) NOT NULL,
FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
   )   ;
*/

    // TODO Creare un Enum riguardante gli Scope
    // TODO Creare un Enum inerente all'Importanza (Value)

    public long Id { get; set; }
        public string Text { get; set; }
        public string Scope { get; set; }
        public DateTime Date { get; set; }
        public long IdUtente { get; set; }
        public byte Value { get ; set; }

        public Log(long id, string text, string scope, DateTime date, long idUtente, byte value)
        {
            Id = id;
            Text = text;
            Scope = scope;
            Date = date;
            IdUtente = idUtente;
            Value = value;
        }

        public Log(string text, string scope, DateTime date, long idUtente, byte value)
        {
            Text = text;
            Scope = scope;
            Date = date;
            IdUtente = idUtente;
            Value = value;
        }
    }
