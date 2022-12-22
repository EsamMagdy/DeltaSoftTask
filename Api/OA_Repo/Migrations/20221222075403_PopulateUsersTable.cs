using Microsoft.EntityFrameworkCore.Migrations;

namespace OA_Repo.Migrations
{
    public partial class PopulateUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[AspNetUsers] ([Id], [IsDeleted], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', 0, N'Ahmed', N'AHMED', N'ahmed@gmail.com', N'AHMED@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELM3Ev9qqvVUUBO6YRUBC84FEBOHksDwAVeceMS0U++IVuTph1Lf6PSGD1dt3rUBVQ==', N'RZZNE3VZLQZXSXKVVY6KDAML3BAPZE6A', N'3a4d882c-a64c-4a5b-8ad7-e1e7ef3805b1', NULL, 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUsers] ([Id], [IsDeleted], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'630003d2-fae3-45bd-99de-68d24b392b71', 0, N'Test', N'TEST', N'test@test.com', N'TEST@TEST.COM', 0, N'AQAAAAEAACcQAAAAEMQUGJT+mdJm711xWdxvuVTLoUtC+HEtLcDP2JxCP6U7MlxIqBSuLe3Q6Z+v9+jThQ==', N'OCRPB76MY2E6J6RUSXCUOTKQG3XKYNXD', N'd063c7a6-6fcb-40f9-b2d4-8498283e497a', NULL, 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUsers] ([Id], [IsDeleted], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6f44fe87-3b5f-436f-bcfe-2a158ccf4149', 0, N'Esam Magdy', N'ESAM MAGDY', N'dev.esam2014@gmail.com', N'DEV.ESAM2014@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEFNdH1t6Z6BpDpKB8pSHUNU0Qf3kdKGtqCedT6v20XdEMEDPSb9dfeAuNNUmermOVw==', N'COQYYPYH7VAWSMXMRR6MLDKWQJHSVB2X', N'c1a6d65d-2d44-418c-a161-f0e6c28e8c02', NULL, 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUsers] ([Id], [IsDeleted], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'779f3a8e-50b9-4ae5-8b9b-9bbc70e75014', 0, N'Mohamed', N'MOHAMED', N'mohamed@gmail.com', N'MOHAMED@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEI0/CRULKWjjaVDm85riujGkwEGkq5p7v0c5ITpXVpZSqjPTli2ZQGyKIxCdztnc4w==', N'D7H27PUBTZPOOTNW77ZTPZFME4QZZYCM', N'8ed3820a-64ed-4301-b7db-2364f3de5cd9', NULL, 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUsers] ([Id], [IsDeleted], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'9955bafb-4e17-42fc-853f-dfb29b973377', 0, N'Porro animi itaque ', N'PORRO ANIMI ITAQUE ', N'wihoqez@mailinator.com', N'WIHOQEZ@MAILINATOR.COM', 0, N'AQAAAAEAACcQAAAAEIltQVTUqDzWfOyom1vii8yX2OM9IH/uAusIJNKbcRxznMDTKsGO3L5k7T6/rPJ7jA==', N'R4QQ6DBYQAUZAIHX6ZG3Q2Y7L7IL66XX', N'e66fefd9-e965-474d-802c-363a998536d7', NULL, 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUsers] ([Id], [IsDeleted], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'cdb751d8-eef4-499e-bb47-ea3a359c6838', 0, N'Dolor odio consectet', N'DOLOR ODIO CONSECTET', N'qumok@mailinator.com', N'QUMOK@MAILINATOR.COM', 0, N'AQAAAAEAACcQAAAAEIXrBgXauFTfQO7VqmbGemDMrqDl/f78mZwwKcQZ/qSaTVCLZ+tZhj2Llmo5S4KuyA==', N'XG3CABH65GJYYHF3IX7OWRAG6P4NNSJI', N'e2d1f27f-b12a-444a-aafb-48f5e9a956c1', NULL, 0, 0, NULL, 1, 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
