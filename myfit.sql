/* SQLINES DEMO *** abase [MyFit]    Script Date: 15/05/2023 21:49:52 ******/
CREATE DATABASE `MyFit`;

USE `MyFit`;

/* SQLINES DEMO *** le [MyFit].[dbo].[Plan]    Script Date: 15/05/2023 21:53:21 ******/


CREATE TABLE `MyFit`.`Plan`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Name` varchar(32) NOT NULL,
	`Value` int NOT NULL,
	`Price` Double NOT NULL,
	`Description` varchar(400) NOT NULL,
	PRIMARY KEY (`Id`) 
);


CREATE TABLE `MyFit`.`User`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Name` varchar(32) NOT NULL,
	`Surname` varchar(64) NOT NULL,
	`Mail` varchar(128) NOT NULL,
	`State` varchar(64) NOT NULL,
	`City` varchar(64) NOT NULL,
	`IdPlan` int NOT NULL,
	`IdGym` int NULL,
	`IntermittentFasting` Tinyint NOT NULL,
	PRIMARY KEY (`Id`) 
);

ALTER TABLE `MyFit`.`User` ADD FOREIGN KEY(`IdPlan`)
REFERENCES `MyFit`.`Plan` (`Id`);

/* SQLINES DEMO *** le [MyFit].[dbo].[StaffType]    Script Date: 15/05/2023 21:54:51 ******/


CREATE TABLE `MyFit`.`StaffType`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Name` varchar(16) NOT NULL,
	PRIMARY KEY (`Id`) 
);

/* SQLINES DEMO *** le [MyFit].[dbo].[CustomExercise]    Script Date: 15/05/2023 21:55:30 ******/


CREATE TABLE `MyFit`.`CustomExercise`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`IdUser` int NOT NULL,
	`Name` varchar(64) NOT NULL,
	`Description` varchar(255) NOT NULL,
	`Method` varchar(480) NOT NULL,
	`Image` varchar(64) NOT NULL,
	`Video` varchar(64) NOT NULL,
	`Duration` int NOT NULL,
	`Difficulty` int NOT NULL,
	`Calories` int NOT NULL,
	`Target` varchar(255) NOT NULL,
	`Private` Tinyint NOT NULL,
	PRIMARY KEY (`Id`) 
);

ALTER TABLE `MyFit`.`CustomExercise` ADD FOREIGN KEY(`IdUser`)
REFERENCES `MyFit`.`User` (`Id`);

/* SQLINES DEMO *** le [MyFit].[dbo].[Staff]    Script Date: 15/05/2023 21:56:18 ******/


CREATE TABLE `MyFit`.`Staff`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`IdUser` int NOT NULL,
	`IdType` int NOT NULL,
	PRIMARY KEY (`Id`) 
);

ALTER TABLE `MyFit`.`Staff` ADD FOREIGN KEY(`IdType`)
REFERENCES `MyFit`.`StaffType` (`Id`);

ALTER TABLE `MyFit`.`Staff` ADD FOREIGN KEY(`IdUser`)
REFERENCES `MyFit`.`User` (`Id`);

/* SQLINES DEMO *** le [MyFit].[dbo].[Gym]    Script Date: 15/05/2023 21:57:16 ******/


CREATE TABLE `MyFit`.`Gym`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Name` varchar(54) NOT NULL,
	`IdStaff` int NOT NULL,
	`State` varchar(64) NOT NULL,
	`City` varchar(64) NOT NULL,
	`Street` varchar(64) NOT NULL,
	`CivicNumber` int NOT NULL,
	`CAP` int NOT NULL,
	PRIMARY KEY (`Id`) 
);

ALTER TABLE `MyFit`.`Gym` ADD FOREIGN KEY(`IdStaff`)
REFERENCES `MyFit`.`Staff` (`Id`);

/* SQLINES DEMO *** le [MyFit].[dbo].[Record]    Script Date: 15/05/2023 21:58:11 ******/


CREATE TABLE `MyFit`.`Record`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Name` varchar(64) NOT NULL,
	`Goal` varchar(200) NOT NULL,
	`Difficulty` int NOT NULL,
	`Reward` varchar(64) NULL,
	PRIMARY KEY (`Id`) 
);

/* SQLINES DEMO *** le [MyFit].[dbo].[DataRecord]    Script Date: 15/05/2023 21:58:35 ******/


CREATE TABLE `MyFit`.`DataRecord`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`IdRecord` int NOT NULL,
	`IdUser` int NOT NULL,
	`Date` Datetime(0) NOT NULL,CONSTRAINT `PK_DataRecord` 	PRIMARY KEY (`Id`) 
);

/* SQLINES DEMO *** le [MyFit].[dbo].[Permission]    Script Date: 15/05/2023 21:59:46 ******/


CREATE TABLE `MyFit`.`Permission`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Name` varchar(64) NOT NULL,
	`Value` int NOT NULL,
	PRIMARY KEY (`Id`) 
);

/* SQLINES DEMO *** le [MyFit].[dbo].[GenericExercise]    Script Date: 15/05/2023 22:00:07 ******/


CREATE TABLE `MyFit`.`GenericExercise`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Name` varchar(100) NOT NULL,
	`Description` varchar(255) NOT NULL,
	`Method` varchar(480) NOT NULL,
	`Image` varchar(64) NOT NULL,
	`Video` varchar(64) NOT NULL,
	`Duration` int NOT NULL,
	`Difficulty` int NOT NULL,
	`Calories` int NOT NULL,
	`Target` varchar(255) NOT NULL,
	PRIMARY KEY (`Id`) 
);

/* SQLINES DEMO *** le [MyFit].[dbo].[Log]    Script Date: 15/05/2023 22:01:00 ******/


CREATE TABLE `MyFit`.`Log`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Text` varchar(255) NOT NULL,
	`Scope` varchar(64) NOT NULL,
	`Date` Datetime(0) NOT NULL,
	`IdUser` int NOT NULL,
	`Value` int NOT NULL,
	PRIMARY KEY (`Id`) 
);

ALTER TABLE `MyFit`.`Log` ADD FOREIGN KEY(`IdUser`)
REFERENCES `MyFit`.`User` (`Id`);

/* SQLINES DEMO *** le [MyFit].[dbo].[Message]    Script Date: 15/05/2023 22:01:35 ******/


CREATE TABLE `MyFit`.`Message`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Text` varchar(255) NOT NULL,
	`Date` Datetime(0) NOT NULL,
	`IdSender` int NOT NULL,
	`IdRecipient` int NOT NULL,
	`Displayed` Tinyint NOT NULL,
	PRIMARY KEY (`Id`) 
);

ALTER TABLE `MyFit`.`Message` ADD FOREIGN KEY(`IdRecipient`)
REFERENCES `MyFit`.`User` (`Id`);

ALTER TABLE `MyFit`.`Message` ADD FOREIGN KEY(`IdSender`)
REFERENCES `MyFit`.`User` (`Id`);

/* SQLINES DEMO *** le [MyFit].[dbo].[Diet]    Script Date: 15/05/2023 21:51:19 ******/


CREATE TABLE `MyFit`.`Diet`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`IdUser` int NOT NULL,
	`FoodList` varchar(500) NOT NULL,
	`Date` Datetime(0) NOT NULL,
	PRIMARY KEY (`Id`) 
);

ALTER TABLE `MyFit`.`Diet` ADD FOREIGN KEY(`IdUser`)
REFERENCES `MyFit`.`User` (`Id`);

/* SQLINES DEMO *** le [MyFit].[dbo].[Food]    Script Date: 15/05/2023 22:02:12 ******/


CREATE TABLE `MyFit`.`Food`(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Name` varchar(128) NOT NULL,
	`Description` varchar(255) NOT NULL,
	`Weight` int NULL,
	`Calories` int NOT NULL,
	`Carbs` int NOT NULL,
	`Sugars` int NOT NULL,
	`Proteins` int NOT NULL,
	`Fats` int NOT NULL,
	`Salt` int NOT NULL,
	`Magnesium` int NOT NULL,
	`Iron` int NOT NULL,
	`Potassium` int NOT NULL,
	`Image` varchar(64) NOT NULL,
	PRIMARY KEY (`Id`) 
);