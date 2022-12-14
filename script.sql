USE [master]
GO
/****** Object:  Database [UMSv1]    Script Date: 10/5/2022 12:08:46 PM ******/
CREATE DATABASE [UMSv1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UMSv1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UMSv1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UMSv1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UMSv1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UMSv1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UMSv1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UMSv1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UMSv1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UMSv1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UMSv1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UMSv1] SET ARITHABORT OFF 
GO
ALTER DATABASE [UMSv1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UMSv1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UMSv1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UMSv1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UMSv1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UMSv1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UMSv1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UMSv1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UMSv1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UMSv1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UMSv1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UMSv1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UMSv1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UMSv1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UMSv1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UMSv1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UMSv1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UMSv1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UMSv1] SET  MULTI_USER 
GO
ALTER DATABASE [UMSv1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UMSv1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UMSv1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UMSv1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UMSv1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UMSv1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [UMSv1] SET QUERY_STORE = OFF
GO
USE [UMSv1]
GO
/****** Object:  Table [dbo].[ProfilePicture]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfilePicture](
	[PictureID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[FileName] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Size] [int] NULL,
	[DATA] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[PictureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](20) NULL,
	[FirstName] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[ZipCode] [nvarchar](9) NULL,
	[PhoneNumber] [nvarchar](13) NULL,
	[RoleID] [int] NULL,
	[StatusID] [int] NULL,
	[PictureID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersCredentials]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersCredentials](
	[UserID] [int] NOT NULL,
	[Password] [varchar](12) NULL,
	[Initial] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProfilePicture]  WITH CHECK ADD  CONSTRAINT [FK_ProfilePicture_UserInfo] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserInfo] ([UserID])
GO
ALTER TABLE [dbo].[ProfilePicture] CHECK CONSTRAINT [FK_ProfilePicture_UserInfo]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_ProfilePicture] FOREIGN KEY([PictureID])
REFERENCES [dbo].[ProfilePicture] ([PictureID])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_ProfilePicture]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_Role]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([StatusID])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_Status]
GO
ALTER TABLE [dbo].[UsersCredentials]  WITH CHECK ADD  CONSTRAINT [FK_UsersCredentials_UsersInfo] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserInfo] ([UserID])
GO
ALTER TABLE [dbo].[UsersCredentials] CHECK CONSTRAINT [FK_UsersCredentials_UsersInfo]
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ChangePassword]
@UserID int,
@Password nvarchar(MAX),
@Initial bit

AS
UPDATE UsersCredentials SET  Password=@Password, Initial=@Initial
FROM UsersCredentials 
WHERE UsersCredentials.UserID = @UserID
GO
/****** Object:  StoredProcedure [dbo].[DeleteProfilePicture]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteProfilePicture]
@UserID int
AS
DELETE FROM ProfilePicture
WHERE UserID= @UserID
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteUser]
@UserID nvarchar(MAX)
AS
DELETE FROM UsersCredentials WHERE UserID= @UserID
DELETE FROM ProfilePicture WHERE UserID= @UserID
DELETE FROM UserInfo WHERE UserID= @UserID
GO
/****** Object:  StoredProcedure [dbo].[EditUserViaUserID]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[EditUserViaUserID]
@UserID int,
@UserName nvarchar(20),
@FirstName nvarchar(20),
@LastName nvarchar(20),
@Email nvarchar(50),
@Adress nvarchar(50),
@City nvarchar(50),
@State nvarchar(50),
@ZipCode nvarchar(9),
@PhoneNumber nvarchar(13),
@RoleID int,
@StatusID int


AS
UPDATE UserInfo SET UserName=@UserName, FirstName=@FirstName, LastName=@LastName, Email=@Email, Adress=@Adress,
City=@City, State=@State, ZipCode=@ZipCode, PhoneNumber=@PhoneNumber 
WHERE UserID= @UserID
GO
/****** Object:  StoredProcedure [dbo].[FindUserViaUserID]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[FindUserViaUserID]
@UserID int
AS
SELECT * FROM UserInfo WHERE UserID= @UserID
GO
/****** Object:  StoredProcedure [dbo].[FindUserViaUserName]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[FindUserViaUserName]
@UserName nvarchar(20)
AS
SELECT * FROM UserInfo WHERE UserName= @UserName
GO
/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetAllUsers]
AS
SELECT * FROM UMSv1.dbo.UserInfo
GO
/****** Object:  StoredProcedure [dbo].[GetPassword]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetPassword]
@UserID int
AS
SELECT * FROM UsersCredentials WHERE UserID= @UserID
GO
/****** Object:  StoredProcedure [dbo].[InsertNewUser]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertNewUser]
@UserName nvarchar(20),
@FirstName nvarchar(20),
@LastName nvarchar(20),
@Email nvarchar(50),
@Adress nvarchar(50),
@City nvarchar(50),
@State nvarchar(50),
@ZipCode nvarchar(9),
@PhoneNumber nvarchar(13),
@RoleID int,
@StatusID int,
@Password varchar(12)
AS
Insert Into UserInfo (UserName,FirstName,LastName,Email, Adress, City, State,
ZipCode, PhoneNumber, RoleID, StatusID)
Values(@UserName,@FirstName,@LastName,@Email, @Adress, @City, @State,
@ZipCode, @PhoneNumber, @RoleID, @StatusID)

INSERT INTO UsersCredentials 
values(SCOPE_IDENTITY(),@Password, 1) 
GO
/****** Object:  StoredProcedure [dbo].[InsertProfilePicture]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertProfilePicture]
@UserID int,
@FileName nvarchar(50),
@Type nvarchar(50),
@Size int,
@DATA nvarchar(MAX)
AS
Insert Into ProfilePicture
Values(@UserID, @FileName, @Type, @Size, @DATA)
GO
/****** Object:  StoredProcedure [dbo].[SelectProfilePicture]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SelectProfilePicture]
@UserID int
AS
SELECT * FROM ProfilePicture
WHERE UserID= @UserID
GO
/****** Object:  StoredProcedure [dbo].[UpdateProfilePicture]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[UpdateProfilePicture]
@UserID int,
@FileName nvarchar(50),
@Type nvarchar(50),
@Size int,
@DATA nvarchar(MAX)
AS
UPDATE ProfilePicture SET FileName = @FileName, Type = @Type, Size = @Size, DATA = @DATA 
WHERE UserID= @UserID
GO
/****** Object:  StoredProcedure [dbo].[ValidateUserViaEmail]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ValidateUserViaEmail]
@Email nvarchar(50),
@Password varchar(12)
AS
SELECT UserInfo.UserID, UserInfo.UserName, UserInfo.FirstName, UserInfo.LastName, UserInfo.Email, UserInfo.Adress,
UserInfo.City, UserInfo.State, UserInfo.ZipCode, UserInfo.PhoneNumber, UserInfo.RoleID, UserInfo.StatusID, UserInfo.PictureID,
UsersCredentials.Initial
FROM UserInfo,UsersCredentials 
WHERE Email= @Email AND Password= @Password
GO
/****** Object:  StoredProcedure [dbo].[ValidateUserViaUserName]    Script Date: 10/5/2022 12:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ValidateUserViaUserName]
@UserName nvarchar(20),
@Password varchar(12)
AS
SELECT UserInfo.UserID, UserInfo.UserName, UserInfo.FirstName, UserInfo.LastName, UserInfo.Email, UserInfo.Adress,
UserInfo.City, UserInfo.State, UserInfo.ZipCode, UserInfo.PhoneNumber, UserInfo.RoleID, UserInfo.StatusID, UserInfo.PictureID,
UsersCredentials.Initial
FROM UserInfo,UsersCredentials 
WHERE UserName= @UserName AND Password= @Password
GO
USE [master]
GO
ALTER DATABASE [UMSv1] SET  READ_WRITE 
GO
