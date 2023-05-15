CREATE TABLE Piani(
    Id int(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(32) NOT NULL,
    Valore int(6) NOT NULL,
    Prezzo float(10) NOT NULL,
    Descrizione VARCHAR(400) NOT NULL
);

CREATE TABLE Utenti(
    Id int(18) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(32) NOT NULL,
    Cognome VARCHAR(64) NOT NULL,
    Mail VARCHAR(128) NOT NULL,
    Nazione VARCHAR(64) NOT NULL,
    Città VARCHAR(64) NOT NULL,
    Id_piano int(5) NOT NULL,
    Id_palestra int(18),
    Digiuno_intermittente BOOLEAN NOT NULL,
    FOREIGN KEY (Id_piano) REFERENCES Piani(Id)
);

CREATE TABLE Staff_Type(
    Id int(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Tipo VARCHAR(16) NOT NULL
);

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

CREATE TABLE Staff(
    Id int(18) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Id_utente int(18) NOT NULL,
    Id_tipo int(5) NOT NULL,
    FOREIGN KEY (Id_tipo) REFERENCES Staff_Type(Id),
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

CREATE TABLE Palestre(
    Id int(18) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(54) NOT NULL,
    Id_staff int(18) NOT NULL, 
    Nazione VARCHAR(64) NOT NULL,
    Città VARCHAR(64) NOT NULL,
    Via VARCHAR(64) NOT NULL,
    Numero_Civico int(8) NOT NULL,
    CAP int(8) NOT NULL,
    FOREIGN KEY (Id_staff) REFERENCES Staff(Id)
);

CREATE TABLE Records(
    Id int(8) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(64) NOT NULL,
    Obbiettivo VARCHAR(200) NOT NULL,
    Difficoltà int(4) NOT NULL
);

CREATE TABLE Data_Record(
    Id int(22) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Id_record int(8) NOT NULL,
    Id_utente int(18) NOT NULL,
    Nome VARCHAR(128) NOT NULL,
    FOREIGN KEY (Id_record) REFERENCES Records(Id),
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

CREATE TABLE Permessi(
    Id int(7) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(64) NOT NULL,
    Valore int(6) NOT NULL
);

CREATE TABLE Esercizi_Generici(
    Id int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Descrizione VARCHAR(255) NOT NULL,
    Procedimento VARCHAR(480) NOT NULL,
    Immagine VARCHAR(64) NOT NULL,
    Video VARCHAR(64) NOT NULL,
    Durata int(9) NOT NULL,
    Difficoltà int(4) NOT NULL,
    Consumo int(11) NOT NULL,
    Target VARCHAR(255) NOT NULL
);

CREATE TABLE Logger(
    Id int(32) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Message VARCHAR(255) NOT NULL,
    Scopo VARCHAR(64) NOT NULL,
    Giorno DATETIME NOT NULL,
    Id_utente int(18) NOT NULL,
    Valore int(3) NOT NULL,
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

CREATE TABLE Messaggi(
    Id int(32) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Messaggio VARCHAR(255) NOT NULL,
    Giorno DATETIME NOT NULL,
    Mittente int(18) NOT NULL,
    Destinatario int(18) NOT NULL,
    Visualizzato BOOLEAN NOT NULL,
    FOREIGN KEY (Destinatario) REFERENCES Utenti(Id),
    FOREIGN KEY (Mittente) REFERENCES Utenti(Id)
);

CREATE TABLE Alimentazioni(
    Id int(18) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Id_utente int(18) NOT NULL,
    Lista_alimenti VARCHAR(500) NOT NULL,
    Giorno DATETIME NOT NULL,
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

CREATE TABLE Schede(
    Id int(26) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Id_utente int(18) NOT NULL,
    Esercizi VARCHAR(320) NOT NULL,
    Esercizi_custom VARCHAR(320) NOT NULL,
    FOREIGN KEY (Id_utente) REFERENCES Utenti(Id)
);

CREATE TABLE Alimenti(
    Id int(32) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(128) NOT NULL,
    Descrizione VARCHAR(255) NOT NULL,
    Peso VARCHAR(16) NOT NULL,
    Calorie int(8) NOT NULL,
    Carboidrati INT(8) NOT NULL,
    Zuccheri INT(8) NOT NULL,
    Proteine INT(8) NOT NULL,
    Grassi INT(8) NOT NULL,
    Sale INT(8) NOT NULL,
    Magnesio INT(8) NOT NULL,
    Ferro INT(8) NOT NULL,
    Potassio INT(8) NOT NULL,
    Immagine VARCHAR(64) NOT NULL
);
