using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFit_Libs.Models
{
	public class CustomExercise
	{
        /*
		// TODO: Add constructor logic here

		CREATE TABLE Esercizi_Custom(
    Id int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Id_utente int(18) NOT NULL,
    Nome VARCHAR(64) NOT NULL,
    Descrizione VARCHAR(255) NOT NULL,
    Procedimento VARCHAR(480) NOT NULL,
    Immagine VARCHAR(64) NOT NULL,
    Video VARCHAR(64) NOT NULL,
    Durata int(9) NOT NULL,
    Difficoltà int(4) NOT NULL,
    Consumo int(11) NOT NULL,
    Target VARCHAR(255) NOT NULL,
    Privato BOOLEAN NOT NULL,
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);
		*/

        public int Id { get; set; }
        public long IdUtente { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Method{ get; set: }
        public string Image { get; set; }
        public string Video { get; set; }
        public int Duration { get; set; }
        public byte Difficulty { get; set; }
        public int Calories { get; set; }
        public string Target { get; set; }
        public bool Private { get; set; }

        public GenericExercise(int id, int idUtente, string name, string description, string method, string image, string video, int duration, byte difficulty, int calories, string target, bool privato)
        {
            Id = id;
            IdUtente = idUtente;
            Name = name;
            Description = description;
            Method = method;
            Image = image;
            Video = video;
            Duration = duration;
            Difficulty = difficulty;
            Calories = calories;
            Target = target;
            Private = privato;
        }

        public GenericExercise(int idUtente, string name, string description, string method, string image, string video, int duration, byte difficulty, int calories, string target, bool privato)
        {
            IdUtente = idUtente;
            Name = name;
            Description = description;
            Method = method;
            Image = image;
            Video = video;
            Duration = duration;
            Difficulty = difficulty;
            Calories = calories;
            Target = target;
            Private = privato;
        }


    }
}
