CREATE TABLE Utenti(
    Id int(18) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(32) NOT NULL,
    Cognome VARCHAR(64) NOT NULL,
    Mail VARCHAR(128) NOT NULL,
    Password VARCHAR(128) NOT NULL,
    Nazione VARCHAR(64) NOT NULL,
    Città VARCHAR(64) NOT NULL,
    Indirizzo VARCHAR(128) NOT NULL,
    Id_piano int(5) NOT NULL,
    Id_palestra int(18) NOT NULL,
    Digiuno_intermittente BOOLEAN NOT NULL
);

CREATE TABLE Staff_Type(
    Id int(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Tipo VARCHAR(16) NOT NULL
);

CREATE TABLE Palestre(
    Id int(18) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(54) NOT NULL,
    Id_staff int(18) NOT NULL,
    Indirizzo VARCHAR(128) NOT NULL
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
    Privato BOOLEAN NOT NULL
);

CREATE TABLE Piani(
    Id int(5) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(32) NOT NULL,
    Valore int(6) NOT NULL,
    Prezzo float(10) NOT NULL,
    Descrizione VARCHAR(400) NOT NULL
);

CREATE TABLE Staff(
    Id int(18) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Id_utente int(18) NOT NULL,
    Id_palestra int(18) NOT NULL,
    Id_tipo int(5) NOT NULL
);

CREATE TABLE Data_Record(
    Id int(22) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Id_record int(8) NOT NULL,
    Id_utente int(18) NOT NULL,
    Nome VARCHAR(128) NOT NULL
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
    Id_utente int(18) NOT NULL
);

CREATE TABLE Records(
    Id int(8) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(64) NOT NULL,
    Obbiettivo VARCHAR(200) NOT NULL,
    Difficoltà int(4) NOT NULL
);

CREATE TABLE Messaggi(
    Id int(32) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Messaggio VARCHAR(255) NOT NULL,
    Giorno DATETIME NOT NULL,
    Mittente int(18) NOT NULL,
    Destinatario int(18) NOT NULL,
    Visualizzato BOOLEAN NOT NULL
);

CREATE TABLE Alimentazioni(
    Id int(18) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Id_utente int(18) NOT NULL,
    Lista_alimenti VARCHAR(500) NOT NULL,
    Giorno DATETIME NOT NULL
);

CREATE TABLE Schede(
    Id int(26) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Id_utente int(18) NOT NULL,
    Esercizi VARCHAR(320) NOT NULL,
    Esercizi_custom VARCHAR(320) NOT NULL
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

ALTER TABLE
    "Schede" ADD CONSTRAINT "schede_id_utente_foreign" FOREIGN KEY("id_utente") REFERENCES "Utenti"("id");
ALTER TABLE
    "Utenti" ADD CONSTRAINT "utenti_id_palestra_foreign" FOREIGN KEY("id_palestra") REFERENCES "Palestre"("id");
ALTER TABLE
    "Data_Record" ADD CONSTRAINT "data_record_id_record_foreign" FOREIGN KEY("id_record") REFERENCES "Records"("id");
ALTER TABLE
    "Messaggi" ADD CONSTRAINT "messaggi_sender_foreign" FOREIGN KEY("sender") REFERENCES "Utenti"("id");
ALTER TABLE
    "Data_Record" ADD CONSTRAINT "data_record_id_utente_foreign" FOREIGN KEY("id_utente") REFERENCES "Utenti"("id");
ALTER TABLE
    "Log" ADD CONSTRAINT "log_id_utente_foreign" FOREIGN KEY("id_utente") REFERENCES "Utenti"("id");
ALTER TABLE
    "Staff" ADD CONSTRAINT "staff_id_palestra_foreign" FOREIGN KEY("id_palestra") REFERENCES "Palestre"("id");
ALTER TABLE
    "Alimentazioni" ADD CONSTRAINT "alimentazioni_id_utente_foreign" FOREIGN KEY("id_utente") REFERENCES "Utenti"("id");
ALTER TABLE
    "Staff" ADD CONSTRAINT "staff_id_utente_foreign" FOREIGN KEY("id_utente") REFERENCES "Utenti"("id");
ALTER TABLE
    "Esercizi-Custom" ADD CONSTRAINT "esercizi_custom_id_utente_foreign" FOREIGN KEY("id_utente") REFERENCES "Utenti"("id");
ALTER TABLE
    "Messaggi" ADD CONSTRAINT "messaggi_receiver_foreign" FOREIGN KEY("receiver") REFERENCES "Utenti"("id");
ALTER TABLE
    "Staff" ADD CONSTRAINT "staff_tipo_foreign" FOREIGN KEY("tipo") REFERENCES "Staff-Type"("id");
ALTER TABLE
    "Palestre" ADD CONSTRAINT "palestre_id_staff_foreign" FOREIGN KEY("id_staff") REFERENCES "Staff"("id");
ALTER TABLE
    "Utenti" ADD CONSTRAINT "utenti_id_piano_foreign" FOREIGN KEY("id_piano") REFERENCES "Piani"("id");