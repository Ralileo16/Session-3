Create Database Discographe
GO
USE Discographe
GO


/*************************************************************
 Table: PISTE

*************************************************************/

Create Table [Piste]([ID] int IDENTITY(1,1) NOT NULL, [Titre] varchar(200) NOT NULL, [Dur�e] datetime NOT NULL, [FK_Album_ID] int NOT NULL)
GO

/*************************************************************
 Table: ALBUM

*************************************************************/

Create Table [Album]([ID] int IDENTITY(1,1) NOT NULL, [Titre] varchar(200) NOT NULL, [FK_Cat�gorie_ID] int NOT NULL)
GO

/*************************************************************
 Table: ARTISTE

*************************************************************/

Create Table [Artiste]([ID] int IDENTITY(1,1) NOT NULL, [Nom] varchar(200) NOT NULL)
GO

/*************************************************************
 Table: CAT�GORIE

*************************************************************/

Create Table [Cat�gorie]([ID] int IDENTITY(1,1) NOT NULL, [Nom] varchar(200) NOT NULL)
GO

/*************************************************************
 Table: FK_ALBUM_ARTISTE

*************************************************************/

Create Table [FK_Album_Artiste]([nID] int IDENTITY(1,1) NOT NULL, [FK_Album_ID] int NOT NULL, [FK_Artiste_ID] int NOT NULL)
GO



/*************************************************************
 CR�ATION DES CL�S PRIMAIRES
*************************************************************/

ALTER Table [Piste] WITH NOCHECK ADD Constraint [PK_Piste] PRIMARY KEY  CLUSTERED ([ID])
GO

ALTER Table [Album] WITH NOCHECK ADD Constraint [PK_Album] PRIMARY KEY  CLUSTERED ([ID])
GO

ALTER Table [Artiste] WITH NOCHECK ADD Constraint [PK_Artiste] PRIMARY KEY  CLUSTERED ([ID])
GO

ALTER Table [Cat�gorie] WITH NOCHECK ADD Constraint [PK_Cat�gorie] PRIMARY KEY  CLUSTERED ([ID])
GO

ALTER Table [FK_Album_Artiste] WITH NOCHECK ADD Constraint [PK_FK_Album_Artiste] PRIMARY KEY  CLUSTERED ([nID])
GO


/*************************************************************
 CR�ATION DES R�F�RENCES POUR LES CL�S MIGR�S
*************************************************************/

Alter table [FK_Album_Artiste] ADD CONSTRAINT [FK_Album_IDe005] foreign key ([FK_Album_ID]) references [Album]([ID])
GO
Alter table [Album] ADD CONSTRAINT [FK_Cat�gorie_IDe002] foreign key ([FK_Cat�gorie_ID]) references [Cat�gorie]([ID])
GO
Alter table [Piste] ADD CONSTRAINT [FK_Album_IDe001] foreign key ([FK_Album_ID]) references [Album]([ID])
GO
Alter table [FK_Album_Artiste] ADD CONSTRAINT [FK_Artiste_IDe005] foreign key ([FK_Artiste_ID]) references [Artiste]([ID])
GO



/*************************************************************
 AJOUTS DES CAT�GORIES
*************************************************************/
INSERT INTO Cat�gorie (Nom) VALUES ('Classique')
INSERT INTO Cat�gorie (Nom) VALUES ('Rock classique')
INSERT INTO Cat�gorie (Nom) VALUES ('Alternatif')
INSERT INTO Cat�gorie (Nom) VALUES ('Rock & Roll')
INSERT INTO Cat�gorie (Nom) VALUES ('M�tal')
INSERT INTO Cat�gorie (Nom) VALUES ('Blues')
INSERT INTO Cat�gorie (Nom) VALUES ('Pop')
INSERT INTO Cat�gorie (Nom) VALUES ('Francophone')
GO


/*************************************************************
 AJOUTS DES ARTISTES
*************************************************************/
INSERT INTO Artiste (Nom) VALUES ('Rush')
INSERT INTO Artiste (Nom) VALUES ('Our Lady Peace')
INSERT INTO Artiste (Nom) VALUES ('Noir Silence')
INSERT INTO Artiste (Nom) VALUES ('Creed')
INSERT INTO Artiste (Nom) VALUES ('Eric Clapton')
INSERT INTO Artiste (Nom) VALUES ('Guns & Roses')
INSERT INTO Artiste (Nom) VALUES ('Supertramp')
INSERT INTO Artiste (Nom) VALUES ('AC/DC')
INSERT INTO Artiste (Nom) VALUES ('Linkin Park')
INSERT INTO Artiste (Nom) VALUES ('Gaston Mandeville')
INSERT INTO Artiste (Nom) VALUES ('Tom Jones')
INSERT INTO Artiste (Nom) VALUES ('Midnight Oil')
INSERT INTO Artiste (Nom) VALUES ('Collective Soul')
INSERT INTO Artiste (Nom) VALUES ('Jewel')
INSERT INTO Artiste (Nom) VALUES ('BB King')
INSERT INTO Artiste (Nom) VALUES ('REM')
INSERT INTO Artiste (Nom) VALUES ('Aerosmith')
INSERT INTO Artiste (Nom) VALUES ('Cyndi Lauper')
INSERT INTO Artiste (Nom) VALUES ('Daniel B�langer')
GO


/*************************************************************
 AJOUTS DES ALBUMS
*************************************************************/
INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Pilgrim', 6)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (1, 5)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Happiness is not a fish that you can catch', 3)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (2, 2)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Naveed', 3)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (3, 2)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Clumsy', 3)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (4, 2)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Quatre saisons dans le d�sordre', 8)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (5, 19)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Les ann�es Folk', 8)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (6, 10)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Noir Silence', 8)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (7, 3)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Green', 3)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (8, 16)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Back In Black', 2)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (9, 8)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Razor Edge', 2)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (10, 8)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('The Very Best Of Supertramp', 2)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (11, 7)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('2112', 2)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (12, 1)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Moving Pictures', 2)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (13, 1)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('The Lead and How To Swing It', 7)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (14, 11)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Why I Sing the Blues', 6)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (15, 15)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Hybrid Theory', 3)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (16, 9)

INSERT INTO Album (Titre, FK_Cat�gorie_ID) VALUES ('Les insomniaques s`amusent', 8)
GO
INSERT INTO FK_Album_Artiste (FK_Album_ID, FK_Artiste_ID) VALUES (17, 19)


/*************************************************************
 AJOUTS DES PISTES
*************************************************************/
