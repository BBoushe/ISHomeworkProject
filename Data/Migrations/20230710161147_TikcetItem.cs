using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticketopia.Data.Migrations
{
    public partial class TikcetItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieImage",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieImage",
                table: "Tickets");
        }
    }
}
