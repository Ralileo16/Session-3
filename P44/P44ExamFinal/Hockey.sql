USE Master
GO
if exists(SELECT Name from master..sysdatabases WHERE Name LIKE 'Hockey')
BEGIN
	print '***********************************************************************************************'
	print 'Suppression de la base de données Hockey existante...'
	print '***********************************************************************************************'
	Drop Database Hockey
END

/* *********************************************************************************************** */
print ' '
print '***********************************************************************************************'
print 'Création de la base de données Hockey en cours...'
print '***********************************************************************************************'
GO

Create Database Hockey
GO
USE Hockey
GO

/*********************** T_Equipes **************************************/
Create Table T_Equipes
(
	Equ_no 		 int 	IDENTITY(1,1) 	NOT NULL PRIMARY KEY, 
	Equ_Nom	 varchar(50) 			NOT NULL, 
	Equ_Ville 	 varchar(50) 			NOT NULL
)

/*********************** T_Joueurs **************************************/
Create Table T_Joueurs
(
	Jou_no 		 int 	IDENTITY(1,1) 	NOT NULL PRIMARY KEY, 
	Equ_no                    int not null,
	Jou_nom 		        varchar(50) 		NOT NULL, 
	Jou_Prenom		    varchar(50) 		NOT NULL, 
	Jou_Position		     varchar(2),
	Jou_Buts		 int,
	Jou_Passes		 int,
        Jou_Telephone varchar(14) 
)
go
/********************** FORMATS DE SAISIE  ***************************/
ALTER TABLE T_Joueurs
 ADD CONSTRAINT [Telephone_Masque] 
 CHECK (Jou_Telephone LIKE '([0-9][0-9][0-9]) [0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
ALTER TABLE T_Joueurs
 ADD CONSTRAINT [Position_Masque] 
 CHECK   (Jou_Position in ('AD','AG','CE','DD','DG','GB'))
GO

/********************** INTÉGRITÉ RÉFÉRENTIELLE **********************/
ALTER TABLE T_Joueurs
 ADD CONSTRAINT [FK_Equ_no] foreign key ([Equ_no])
 references T_Equipes (Equ_no)
GO

/* *********************************************************************************************** */
print ' '
print '***********************************************************************************************'
print 'Ajout d`enregistrements de base...'
print '***********************************************************************************************'
GO


print ' '
print '***********************************************************************************************'
print 'Ajout de T_Equipes...'
print '***********************************************************************************************'
GO

insert into T_Equipes (Equ_nom, Equ_Ville) VALUES ('Canadiens','Montréal')
insert into T_Equipes (Equ_nom, Equ_Ville) VALUES ('Bruins','Boston')
insert into T_Equipes (Equ_nom, Equ_Ville) VALUES ('Rangers','New York')
insert into T_Equipes (Equ_nom, Equ_Ville) VALUES ('Black Hawks','Chicago')
insert into T_Equipes (Equ_nom, Equ_Ville) VALUES ('Red Wings','Détroit')

GO
print ' '
print '***********************************************************************************************'
print 'Ajout de T_Joueurs...'
print '***********************************************************************************************'
GO
insert into T_Joueurs (Equ_No,Jou_nom,Jou_prenom,Jou_Position,Jou_Buts,Jou_Passes, Jou_Telephone) VALUES (1, 'Caufield', 'Cole', 'AD', 20,30, '(817) 882-1292')
insert into T_Joueurs (Equ_No,Jou_nom,Jou_prenom,Jou_Position,Jou_Buts,Jou_Passes, Jou_Telephone) VALUES (2, 'Bergeron', 'Patrice', 'CE', 30,35, '(817) 123-4567')
insert into T_Joueurs (Equ_No,Jou_nom,Jou_prenom,Jou_Position,Jou_Buts,Jou_Passes, Jou_Telephone) VALUES (3, 'Panarin', 'Artemi', 'AD', 35,55, '(817) 885-5555')
insert into T_Joueurs (Equ_No,Jou_nom,Jou_prenom,Jou_Position,Jou_Buts,Jou_Passes, Jou_Telephone) VALUES (1, 'Weber', 'Shea', 'DG', 23,30, '(817) 884-4444')
insert into T_Joueurs (Equ_No,Jou_nom,Jou_prenom,Jou_Position,Jou_Buts,Jou_Passes, Jou_Telephone) VALUES (1, 'Tomas', 'Tatar', 'AG', 18,30, '(817) 886-6666')
insert into T_Joueurs (Equ_No,Jou_nom,Jou_prenom,Jou_Position,Jou_Buts,Jou_Passes, Jou_Telephone) VALUES (2, 'Krejci', 'David', 'CE', 22,74, '(817) 887-7777')
insert into T_Joueurs (Equ_No,Jou_nom,Jou_prenom,Jou_Position,Jou_Buts,Jou_Passes, Jou_Telephone) VALUES (2, 'Marchand', 'Brad', 'AG', 11,32, '(817) 333-3333')
insert into T_Joueurs (Equ_No,Jou_nom,Jou_prenom,Jou_Position,Jou_Buts,Jou_Passes, Jou_Telephone) VALUES (3, 'Lafreniere', 'Alexis', 'AG', 18,30, '(817) 222-2222')
insert into T_Joueurs (Equ_No,Jou_nom,Jou_prenom,Jou_Position,Jou_Buts,Jou_Passes, Jou_Telephone) VALUES (4, 'Kane', 'Patrick', 'AD', 25,32, '(888) 112-2233')
insert into T_Joueurs (Equ_No,Jou_nom,Jou_prenom,Jou_Position,Jou_Buts,Jou_Passes, Jou_Telephone) VALUES (4, 'Toews', 'Jonathan', 'CE', 17,20, '(888) 888-9999')

GO

use master
go

Select 'Base de données Hockey créée'
print ' '
print '***********************************************************************************************'
print 'Base de données Hockey créée...'
print '***********************************************************************************************'
GO