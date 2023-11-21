using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_REST.Migrations
{
    public partial class PeticionEditada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Request",
                table: "Peticiones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Request",
                table: "Peticiones");
        }
    }
}
