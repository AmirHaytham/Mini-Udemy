USE [mini_udemi]
GO
INSERT [dbo].[Department] ([Dept_Id], [Dept_Name], [Dept_Desc]) VALUES (10, N'PL', N'Programming Language')
INSERT [dbo].[Department] ([Dept_Id], [Dept_Name], [Dept_Desc]) VALUES (20, N'SD', N'System Development')
INSERT [dbo].[Department] ([Dept_Id], [Dept_Name], [Dept_Desc]) VALUES (30, N'UNIX', N'UNIX')
INSERT [dbo].[Department] ([Dept_Id], [Dept_Name], [Dept_Desc]) VALUES (40, N'WD', N'Web Development')
INSERT [dbo].[Department] ([Dept_Id], [Dept_Name], [Dept_Desc]) VALUES (50, N'DB', N'DataBase')
GO
INSERT [dbo].[Course] ([Crs_ID], [Crs_Name], [Crs_Duration], [Dept_Id], [Image_Url]) VALUES (100, N'HTML', 20, 40, NULL)
INSERT [dbo].[Course] ([Crs_ID], [Crs_Name], [Crs_Duration], [Dept_Id], [Image_Url]) VALUES (200, N'Cs50', 40, 10, NULL)
INSERT [dbo].[Course] ([Crs_ID], [Crs_Name], [Crs_Duration], [Dept_Id], [Image_Url]) VALUES (300, N'OOP', 60, 20, NULL)
INSERT [dbo].[Course] ([Crs_ID], [Crs_Name], [Crs_Duration], [Dept_Id], [Image_Url]) VALUES (400, N'Sql Server', 40, 50, NULL)
INSERT [dbo].[Course] ([Crs_ID], [Crs_Name], [Crs_Duration], [Dept_Id], [Image_Url]) VALUES (500, N'C#', 60, 10, NULL)
INSERT [dbo].[Course] ([Crs_ID], [Crs_Name], [Crs_Duration], [Dept_Id], [Image_Url]) VALUES (600, N'Java', 60, 10, NULL)
INSERT [dbo].[Course] ([Crs_ID], [Crs_Name], [Crs_Duration], [Dept_Id], [Image_Url]) VALUES (700, N'Oracle', 60, 50, NULL)
INSERT [dbo].[Course] ([Crs_ID], [Crs_Name], [Crs_Duration], [Dept_Id], [Image_Url]) VALUES (800, N'ASP.net', 80, 40, NULL)
INSERT [dbo].[Course] ([Crs_ID], [Crs_Name], [Crs_Duration], [Dept_Id], [Image_Url]) VALUES (900, N'unix', 60, 30, NULL)
GO
INSERT [dbo].[Student] ([St_Id], [St_Fname], [St_Lname], [St_gender], [St_BD], [St_Age], [St_Email], [St_Password]) VALUES (1, N'mahmoud', N'taha', N'm', NULL, 22, N'mtaha410@gmail.com', N'aba147187')
INSERT [dbo].[Student] ([St_Id], [St_Fname], [St_Lname], [St_gender], [St_BD], [St_Age], [St_Email], [St_Password]) VALUES (2, N'mahmoud', N'ashour', N'm', NULL, 21, NULL, N'123456789')
GO
INSERT [dbo].[Std_Crs] ([St_Id], [Crs_Id]) VALUES (1, 100)
INSERT [dbo].[Std_Crs] ([St_Id], [Crs_Id]) VALUES (1, 300)
INSERT [dbo].[Std_Crs] ([St_Id], [Crs_Id]) VALUES (2, 400)
INSERT [dbo].[Std_Crs] ([St_Id], [Crs_Id]) VALUES (2, 600)
GO
