USE [master]
GO
/****** Object:  Database [W24-TP]    Script Date: 5/21/2024 11:52:59 AM ******/
CREATE DATABASE [W24-TP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'W24-TP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\W24-TP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'W24-TP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\W24-TP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [W24-TP] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [W24-TP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [W24-TP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [W24-TP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [W24-TP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [W24-TP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [W24-TP] SET ARITHABORT OFF 
GO
ALTER DATABASE [W24-TP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [W24-TP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [W24-TP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [W24-TP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [W24-TP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [W24-TP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [W24-TP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [W24-TP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [W24-TP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [W24-TP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [W24-TP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [W24-TP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [W24-TP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [W24-TP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [W24-TP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [W24-TP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [W24-TP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [W24-TP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [W24-TP] SET  MULTI_USER 
GO
ALTER DATABASE [W24-TP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [W24-TP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [W24-TP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [W24-TP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [W24-TP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [W24-TP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [W24-TP] SET QUERY_STORE = ON
GO
ALTER DATABASE [W24-TP] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [W24-TP]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[Img] [nvarchar](256) NULL,
	[Active] [bit] NOT NULL,
	[Stars] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Replies]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Replies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FK_Subject] [int] NOT NULL,
	[FK_User] [nvarchar](450) NOT NULL,
	[Body] [nvarchar](2000) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Replies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 5/21/2024 11:52:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FK_Category] [int] NOT NULL,
	[FK_User] [nvarchar](450) NULL,
	[Title] [nvarchar](500) NOT NULL,
	[Body] [nvarchar](2000) NOT NULL,
	[Date] [datetime] NOT NULL,
	[View] [int] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'8.0.3')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9849fcdf-8896-424e-8a2b-88e6bed86dd4', N'User', N'USER', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9fdfa6c8-964b-4e51-8eff-ecd1c7b1935b', N'Admin', N'ADMIN', NULL)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6226f765-6e82-4753-bc80-775d79b8cfa7', N'9fdfa6c8-964b-4e51-8eff-ecd1c7b1935b')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6226f765-6e82-4753-bc80-775d79b8cfa7', N'Administrator', N'ADMINISTRATOR', N'uwu@uwu.uwu', N'UWU@UWU.UWU', 1, N'AQAAAAIAAYagAAAAEIGz3pD87wkFemRntkiy+BK2mhcMF5TC4chmB8fLoDVCGxZBrWnMeQMRJO+sjDxD6g==', N'F2YTDWIHTLM5MARXRVW4WTJEVY67AKN4', N'ebab8897-083b-457f-bd69-484bffa9196b', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'SmokeUser1', N'SMOKEUSER1', N'smoke1@smoke.com', N'SMOKE1@SMOKE.COM', 1, N'AQAAAAIAAYagAAAAEK4tPmYpKCBEX3aRgxAix5WXXGW2qDfzoahi8OaCaFZYG/gxu/pILmMofjEbZ0dOUQ==', N'DSWJTMPZU2JHFC4LV7OY6PWDYGFDSRS3', N'3d84019a-a0b5-4d13-a096-a39cfedba5f6', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b3e14015-26cf-4371-8255-89a65d48688c', N'SmokeUser2', N'SMOKEUSER2', N'smoke2@smoke.com', N'SMOKE2@SMOKE.COM', 1, N'AQAAAAIAAYagAAAAEHkBRUjPUdGddZXDnynDRqYhAd2xgsZo8tkUQJs37UrUU9X7geB2rpGLr/pWYi5zSw==', N'7PYWU5GQFGLFSK3Y273JL2ENZRKN7N57', N'd8bcf634-635e-4308-a3d1-b2c33ef570f4', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (4, N'Argenti', N'"May this rose convey my heartfelt salutations."', N'argenti.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (5, N'Bailu', N'"Lunch is like medicine — it has to have the right balance of ingredients. Two smoked patties and a cup of milk tea is a great way to heal your heart and lift your spirits!"', N'bailu.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (7, N'Black Swan', N'"If I can identify and encapsulate a fragment of memory before it''s unveiled to the world, those solitary moments of delight are my most favored and unique memories."', N'black_swan.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (8, N'Blade', N'"When will death come for me? My patience is wearing thin."', N'blade.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (9, N'Bronya', N'"This place is always part of our homeland, even when it has been corroded by Fragmentum. Silvermane Guards will never turn their backs on their home.', N'bronya.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (10, N'Clara', N'"Mr. Svarog... is my family."', N'clara.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (11, N'Dan Heng IL', N'"I am nobody''s shadow."', N'dan_heng_IL.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (13, N'Dr. Ratio', N'"The most annoying thing about idiocy is that you can''t explain it to an idiot."', N'dr_ratio.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (14, N'Fu Xuan', N'"Knowledge exchanged with pain."', N'fu_xuan.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (15, N'Gepard', N'"Loyalty isn''t an inherent virtue of humans. As such, the recipient of that loyalty also needs to be worthy."', N'gepard.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (16, N'Himeko', N'"Alright, crew! This world is the target of our next trailblazing expedition!"', N'himeko.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (18, N'Huohuo', N'"I can use this banner to dispel demons... but it also comes in handy when signaling my surrender..."', N'huohuo.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (19, N'Jing Yuan', N'"A truly masterful chess player has no brilliant moves. People clamor excitedly over displays of extreme cunning, forgetting to worry about the overall dangers of the situation."', N'jing_yuan.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (21, N'Jingliu', N'"Whoever wishes to learn my swordplay, I will teach them."', N'jingliu.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (23, N'Kafka', N'"You won''t remember a thing except me."', N'kafka.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (24, N'Luocha', N'"This coffin isn''t mine. I was merely entrusted to take the body back to the Luofu."', N'luocha.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (25, N'Ruan Mei', N'"Without accelerating or postponing the arrival of death, life will always wither."', N'ruan_mei.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (26, N'Seele', N'"To use our strength to create a fair society... Isn''t that the obvious goal?"', N'seele.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (27, N'Silver Wolf', N'"Can you let me have some fun this time?"', N'silver_wolf.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (28, N'Sparkle', N'"I''m not exactly a person loaded with cool skills, and dreaming big isn''t really my thing. But, ya know, my latest thing is... getting myself into the Genius Society! Ha, I''m so ready to give it a go. Reckon anyone will buy it?"', N'sparkle.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (29, N'Topaz and Numby', N'"Money is a means, not an end. Work should make you happy... That''s the most fundamental principle."', N'topaz.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (30, N'Trailblazer', N'"When there is the chance to make a choice, make one that you know you won''t regret..."', N'trailblazer.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (31, N'Welt', N'"The galaxy is vast beyond compare, containing an infinite number of possibilities. An individual''s fate shouldn''t be limited to a single path ordained by heaven."', N'welt.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (33, N'Yanqing', N'"I only called you ''teacher'' because I admire your skill in this area. Don''t expect me to start taking it easy on you."', N'yanqing.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (34, N'Arlan', N'"I''m proud of my wounds. They''re a reminder of being able to protect everyone."', N'arlan.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (35, N'Asta', N'"The ''tortoise'' galaxies are those that slooowly give birth to new stars. The ones that use up their fuel reserves in an instant, are the ''hare'' galaxies."', N'asta.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (37, N'Dang Heng', N'"Even as we speak, farewells are happening throughout the universe. The grief that we share is real, but there''s nothing special about it."', N'dan_heng.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (38, N'Guinaifen', N'"Would you like to see me break this stone slab on somebody''s chest?"', N'guinaifen.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (39, N'Hanya', N'"Using dreams to analyze the sins of the mara-struck is like touching a vine with thorns — it doesn''t hurt as much when your fingers become numb."', N'hanya.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (41, N'Herta', N'"I''m already perfect, so what else should I do?"', N'herta.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (42, N'Hook', N'"Who am I? Heh, I''m the boss around here, you can call me... Pitch-Dark Hook the Great!"', N'hook.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (43, N'Luka', N'"Tell you a secret — the trick to becoming a champion is training hard while everyone is resting."', N'luka.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (44, N'Lynx', N'"In the Landau family, things are simple: If you wanna do something, go do it."', N'lynx.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (48, N'March 7th', N'"Well would you listen to that! I saved everyone without causing any trouble! You''re pretty awesome, March 7th!"', N'march_7th.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (49, N'Misha', N'"I''m going to work really hard, so I can save up and explore the stars just like grown-ups do!"', N'misha.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (50, N'Natasha', N'"Where''s a doctor when you need one?"', N'natasha.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (51, N'Pela', N'"Net markers activated — time for a good old counterattack."', N'pela.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (52, N'Qingque', N'"Work doesn''t count as extracting value, it''s just labor in exchange for payment. Extracting value is when you slack off at work."', N'qingque.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (53, N'Sampo', N'"All sorts of business are welcome — as long as you''ve got the cash."', N'sampo.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (55, N'Serval', N'"How can a rock star not have that kind of confidence?"', N'serval.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (57, N'Sushang', N'"My name will go down in history, just like those heroes of legend!"', N'sushang.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (58, N'Tingyun', N'"In business, it''s best to work with persuadable types. For those who are less persuadable, cooling them down with a fan works wonders."', N'tingyun.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (59, N'Xueyi', N'"You are talking to a puppet. The Commission gifted me this body. The real me has already been reduced to ashes."', N'xueyi.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (60, N'Yukong', N'"Some were born to be poets, some to be warriors — I was born to mingle among the stars."', N'yukong.png', 1, 4)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (70, N'Acheron', N'"Lone voyagers in the cosmos are driven by two desires — to tread in the trails of the past and to forge their own way. But under THEIR scrutiny... most end up adhering to the former."', N'acheron.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (71, N'Aventurine', N'"Go ahead, use me as you wish, even stab me in the back if you see fit. Exploitation and treachery are simply tools of the trade. But remember, I don''t make deals that don''t pay off... So, I hope you don''t disappoint me."', N'aventurine.png', 1, 5)
INSERT [dbo].[Category] ([ID], [Name], [Description], [Img], [Active], [Stars]) VALUES (72, N'Gallagher', N'"Making a drink is a sensory skill. In dreams, creating fizzy concoctions requires adding a bit of your mood. Heavier if you''re troubled, a touch sweeter if you''re in high spirits... It''s not just about mixing beverages. It''s about mixing the experiences of life."', N'gallagher.png', 1, 4)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Replies] ON 

INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (9, 26, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Her one-shot technique is VERY addictive...', CAST(N'2024-04-07T09:32:49.037' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (10, 26, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'I found myself just wondering around maps killing everything in site for no apparent reason. For hours!', CAST(N'2024-04-07T09:33:57.000' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (11, 26, N'b3e14015-26cf-4371-8255-89a65d48688c', N'I kept her at level 1 and ran through all the maps to see just how much XP I could gain. She got to ~Level 17, and the two level 20''s with her got to 24. Actually surprised me, I could save a decent chunk of XP mats doing this for secondary characters, even if it''ll take a long time.', CAST(N'2024-04-07T09:34:22.513' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (12, 26, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Fr i never thought one shotting fodder enemies would be so addicting i burned through at least 30 trick snacks', CAST(N'2024-04-07T09:34:37.793' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (13, 26, N'b3e14015-26cf-4371-8255-89a65d48688c', N'I absolutely love her and she will be my main carry for the foreseeable future.', CAST(N'2024-04-07T09:34:55.967' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (14, 27, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Her memory. She’s been seen to forget things very easily, such as how to get back to the lobby in the Reverie. If she is jumping back in time, she therefore wouldn’t remember anything from our past, as that’s her future and she hasn’t seen it yet. Again with the example of the Reverie, maybe in the future that is her room, or the jump had caused her to become disoriented.', CAST(N'2024-04-07T09:44:12.050' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (15, 27, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Her knowledge. When we first meet Acheron, she guides us through the dreamscape, explaining how to navigate it, and saying “Why not?” when we get confused about what is happening. However when we go to the dreamscape with Acheron and Black Swan, it is now Acheron who is confused, and Black Swan is the one explaining how things work and saying “Why not?”. This to me at least very clearly shows us that something is whack is Acherons time, repeating what Black Swan says not because she fully understands it, but because that’s all she was told about how nay of that was possible.', CAST(N'2024-04-07T09:44:55.310' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (16, 27, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Her inaction when facing Something Unto Death. After Firefly is killed, we can press Acheron as to why she didn’t do anything, ending with her saying that she “couldn’t”. It seems there was something stopping her from fighting SoD, but nothing to stop her from fighting Sam not too soon after. If she’s travelling back in time, then she may have known what was about to happen to Firefly, and this knew that no matter what she did it wouldn’t help, so she did nothing.', CAST(N'2024-04-07T09:45:09.447' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (17, 27, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Her being a Galaxy Ranger. She has said that she’s “a Galaxy Ranger” because “that’s what they call me”. Some people have noted it as weird that she doesn’t call herself a Ranger because the IPC couldn’t find anything linking her to them. If we assume that she is travelling back in time, then it is possible that she was made a Ranger in her past, but that is our future, so she’s yet to become one to us. This also links into her killing Duke Inferno and how she arrived at Penacony. Logically, she’s yet to kill him, yet Aventurine says that she showed up with just the music box invitation. Now we’ve seen how hard it is to get into the Reverie is your not an invitee, so how did she get in? Answer is, she already was. In the furture.', CAST(N'2024-04-07T09:45:16.240' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (19, 27, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Lastly, her red text. Now admittedly this is still speculation with no definitive answer just yet, but the most telling thing to me is whoever you refuse to let her team up with you and Black Swan. If you have seen it, she’ll ask you to repeat that. If you refuse again she’ll same the exact same thing, and now your option of “no” has been replaced with “yes” in red text. Black Swan pays no attention to this, and the story continues as normal, but it stands out to me.', CAST(N'2024-04-07T09:45:40.353' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (20, 27, N'b3e14015-26cf-4371-8255-89a65d48688c', N'What if the red text represents our free will being taken away, and something is changing how things go. If Acheron really is travelling back in time, then presumably she remembers us teaming up, and thus we were always going to team up, and that red text is something fixing the timeline. Could this mean that every time we see that red text, it’s the course being corrected so that she doesn’t make any mistakes and messes with the timeline. Going back to the wrong room example, she claims that this is her room, but then in the red text she changes her mind, asking if she made a mistake, and then she leaves.', CAST(N'2024-04-07T09:45:45.783' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (21, 28, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Gotta repay bro for being such a cool occurrence in SU', CAST(N'2024-04-07T09:46:46.540' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (22, 28, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Knights of beauty my beloved', CAST(N'2024-04-07T09:46:56.923' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (23, 28, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'He was in SU?', CAST(N'2024-04-07T09:47:06.950' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (24, 28, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Not him specifically, but the Knights of Beauty are in a few occurrences.', CAST(N'2024-04-07T09:47:13.540' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (25, 29, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'I hope he randomly falls out of the sky in Penacony during a dramatic moment, everyone pauses confused, and Argenti just gets up and says: “Ah, Trailblazer! It seems the Beauty has led me back to you once more!” ', CAST(N'2024-04-07T09:48:07.150' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (26, 29, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Bro that would be so peak and so hilarious 🤣', CAST(N'2024-04-07T09:48:14.470' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (27, 29, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Damn bro I can hear it in my head!', CAST(N'2024-04-07T09:48:21.267' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (28, 29, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Argentis battle theme is my favorite song in the game im glad to see someone else appreciating it', CAST(N'2024-04-07T09:48:32.200' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (29, 29, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'can you set it in the express?', CAST(N'2024-04-07T09:48:40.143' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (30, 29, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Yes you can', CAST(N'2024-04-07T09:48:46.963' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (31, 29, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'what is the name of the song btw?', CAST(N'2024-04-07T09:48:53.280' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (32, 30, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Hoyoverse nerfed him too hard before release', CAST(N'2024-04-07T09:49:35.690' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (33, 30, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Which is really weird cause like we already have broken 4*s, what''s wrong with making Arlan one?', CAST(N'2024-04-07T09:49:44.723' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (34, 30, N'b3e14015-26cf-4371-8255-89a65d48688c', N'And it''s funny because he was the best 4* DPS in the beta, couple that with his positive SP combat. Nerfing him made sense but they took it too far.', CAST(N'2024-04-07T09:49:55.850' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (35, 31, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Asta is forgotten aeon of money.', CAST(N'2024-04-07T09:50:26.310' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (36, 31, N'b3e14015-26cf-4371-8255-89a65d48688c', N'That explains everything', CAST(N'2024-04-07T09:50:32.747' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (37, 31, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'The Path of Wealth

This path are about every materialistic value of everything on the universe🤣🤣🤣', CAST(N'2024-04-07T09:50:41.253' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (39, 31, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Pretty rich, yeah. Belobog debt was pretty small for IPC standard, so Asta should be able to buy Jarilo-6 no problem. But why would she do it?

She don''t have good memories about people using her for her money:"Occasionally, "friends" she never recognizes would come and ask if they could borrow money from Asta. However, it''s the first time she actually heard someone offer to pay her back. Her eyes widen in surprise. Listening in, her mother can''t help but laugh.

"You''re still a kid. What kind of work can you do?""Fight.""That''s not a good job. How about this — I''ll give you a job."

To this day, in Asta''s heart, the bill for Arlan''s meal was settled the moment he said that he''d pay her back. "

So I don''t think it would be proper to ask her for big money just because "we friends"', CAST(N'2024-04-07T09:51:08.763' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (40, 31, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Her parents are financial directors at the IPC, which is basically space mega-amazon. Her parents consider buying several planets on a whim as “quite cheap”. Asta herself funded the construction of the entirety of Herta’s Space Station, which is a state of the art research facility, and also considered buying a fleet of dreadnought starships for protection of said space station in case the antimatter legion returned, while worrying that the cost of said fleet was too cheap. “Fuck you” money doesn’t even come close to Asta’s bank account balance.', CAST(N'2024-04-07T09:51:26.477' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (41, 33, N'b3e14015-26cf-4371-8255-89a65d48688c', N'I really love Hoyoverse''s "humble" writing with Aventurine. He isn''t a character like Ganyu or Keqing who we often get to see to be so overly competent in their field, with their co-workers gushing over their efficiency and skillz. It''s as if Hoyoverse is saying, "Hey! Look at how cool this character is! Isn''t she awesome? Wish for her!" Not with Aventurine though. The realistic way characters distrust him just because of how he talks like a sly & cunning snake is already refreshing on its own. Follow that up with realistic failures because he fails a few times in recruiting other playable characters has had him earn my respect. Like a snake, he wiggled his way to victory. He was finally able to strike a deal with someone. He convinced Black Swan to bring us to him so work can finally be done.', CAST(N'2024-04-07T09:53:22.640' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (42, 33, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'I like his desperation. Someone who needs to be in control, and thrives on the image that he is, but there are too many out of control pieces that he''s desperately trying to predict. He came in expecting to have the upper hand, but realized there was so much more going on and is trying to salvage his plans.

His conversation with Ratio, at least by my interpretation, sort of gives off this uneasiness. He claims to have everything under control, but there''s a sort of underlying anxiety to everything he''s saying and Ratio sort of calls him out on it.

There''s also another part of me that thinks it could all be a facade, that he already has a plan, and trying and failing to recruit people is part of it. During the dream in the beginning he mentions "three chips is all I need" or something like that, and he seems fairly confident he already had the pieces in place.

There''s a also a third part of me that wonders if he''s being set up to fail with whatever he''s doing for the IPC on Penacony.', CAST(N'2024-04-07T09:54:03.563' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (43, 33, N'b3e14015-26cf-4371-8255-89a65d48688c', N'I particularly like this frame of him being sad (and also the frame where Ratio points out his tattoo). His little facade kind of slips and it’s different. Not even people that he thought would be easy to manipulate, like the TB, is able to be swayed.

The scene where he tries to act like he’s above the TB by giving us credits for being his friend kind of shows how pathetic he is imo, especially since we shot back with “you don’t know what friends are” and his response is to give us more money and escape the situation.', CAST(N'2024-04-07T09:54:35.063' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (44, 34, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Bailu is way better than people give her credit for. What makes her unique among abundance characters is that she is the one with the strongest damage mitigation. And the only one with damage mitigation for AoEs.

Huohuo and Natasha do very little to prevent burst damage, though both do some extra healing with their normal effects when characters are below 50%. Luocha has his auto-skill, but there are plenty of occasions where that isn''t enough. Lynx is arguably the second best, since her skill provides a health buff and redirects damage to a character who should be safest to take hits but her raw healing is the weakest.

Bailu on the other hand? A max health increase, damage reduction, auto-heal upon damage taken and a revive. All affecting the whole party (well, except the revive, but hopefully multiple people don''t drop). What she spends for this is cleansing and any hope of personal damage. I think she''s perfectly suited to be the standard 5 star abundance character.

Stellaron Hunter Kafka makes her lack of cleanse look really bad. Kafka was one of the toughest enemies early on, still haunts SU and came back for MoC 12. But for other enemies like Malefic Ape, Team Leader and True Sting damage mitigation holds more weight because allies can just get spiked by massive damage and what debuffs are present can be ignored with giant heals.', CAST(N'2024-04-07T09:56:47.183' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (45, 34, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Agreed, Bailu is especially strong when it comes to mitigating AOE nukes, opposite to Fu Xuan. She doesn’t have all of the other bonuses that other sustains do, but she has a unique strength and can brute force heal through everything.

I also think the revive is misunderstood. I can understand that having no deaths is better than using a revive as a crutch: but in modes like SU, it’s a great added benefit with the random nature of the mode and some really busted enemies.', CAST(N'2024-04-07T09:56:53.727' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (46, 34, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'
Sometimes enemies will just have their “lol get wrecked” round where they all pile on one character and you can’t always do anything about it. It’s not a skill issue to let them die and get revived so Bailu isn’t wasting SP pulling them back up with her skill.

I always factor in the revive during fights. It shouldn’t be understated how valuable it can be to squeeze out a few more turns of aggression by letting a character knock on death’s door knowing they won’t open it.', CAST(N'2024-04-07T09:57:02.160' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (47, 35, N'b3e14015-26cf-4371-8255-89a65d48688c', N'She also is a human and not a swan, is she stupid²?', CAST(N'2024-04-07T09:58:33.253' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (48, 35, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Her name should have been Purple Human fr fr', CAST(N'2024-04-07T09:58:38.983' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (49, 35, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Pretty sure ''Black Swan'' is also a term to denote an anomaly.

Like there is a well known analogy to describe hypotheses and theories - like all swans are white, until you find one that is black.

I always assumed her name was used as a reference to this, that she is an anomaly and something new and different. Plus it also sounds edgy too XD', CAST(N'2024-04-07T09:59:29.053' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (50, 36, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'He''s a beast no question. Unreal three target damage, very skill points efficient, and wants to take a punishment. Got mine close to 9khp with 130 speed and he''s just unstoppable.', CAST(N'2024-04-07T10:00:08.037' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (51, 36, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Dang how’d you get that much up?', CAST(N'2024-04-07T10:00:17.153' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (52, 36, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'HP on everything except speed boots (will replace for HP after I get bronya) his signature LC and some good secondary rolls. I want to top 10k.', CAST(N'2024-04-07T10:00:23.527' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (53, 36, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Idk he''s S on prydwen, which seems to be the Bible around here. Either way he''s definitely strong, and if you really want him, get him. It''s pve, he''s definitely capable of handling the content and then some', CAST(N'2024-04-07T10:00:35.987' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (54, 36, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'I think the thing you have to consider with Prydwen is that there Blade''s evaluated based on his current performance in MOC, which in this cycle is specifically designed to make him appealing to players who are pulling

Edit: I meant the 1.2.1 memory of chaos, where allies who are hit or whose HP is consumed are buffed', CAST(N'2024-04-07T10:00:45.697' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (55, 37, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Her being a bronya', CAST(N'2024-04-07T10:01:32.747' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (56, 37, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Silverwing will always be peak Bronya to me but SW and Bronya Rand are 👌👌👌👌', CAST(N'2024-04-07T10:01:42.373' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (57, 37, N'b3e14015-26cf-4371-8255-89a65d48688c', N'A Bronya is a Bronya, there''s nothing to not like about a Bronya', CAST(N'2024-04-07T10:01:50.917' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (58, 37, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'She has good stats for the museum mangament event.', CAST(N'2024-04-07T10:02:12.203' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (59, 37, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Her dialogue during the Seele recruitment part was one of the best of the event', CAST(N'2024-04-07T10:02:18.977' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (60, 37, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'At that time, I was trolling with her application sheet.

Name: Seele No-Last-Name
Personal Exp: No comment
Skill & expert: Too scary to specify
🤣🤣🤣', CAST(N'2024-04-07T10:02:32.073' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (61, 38, N'b3e14015-26cf-4371-8255-89a65d48688c', N'The only way to offset a power creep that eventually breaks your Clara is March 7th MAX eidolons. This removes the healer slot as part of the 4 and gives you more flex. That way you got shields + heals and are way more flexible with party compositions since some already have said Clara''s single target is bad damage.

I don''t know how well Clara + March7th + single target + buff/debuff work against bosses that spams aoe.', CAST(N'2024-04-07T10:03:41.000' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (62, 38, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Aside from the rng of getting hit, she simply hits hard while providing some tanking and depending on weapon and support also self-healing.

Just from her scalings, she does good damage. The thing is, she must get hit (or you need E6). If you compare her with Seele, Claras counter without ult does not much less damage than Seeles skill. Claras stronger counter does like 20% less damage than Seeles ult. But the stronger counter hits twice (or trice at E6). The last ascension trace increases counter damage by 30% so its almost on pair.

The thing is that Seele is much faster and she profits heavily if she can kill something. So both kinda need multiple enemies or their damage goes down heavily. Clara is simply very rng heavy and sucks against single enemies while Seele can even profit from fighting multiple enemies. With eidolons Clara can be good for sure but for now she offers much value because of her damage reduction.', CAST(N'2024-04-07T10:03:47.230' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (63, 38, N'b3e14015-26cf-4371-8255-89a65d48688c', N'
Something you should consider is that as the game progresses, mobs will get faster as you get higher. This is a direct buff to her damage.

You''ll find that she will get stronger in time as it becomes more difficult to manipulate mob turns. To get the most out of her, you need to ensure that she takes hits.

I''m not going to write a novel about aggro/turn manipulation/team positioning, so I''ll just say: you want her getting hit more often if you want to increase her dps. It''s not hard to figure out how to make that happen.', CAST(N'2024-04-07T10:03:54.670' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (64, 38, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'I''m not a whale and not sure if I''m really far on MoC. I''m f2p with 15 stars on MoC and I use Clara with her 5 star lightcone.

In my opinion her single target damage is really, really bad, so bad that I need to use her alongside Jing or I don''t have the DPS needed to clear the stage fast enough for 3 stars, she''s mainly like a counter tank than anything resembling damage against MoC bosses. She''s been very helpful for survability so far though but I fear she''s going to get replaced for MoC really fast once I get to TL 60 and my units have less needs for the massive survability she provides. I think she''s good and pulls her weight for now which is good enough for me.

At the end of the day she''s a standard banner unit, she''s going to get crept sooner or later, but she was great while she lasted.', CAST(N'2024-04-07T10:04:04.437' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (65, 38, N'b3e14015-26cf-4371-8255-89a65d48688c', N'The main reason for this discussion is I''ve heard many whales with e6 characters supposedly find her vital for clearing MoC and is one of the strongest units, I want a discussion to find out what outweights the negatives I''ve stated and help her shine longterm before investing into a perfect set for her or anything like that

Sadly so far none of them or people who know the answer has commented yet, because i''m really confused as to why it is', CAST(N'2024-04-07T10:04:11.023' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (66, 40, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Oh man can you imagine if MHY release a character that could give damage/speed buffs to a ally and recover skills points to mitigate most of these problems.

Oh well we can only dream.', CAST(N'2024-04-07T10:05:26.287' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (67, 40, N'b3e14015-26cf-4371-8255-89a65d48688c', N'They probably will add a character who can generate skill points, eventually.', CAST(N'2024-04-07T10:05:36.490' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (68, 40, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'E1 Bronya with her signature ends up being SP neutral', CAST(N'2024-04-07T10:05:43.453' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (69, 40, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Oh wow. Congrats on being lucky enough or rich enough to get both of those lol', CAST(N'2024-04-07T10:05:51.057' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (71, 54, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'<h1>smoke test</h1>
<p>je sais pas trop cque jecris mais tant que ca fonctionne jvais etre <strong>content</strong></p>', CAST(N'2024-05-09T18:25:05.583' AS DateTime), 1)
INSERT [dbo].[Replies] ([ID], [FK_Subject], [FK_User], [Body], [Date], [Active]) VALUES (72, 26, N'6226f765-6e82-4753-bc80-775d79b8cfa7', N'<p>allo</p>', CAST(N'2024-05-21T09:47:16.607' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Replies] OFF
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (26, 70, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'It''s been a few days. For those who got Acheron, how''s your experience with her so far?', N'I can''t stop being a killing machine ngl.', CAST(N'2024-04-07T09:32:16.000' AS DateTime), 129, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (27, 70, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Who is Acheron', N'Spoilers for the 2.0 Traiblaze mission.

So, with Aventurine saying that Acheron is an emanator, we have been left with the question “to which aeon?”. My belief is that she is an emanator of Terminus, the finality and would like to share the evidence of this. I know others have had the same idea, so if I miss anything please let me know.

To start with, I think Acheron is travelling back in time, similar to Terminus, but not in a consistent path. Her time moves forwards like us, but she will suddenly jump back in time whenever she catches up with a version of her from the future. I also speculate that she jumps back to where she was physically at that time, meaning Acheron is never disappearing and reappearing randomly. This would explain a few things about her.', CAST(N'2024-04-07T09:43:27.397' AS DateTime), 7, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (28, 4, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'What’s your opinion on Argenti before his arrival?', N'I’m so co conflicted about this guy. Absolutely stunning design but his kit is no doubt the most boring one out of all 5-star DPSs, including the standard banner ones. Even some insane multipliers wouldn’t make it exciting because he brings nothing new to team comps. Plus he has basically no presence before his release, I’m afraid he might be the lowest selling banner since launch.', CAST(N'2024-04-07T09:46:29.340' AS DateTime), 0, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (29, 4, N'b3e14015-26cf-4371-8255-89a65d48688c', N'About Argenti''s companion quest.', N'Whenever you first fight him after he fawns over the beauty of the fern..

Was anyone else genuinely caught off guard with his boss soundtrack???????? That shit is so fire I had to sit there for a few minutes and enjoy it before doing the fight. Not to mention his fight was very fun!

I''m ashamed I didn''t do his quest until yesterday. Firefly is my big target for now but after her banner leaves I may just save for his rerun.

He came in, admired a plant, admired us, fought us. Then like the gigachad he is, saved the day and left without elaborating.

Argenti the GOAT. (After my girl Firefly ofc)

(Edit: Adding spoiler tag just in case)', CAST(N'2024-04-07T09:47:54.363' AS DateTime), 0, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (30, 34, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'What''s the matter with Arlan?', N'I don''t know if HSR will do like Genshin for story and I don''t know if Genshin does as I believe they do, but I wonder if Arlan doesn''t have something else to tell us.

What''s cool is that with light cone you see echoes of what our characters are/were/will be.

And I wonder if these wounds beneath his bandages hidden by his gloves and elbow guards means anything.

Is it because he worked extremely hard to be the place he is now, knowing that his young face could make people underestimate him, so he wanted to make everyone have faith in him, or is it because he is something else, and he worked very hard so no one will notice it?', CAST(N'2024-04-07T09:49:26.380' AS DateTime), 3, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (31, 35, N'b3e14015-26cf-4371-8255-89a65d48688c', N'How rich Asta is?', N'I know she''s stupidly rich but how rich is she?

Do we have at least an idea of what she can do?

If someone can give me an example or something to help me understand it id be happy lol

Like, if she knew about Belobog could she use the money she planned to spend for an extra dessert for Arlan (since he already tried to stop her from thanking him and wasting her money) to pay the debts that were centuries old?', CAST(N'2024-04-07T09:50:18.980' AS DateTime), 1, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (33, 71, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'About Aventurine''s Writing', N'I''ve come across some opinions on Aventurine. A good sum of them are making fun of him on how much of a joke he is in the 2.0 plot. Regardless if they''re jokes or not, I felt passionate to defend the character writing of the man.

So let me cook. Allow me to change your mind on Aventurine. Mind you, English is my 2nd language.

I adore the creative decision to have Aventurine struggle with recruiting allies. It doesn''t mean he''s incompetent or shouldn''t be taken seriously. It simply means that the characters he was trying to persuade are just as complex as him. Each one of them with their own morals, standards and agendas. Each of their trust is not easy to get. Of course he would have a hard time getting Ratio''s help. The man''s got quite an ego and a small mistake might get you indelibly marked as an "idiot" in his eyes. With Sparkle, I felt that Aventurine was simply a low-tier schemer unlike her and she saw that. Moreover, Sparkle judge Aventurine because he was a Sigonian, further giving complexity to racial reputations in the game.', CAST(N'2024-04-07T09:53:10.947' AS DateTime), 1, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (34, 5, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Bailu appreciation', N'Hear me out...

I know Bailu doesnt have cleanse. I know the importance of cleanse.

That being said, she heals a fuck ton and her revive can make life just comfy. Limited sustain options clearly outclass her, but early on when you only have the option for lynx and natasha and no healer is on banner to pull for... she is not as bad as people make her out to be.', CAST(N'2024-04-07T09:56:37.937' AS DateTime), 1, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (35, 7, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Why is her name Black Swan when she''s purple, is she stupid?', N'Someone explain this to me', CAST(N'2024-04-07T09:58:27.820' AS DateTime), 0, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (36, 8, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Why is Blade rated A?', N'Blade seems really good and I wanna pull for him but pretty much every tier list has him as an A. Many people seem to agree with that. Can someone tell me his flaws or something because I wanna pull for him but I need to make sure I’m making the right call.', CAST(N'2024-04-07T09:59:58.983' AS DateTime), 0, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (37, 9, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'What do you like most about bronya?', N'No please for the love of God don''t comment mommy issues because think about how much the jorilo-VI story effed her up.', CAST(N'2024-04-07T10:01:20.440' AS DateTime), 0, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (38, 10, N'b3e14015-26cf-4371-8255-89a65d48688c', N'Clara: Longterm investment, want to hear from whales and experienced players', N'Hello, I wanted to create a discussion about Clara.

I want to make this clear right now, I think clara is a great and strong character. I am merely playing "Devils Advocate" and thinking of the negatives for longterm investment, and wanted to create a discussion on thoughts or opinions and experiences (especially those who have gotten far in MoC)

I made a comment post and was inspired to make this post, so here goes.

I think Clara is a great unit, but I worry about her longterm use in the meta and how her viability will actually deteriate with time. Thus far, all content in the game (that isn''t a breeze like SU) has a turn limit, our first event rewarding credits and of course MoC 3 stars. This means for longterm investment, so far the game is pointing the direction that clearing in the minimum amount of cycles is basically required.

Now, for those that don''t know, Clara''s kit revolves around counting the boss when it hits her. Her skill is alright damage (but not the bulk of it), but also requires the boss to be countered to do much damage. Clara is also one of the slowest DPS characters there is, which is sort of good since it means you can skill after the boss attacks a lot of the time.

However, keep in mind there''s no way to give the enemy more turns in the game, and thus clara will never be able to increase her attacks per cycle unlike every other dps (mainly hunt).', CAST(N'2024-04-07T10:03:21.637' AS DateTime), 0, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (40, 11, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'Dan Heng IL is good. Really good, but he definitely has trade offs.', N'He is extremely SP heavy and if you want to max basic every chance you get, which won''t be every turn by the way, then you need a specific team that can build 3 SP almost every turn. This heavily limits his team building options. Asta and Bronya? Yeah I would forget about it. Yukong? There is some trade off with less max basics but more buffing. Silver Wolf? She will want to use her skill every now and then and she''s more Single Target with her Debuffs but it''s possible. Healers? Luocha is pretty much the best healer for Dan Heng because he''s extremely SP positive and his heals are either auto or occur while attacking. Every other healer will need to use some SP time to time as of now. Tingyun, Pela, and Luocha are pretty much his best teammates for now for buffing, debuffing, energy, healing and cleanse. If you don''t have them then team building is gonna be harder.

Crowd Control from mobs can absolutely wreck your rotation. Having to spend even one SP for cleanse can mean the difference between having a max basic ready to go or not. While CC can screw over every team, other teams can afford to use a SP on cleanse most of the time while Dan Heng''s can''t.

Dan Heng IL is Imaginary. He cannot be any element you want him to be. Unless you have Silver Wolf, then you''re better off using another unit that can hit a specific weakness.

Dan Heng really need specific units, relics, stats, and even his signature if you want to burst more often for extra skill points. Crit stats are always gonna be a pain and unless you plan on hurting his damage by running a ER two piece set, then you''re main two options are Tingyun and/or his Signature. He''s expensive, but I would say he''s worth it.

Finally, he will not be using his max basic every turn. You will run into having to use SP on other characters.', CAST(N'2024-04-07T10:05:00.537' AS DateTime), 0, 1)
INSERT [dbo].[Subject] ([ID], [FK_Category], [FK_User], [Title], [Body], [Date], [View], [Active]) VALUES (54, 70, N'94416d55-ee55-4b07-b54b-aef9f48c8b62', N'test', N'<h1>Smoke test 1</h1>
<p>jsp trop ce que je fais mais si ca fonctionne jvais etre <strong>content</strong></p>', CAST(N'2024-05-09T18:15:25.190' AS DateTime), 4, 1)
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 5/21/2024 11:52:59 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 5/21/2024 11:52:59 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 5/21/2024 11:52:59 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 5/21/2024 11:52:59 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 5/21/2024 11:52:59 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 5/21/2024 11:52:59 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 5/21/2024 11:52:59 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Replies]  WITH CHECK ADD  CONSTRAINT [FK_Replies_AspNetUsers] FOREIGN KEY([FK_User])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Replies] CHECK CONSTRAINT [FK_Replies_AspNetUsers]
GO
ALTER TABLE [dbo].[Replies]  WITH CHECK ADD  CONSTRAINT [FK_Replies_Subject] FOREIGN KEY([FK_Subject])
REFERENCES [dbo].[Subject] ([ID])
GO
ALTER TABLE [dbo].[Replies] CHECK CONSTRAINT [FK_Replies_Subject]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_AspNetUsers] FOREIGN KEY([FK_User])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_AspNetUsers]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Category] FOREIGN KEY([FK_Category])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_Category]
GO
USE [master]
GO
ALTER DATABASE [W24-TP] SET  READ_WRITE 
GO
