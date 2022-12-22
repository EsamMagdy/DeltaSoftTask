using Microsoft.EntityFrameworkCore.Migrations;

namespace OA_Repo.Migrations
{
    public partial class PopulateUserRolesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0b642e94-c6b6-43cc-869e-c4c3b7fb7305', N'67ca7cce-3a45-4c6b-bad5-4e30f166901d')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'630003d2-fae3-45bd-99de-68d24b392b71', N'67ca7cce-3a45-4c6b-bad5-4e30f166901d')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'779f3a8e-50b9-4ae5-8b9b-9bbc70e75014', N'67ca7cce-3a45-4c6b-bad5-4e30f166901d')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9955bafb-4e17-42fc-853f-dfb29b973377', N'67ca7cce-3a45-4c6b-bad5-4e30f166901d')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cdb751d8-eef4-499e-bb47-ea3a359c6838', N'67ca7cce-3a45-4c6b-bad5-4e30f166901d')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6f44fe87-3b5f-436f-bcfe-2a158ccf4149', N'741e6015-d539-41fe-8b2a-f4a30ae579d0')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
