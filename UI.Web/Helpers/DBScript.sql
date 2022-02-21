USE [master]
GO
/****** Object:  Database [StudentManagementSystem]    Script Date: 21-02-2022 9.03.20 PM ******/
CREATE DATABASE [StudentManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\StudentManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\StudentManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StudentManagementSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [StudentManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [StudentManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudentManagementSystem', N'ON'
GO
ALTER DATABASE [StudentManagementSystem] SET QUERY_STORE = OFF
GO
USE [StudentManagementSystem]
GO
/****** Object:  Table [dbo].[Class_Subject]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class_Subject](
	[ClassSubjectId] [int] IDENTITY(1,1) NOT NULL,
	[ClassId] [int] NULL,
	[SubjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassSubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClassMaster]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClassMaster](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [varchar](50) NOT NULL,
	[IsActive] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[c_id] [int] IDENTITY(1,1) NOT NULL,
	[c_name] [varchar](20) NULL,
	[c_gender] [char](1) NULL,
	[salary] [decimal](10, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[c_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer_address]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer_address](
	[c_aid] [int] IDENTITY(1,1) NOT NULL,
	[c_id] [int] NULL,
	[c_address] [varchar](50) NULL,
	[isdefault] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[c_aid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [varchar](100) NULL,
	[Designation] [varchar](20) NULL,
	[Salary] [decimal](18, 2) NULL,
	[Gender] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffKindMaster]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffKindMaster](
	[StaffKindId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffKindId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffMemberMaster]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffMemberMaster](
	[StaffMemberId] [int] IDENTITY(1,1) NOT NULL,
	[MemberName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NULL,
	[Gender] [char](1) NOT NULL,
	[DOB] [date] NOT NULL,
	[StaffKindId] [int] NULL,
	[ManagerId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffMemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentAddress]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAddress](
	[StudentAddressId] [int] IDENTITY(1,1) NOT NULL,
	[Address] [varchar](max) NULL,
	[MobileNumber] [decimal](12, 0) NULL,
	[StudentId] [int] NULL,
 CONSTRAINT [PK__StudentA__FA57018DE4E77B1E] PRIMARY KEY CLUSTERED 
(
	[StudentAddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentClass]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentClass](
	[StudentClassId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[ClassId] [int] NOT NULL,
 CONSTRAINT [PK__StudentC__2FF121476B060694] PRIMARY KEY CLUSTERED 
(
	[StudentClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentMaster]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentMaster](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[RollNum] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[DOB] [date] NOT NULL,
	[LastName] [varchar](50) NULL,
 CONSTRAINT [PK_StudentMaster] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentMaster_1]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentMaster_1](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[RollNum] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[DOB] [date] NOT NULL,
	[LastName] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentSubjectDetail]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentSubjectDetail](
	[StudentSubjectId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[ClassSubjectId] [int] NOT NULL,
	[Percentage] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK__StudentS__54F6B821C4BC96E6] PRIMARY KEY CLUSTERED 
(
	[StudentSubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectMaster]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectMaster](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[Subject] [varchar](50) NOT NULL,
	[IsActive] [char](1) NULL,
 CONSTRAINT [PK_SubjectMaster] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T1]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Subject] [varchar](50) NOT NULL,
	[Address] [varchar](100) NULL,
 CONSTRAINT [PK__T1__737584F7625919E6] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__T1__A2B1D90442404DBC] UNIQUE NONCLUSTERED 
(
	[Subject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temp1]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temp1](
	[ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMaster](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClassMaster] ADD  DEFAULT ('Y') FOR [IsActive]
GO
ALTER TABLE [dbo].[SubjectMaster] ADD  DEFAULT ('Y') FOR [IsActive]
GO
ALTER TABLE [dbo].[Class_Subject]  WITH CHECK ADD  CONSTRAINT [FK_Class_Subject_Class_Subject] FOREIGN KEY([ClassSubjectId])
REFERENCES [dbo].[Class_Subject] ([ClassSubjectId])
GO
ALTER TABLE [dbo].[Class_Subject] CHECK CONSTRAINT [FK_Class_Subject_Class_Subject]
GO
ALTER TABLE [dbo].[StudentAddress]  WITH CHECK ADD  CONSTRAINT [FK_StudentAddress_StudentMaster] FOREIGN KEY([StudentId])
REFERENCES [dbo].[StudentMaster] ([StudentId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentAddress] CHECK CONSTRAINT [FK_StudentAddress_StudentMaster]
GO
ALTER TABLE [dbo].[StudentClass]  WITH CHECK ADD  CONSTRAINT [FK_StudentClass_ClassMaster] FOREIGN KEY([ClassId])
REFERENCES [dbo].[ClassMaster] ([ClassId])
GO
ALTER TABLE [dbo].[StudentClass] CHECK CONSTRAINT [FK_StudentClass_ClassMaster]
GO
ALTER TABLE [dbo].[StudentClass]  WITH CHECK ADD  CONSTRAINT [FK_StudentClass_StudentMaster] FOREIGN KEY([StudentId])
REFERENCES [dbo].[StudentMaster] ([StudentId])
GO
ALTER TABLE [dbo].[StudentClass] CHECK CONSTRAINT [FK_StudentClass_StudentMaster]
GO
ALTER TABLE [dbo].[StudentSubjectDetail]  WITH CHECK ADD  CONSTRAINT [FK_StudentSubject_Class_Subject] FOREIGN KEY([ClassSubjectId])
REFERENCES [dbo].[Class_Subject] ([ClassSubjectId])
GO
ALTER TABLE [dbo].[StudentSubjectDetail] CHECK CONSTRAINT [FK_StudentSubject_Class_Subject]
GO
ALTER TABLE [dbo].[StudentSubjectDetail]  WITH CHECK ADD  CONSTRAINT [FK_StudentSubject_StudentMaster] FOREIGN KEY([StudentId])
REFERENCES [dbo].[StudentMaster] ([StudentId])
GO
ALTER TABLE [dbo].[StudentSubjectDetail] CHECK CONSTRAINT [FK_StudentSubject_StudentMaster]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllStudent]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_GetAllStudent]
AS BEGIN

	select * from StudentMaster
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertStudent]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertStudent]
(
	@RollNum	INT	,
	@Name VARCHAR(50),
	@Gender CHAR(1),
	@LastName VARCHAR(50)
)
AS BEGIN
	INSERT INTO StudentMaster(
	RollNum		,
	Name,
	Gender,
	DOB,
	LastName
	)
	VALUES(
	@RollNum		,
	@Name,
	@Gender,
	GETDATE(),
	@LastName	
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidateLogin]    Script Date: 21-02-2022 9.03.20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ValidateLogin]
(
@UserName VARCHAR(50),
@Password VARCHAR(50)
)
AS BEGIN

SELECT * FROM UserMaster
WHERE UserName=@UserName AND Password = @Password

END
GO
USE [master]
GO
ALTER DATABASE [StudentManagementSystem] SET  READ_WRITE 
GO

SET IDENTITY_INSERT [dbo].[UserMaster] ON 
GO
INSERT [dbo].[UserMaster] ([UserId], [UserName], [Password]) VALUES (1, N'saurabh', N'123')
GO
INSERT [dbo].[UserMaster] ([UserId], [UserName], [Password]) VALUES (2, N'admin', N'123')
GO
SET IDENTITY_INSERT [dbo].[UserMaster] OFF
GO