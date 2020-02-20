USE [IRDB_A2]
GO
/****** Object:  Table [dbo].[Collabs]    Script Date: 2018-02-28 3:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collabs](
	[PaperID] [int] IDENTITY(1,1) NOT NULL,
	[ResearchTitle] [varchar](120) NOT NULL,
	[AuthorFirstName] [varchar](60) NOT NULL,
	[AuthorLastName] [varchar](60) NOT NULL,
	[CoAuthorFirstName] [varchar](60) NOT NULL,
	[CoAuthorLastName] [varchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PaperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Institutions]    Script Date: 2018-02-28 3:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Institutions](
	[InstitutionsID] [int] IDENTITY(1,1) NOT NULL,
	[InstitutionName] [varchar](120) NOT NULL,
	[SchoolName] [varchar](120) NOT NULL,
	[Country] [varchar](120) NOT NULL,
	[InaugurationYear] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[InstitutionsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[InstitutionName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SchoolName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professors]    Script Date: 2018-02-28 3:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[ProfID] [int] IDENTITY(1,1) NOT NULL,
	[ProfFirstName] [varchar](60) NOT NULL,
	[ProfLastName] [varchar](60) NOT NULL,
	[SchoolName] [varchar](120) NULL,
	[ResearchTitle] [varchar](120) NOT NULL,
	[GrantMoney] [money] NOT NULL,
	[ProjectStart] [date] NOT NULL,
	[ProjectEnd] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProfID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publications]    Script Date: 2018-02-28 3:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publications](
	[PublicationID] [int] IDENTITY(1,1) NOT NULL,
	[ResearchTitle] [varchar](120) NOT NULL,
	[AuthorFirstName] [varchar](60) NOT NULL,
	[AuthorLastName] [varchar](60) NOT NULL,
	[Abstract] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[PublicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Researchers]    Script Date: 2018-02-28 3:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Researchers](
	[ResearcherID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](60) NOT NULL,
	[LastName] [varchar](60) NOT NULL,
	[SchoolName] [varchar](60) NOT NULL,
	[CurrentPosition] [varchar](60) NULL,
	[YearOfBirth] [int] NOT NULL,
	[HighestDegree] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[ResearcherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Professors] ADD  DEFAULT (NULL) FOR [ProjectEnd]
GO
ALTER TABLE [dbo].[Publications] ADD  DEFAULT (NULL) FOR [Abstract]
GO
ALTER TABLE [dbo].[Researchers] ADD  DEFAULT (NULL) FOR [CurrentPosition]
GO
ALTER TABLE [dbo].[Researchers] ADD  DEFAULT (NULL) FOR [HighestDegree]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD FOREIGN KEY([SchoolName])
REFERENCES [dbo].[Institutions] ([SchoolName])
GO
