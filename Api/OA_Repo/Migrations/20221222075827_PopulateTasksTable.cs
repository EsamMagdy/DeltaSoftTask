﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace OA_Repo.Migrations
{
    public partial class PopulateTasksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT [dbo].[Tasks] ON ");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (1, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 1', CAST(N'2022-12-21T10:09:41.4660000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T12:09:56.2374447' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (2, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 2', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:22.7022351' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (3, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 3', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:24.6695706' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (4, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 4', CAST(N'2022-12-22T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:25.2836165' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (5, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 5', CAST(N'2022-12-22T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:25.6901574' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (6, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 6', CAST(N'2022-12-22T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:25.8455105' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (7, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 7', CAST(N'2022-12-22T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:25.9941285' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (8, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 8', CAST(N'2022-12-22T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:26.1723821' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (9, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 9', CAST(N'2022-12-22T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:26.2865344' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (10, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 10', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:26.4216254' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (11, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 11', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:26.5745522' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (12, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 12', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:26.7542564' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (13, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 13', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:26.9204960' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (14, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 14', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:27.0661210' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (15, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 15', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:27.2038803' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (16, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 16', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:27.3440363' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (17, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 17', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:27.5060837' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (18, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 18', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:27.6570582' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (19, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 19', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:27.8048675' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (20, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 20', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T13:58:27.9537696' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (21, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 21', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:28.0879994' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (22, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 22', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:28.2303554' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (23, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 23', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T13:58:28.3877286' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (24, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 24', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T13:58:28.5309788' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (25, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 25', CAST(N'2022-12-21T11:58:07.6490000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T13:58:28.6735820' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (26, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 26', CAST(N'2022-12-22T11:58:07.6490000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T13:58:28.8281965' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (27, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 27', CAST(N'2022-12-25T13:14:42.4310000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T15:14:50.1010848' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (28, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 28', CAST(N'2022-12-25T13:18:20.3270000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T15:18:34.0370485' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (29, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 29', CAST(N'2022-12-25T13:32:29.7760000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T15:32:36.9631310' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (30, N'630003d2-fae3-45bd-99de-68d24b392b71', N'description 30', CAST(N'2022-12-26T16:09:33.2980000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T18:09:47.1268278' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (31, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 31', CAST(N'2022-12-22T16:11:48.5860000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T18:11:52.7483372' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (32, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 32', CAST(N'2022-12-26T16:13:35.8190000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T18:13:41.0646378' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (33, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 33', CAST(N'2022-12-21T17:00:51.0000000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T19:06:17.9551346' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (34, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 34', CAST(N'2022-12-26T17:06:57.7760000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T19:07:00.7888044' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (35, N'9955bafb-4e17-42fc-853f-dfb29b973377', N'description 35', CAST(N'2022-12-21T17:30:07.9090000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T19:30:12.5686820' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (36, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 36', CAST(N'2022-12-21T17:47:25.9010000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T19:47:29.0960073' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (37, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 37', CAST(N'2022-12-21T17:54:01.9940000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T19:54:08.1283915' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (38, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 38', CAST(N'2022-12-21T18:00:03.1790000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T20:05:02.2755876' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (39, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 39', CAST(N'2022-12-21T18:00:03.1790000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T20:05:50.0986621' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (40, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 40', CAST(N'2022-12-21T18:08:37.2760000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T20:08:45.7181399' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (41, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 41', CAST(N'2022-12-21T18:09:13.9320000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T20:09:19.7346503' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (42, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 42', CAST(N'2022-12-21T18:09:30.7720000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T20:09:41.1028839' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (43, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 43', CAST(N'2022-12-21T18:09:49.1960000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T20:09:53.6997987' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (44, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 44', CAST(N'2022-12-21T18:09:09.0000000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-21T20:10:35.6318340' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (45, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'description 45', CAST(N'2022-12-21T18:09:08.0000000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T20:11:14.1137964' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (46, N'cdb751d8-eef4-499e-bb47-ea3a359c6838', N'description 46', CAST(N'2022-12-21T18:18:15.4210000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-21T20:18:24.6003009' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (47, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'22 descrioption', CAST(N'2022-12-22T06:22:24.4420000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-22T08:22:31.8234705' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (48, N'9955bafb-4e17-42fc-853f-dfb29b973377', N'Description Description Description', CAST(N'2022-12-22T06:50:52.2140000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-22T08:51:01.1561649' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (49, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'aaa aaa bbb ccc ', CAST(N'2022-12-22T07:08:40.7440000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-22T09:08:50.5990718' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (50, N'779f3a8e-50b9-4ae5-8b9b-9bbc70e75014', N'aaaa ccc v v v v v v', CAST(N'2022-12-22T07:09:19.9520000' AS DateTime2), 1, 0, 0, CAST(N'2022-12-22T09:09:27.0995078' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");
            migrationBuilder.Sql("INSERT [dbo].[Tasks] ([Id], [AssignedToUserId], [Description], [DeliverDate], [MarkAsDone], [IsVisible], [IsDeleted], [CreationTime], [ModificationTime]) VALUES (51, N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'Description Description Description Description Description Description Description Description ', CAST(N'2022-12-21T18:00:03.1790000' AS DateTime2), 0, 0, 0, CAST(N'2022-12-22T09:10:05.0558488' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))");

            migrationBuilder.Sql("SET IDENTITY_INSERT [dbo].[Tasks] OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
