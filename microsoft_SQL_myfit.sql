 TABLE Piani(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Nome VARCHAR(32) NOT NULL,
    Valore int NOT NULL,
    Prezzo float NOT NULL,
    Descrizione VARCHAR(400) NOT NULL
);

 TABLE Utenti(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Nome VARCHAR(32) NOT NULL,
    Cognome VARCHAR(64) NOT NULL,
    Mail VARCHAR(128) NOT NULL,
    Nazione VARCHAR(64) NOT NULL,
    Città VARCHAR(64) NOT NULL,
    Id_piano int NOT NULL,
    Id_palestra int,
    Digiuno_intermittente BIT NOT NULL,
    FOREIGN KEY (Id_piano) REFERENCES Piani(Id)
);

 TABLE Staff_Type(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Tipo VARCHAR(16) NOT NULL
);

 TABLE Esercizi_Custom(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Id_utente int NOT NULL,
    Nome VARCHAR(64) NOT NULL,
    Descrizione VARCHAR(255) NOT NULL,
    Procedimento VARCHAR(480) NOT NULL,
    Immagine VARCHAR(64) NOT NULL,
    Video VARCHAR(64) NOT NULL,
    Durata int NOT NULL,
    Difficoltà int NOT NULL,
    Consumo int NOT NULL,
    Target VARCHAR(255) NOT NULL,
    Privato BIT NOT NULL,
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

 TABLE Staff(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Id_utente int NOT NULL,
    Id_tipo int NOT NULL,
    FOREIGN KEY (Id_tipo) REFERENCES Staff_Type(Id),
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

 TABLE Palestre(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Nome VARCHAR(54) NOT NULL,
    Id_staff int NOT NULL, 
    Nazione VARCHAR(64) NOT NULL,
    Città VARCHAR(64) NOT NULL,
    Via VARCHAR(64) NOT NULL,
    Numero_Civico int NOT NULL,
    CAP int NOT NULL,
    FOREIGN KEY (Id_staff) REFERENCES Staff(Id)
);

 TABLE Records(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Nome VARCHAR(64) NOT NULL,
    Obbiettivo VARCHAR(200) NOT NULL,
    Difficoltà int NOT NULL
);

 TABLE Data_Record(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Id_record int NOT NULL,
    Id_utente int NOT NULL,
    Nome VARCHAR(128) NOT NULL,
    FOREIGN KEY (Id_record) REFERENCES Records(Id),
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

 TABLE Permessi(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Nome VARCHAR(64) NOT NULL,
    Valore int NOT NULL
);

 TABLE Esercizi_Generici(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Descrizione VARCHAR(255) NOT NULL,
    Procedimento VARCHAR(480) NOT NULL,
    Immagine VARCHAR(64) NOT NULL,
    Video VARCHAR(64) NOT NULL,
    Durata int NOT NULL,
    Difficoltà int NOT NULL,
    Consumo int NOT NULL,
    Target VARCHAR(255) NOT NULL
);

 TABLE Logger(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Message VARCHAR(255) NOT NULL,
    Scopo VARCHAR(64) NOT NULL,
    Giorno DATETIME2(0) NOT NULL,
    Id_utente int NOT NULL,
    Valore int NOT NULL,
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

 TABLE Messaggi(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Messaggio VARCHAR(255) NOT NULL,
    Giorno DATETIME2(0) NOT NULL,
    Mittente int NOT NULL,
    Destinatario int NOT NULL,
    Visualizzato BIT NOT NULL,
    FOREIGN KEY (Destinatario) REFERENCES Utenti(Id),
    FOREIGN KEY (Mittente) REFERENCES Utenti(Id)
);

 TABLE Alimentazioni(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Id_utente int NOT NULL,
    Lista_alimenti VARCHAR(500) NOT NULL,
    Giorno DATETIME2(0) NOT NULL,
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

 TABLE Schede(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Id_utente int NOT NULL,
    Esercizi VARCHAR(320) NOT NULL,
    Esercizi_custom VARCHAR(320) NOT NULL,
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

 TABLE Alimenti(
    Id int NOT NULL IDENTITY PRIMARY KEY,
    Nome VARCHAR(128) NOT NULL,
    Descrizione VARCHAR(255) NOT NULL,
    Peso VARCHAR(16) NOT NULL,
    Calorie int NOT NULL,
    Carboidrati INT NOT NULL,
    Zuccheri INT NOT NULL,
    Proteine INT NOT NULL,
    Grassi INT NOT NULL,
    Sale INT NOT NULL,
    Magnesio INT NOT NULL,
    Ferro INT NOT NULL,
    Potassio INT NOT NULL,
    Immagine VARCHAR(64) NOT NULL
);
