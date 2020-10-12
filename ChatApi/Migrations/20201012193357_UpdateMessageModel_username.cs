using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApi.Migrations
{
    public partial class UpdateMessageModel_username : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Messages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
