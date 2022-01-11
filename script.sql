USE [APIDB]
GO
SET IDENTITY_INSERT [dbo].[Positions] ON 

INSERT [dbo].[Positions] ([Id], [Name]) VALUES (1, N'excellent')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (2, N'practitioner')
SET IDENTITY_INSERT [dbo].[Positions] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [Surname], [Age], [CreatedDate], [PositinId]) VALUES (2, N'Rasim', N'Qasimov', 16, CAST(N'2020-01-11T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Age], [CreatedDate], [PositinId]) VALUES (3, N'Qasim', N'Abbasov', 17, CAST(N'2020-01-11T00:00:00.0000000' AS DateTime2), 2)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Age], [CreatedDate], [PositinId]) VALUES (4, N'Gunay', N'Isgenderova', 15, CAST(N'2020-01-11T00:00:00.0000000' AS DateTime2), 2)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Age], [CreatedDate], [PositinId]) VALUES (5, N'Inci', N'Abbasova', 13, CAST(N'2020-01-11T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Students] ([Id], [Name], [Surname], [Age], [CreatedDate], [PositinId]) VALUES (6, N'Murad', N'Aliyev', 15, CAST(N'2022-01-11T11:16:30.3426506' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
