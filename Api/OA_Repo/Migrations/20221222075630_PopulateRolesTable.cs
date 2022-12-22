using Microsoft.EntityFrameworkCore.Migrations;

namespace OA_Repo.Migrations
{
    public partial class PopulateRolesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT [dbo].[AspNetRoles] ([Id], [IsDeleted], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'67ca7cce-3a45-4c6b-bad5-4e30f166901d', 0, N'TeamMember', N'TEAMMEMBER', N'80b33176-824d-4a50-bea0-0da38d7ed32d')");
            migrationBuilder.Sql("INSERT [dbo].[AspNetRoles] ([Id], [IsDeleted], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'741e6015-d539-41fe-8b2a-f4a30ae579d0', 0, N'Admin', N'ADMIN', N'd82d9e3d-9e95-41c2-9b71-e47f9ad11601')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
