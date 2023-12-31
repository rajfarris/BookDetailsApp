USE [BooksDB]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 25-06-2023 21:37:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Publisher] [nvarchar](200) NULL,
	[Title] [nvarchar](200) NULL,
	[AuthorLastName] [nvarchar](100) NULL,
	[AuthorFirstName] [nvarchar](100) NULL,
	[Price] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Id], [Publisher], [Title], [AuthorLastName], [AuthorFirstName], [Price], [CreatedDate]) VALUES (1, N'CodeWell', N'Automation', N'Peter', N'John', CAST(250.00 AS Decimal(18, 2)), CAST(N'2023-06-25T00:01:59.447' AS DateTime))
INSERT [dbo].[Books] ([Id], [Publisher], [Title], [AuthorLastName], [AuthorFirstName], [Price], [CreatedDate]) VALUES (2, N'Publisher 1', N'Book 1', N'AuthorLast 1', N'AuthorFirst 1', CAST(9.99 AS Decimal(18, 2)), CAST(N'2023-06-25T00:33:49.287' AS DateTime))
INSERT [dbo].[Books] ([Id], [Publisher], [Title], [AuthorLastName], [AuthorFirstName], [Price], [CreatedDate]) VALUES (3, N'Publisher 2', N'Book 2', N'AuthorLast 2', N'AuthorFirst 2', CAST(14.99 AS Decimal(18, 2)), CAST(N'2023-06-25T00:33:49.307' AS DateTime))
INSERT [dbo].[Books] ([Id], [Publisher], [Title], [AuthorLastName], [AuthorFirstName], [Price], [CreatedDate]) VALUES (4, N'Publisher 3', N'Book 3', N'AuthorLast 3', N'AuthorFirst 3', CAST(19.99 AS Decimal(18, 2)), CAST(N'2023-06-25T00:33:49.307' AS DateTime))
INSERT [dbo].[Books] ([Id], [Publisher], [Title], [AuthorLastName], [AuthorFirstName], [Price], [CreatedDate]) VALUES (5, N'Publisher 6', N'Book 6', N'AuthorLast 6', N'AuthorFirst 6', CAST(9.99 AS Decimal(18, 2)), CAST(N'2023-06-25T20:22:17.880' AS DateTime))
INSERT [dbo].[Books] ([Id], [Publisher], [Title], [AuthorLastName], [AuthorFirstName], [Price], [CreatedDate]) VALUES (6, N'Publisher 7', N'Book 7', N'AuthorLast 7', N'AuthorFirst 7', CAST(14.99 AS Decimal(18, 2)), CAST(N'2023-06-25T20:22:17.897' AS DateTime))
INSERT [dbo].[Books] ([Id], [Publisher], [Title], [AuthorLastName], [AuthorFirstName], [Price], [CreatedDate]) VALUES (7, N'Publisher 8', N'Book 8', N'AuthorLast 8', N'AuthorFirst 8', CAST(19.99 AS Decimal(18, 2)), CAST(N'2023-06-25T20:22:17.897' AS DateTime))
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
/****** Object:  StoredProcedure [dbo].[GetBooksSortedByAuthorTitle]    Script Date: 25-06-2023 21:37:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBooksSortedByAuthorTitle]
AS
BEGIN
    SELECT *
    FROM Books
    ORDER BY  AuthorLastName, AuthorFirstName, Title
END
GO
/****** Object:  StoredProcedure [dbo].[GetBooksSortedByPublisherAuthorTitle]    Script Date: 25-06-2023 21:37:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBooksSortedByPublisherAuthorTitle]
AS
BEGIN
    SELECT *
    FROM Books
    ORDER BY Publisher, AuthorLastName, AuthorFirstName, Title
END
GO
