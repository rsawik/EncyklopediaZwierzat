using Microsoft.EntityFrameworkCore.Migrations;

namespace EncyklopediaZwierzat.Migrations
{
    public partial class ZwierzeZmianaModelu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CZyJestGatunkiemChronionym",
                table: "Zwierzeta",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CZyJestGatunkiemChronionym",
                table: "Zwierzeta");
        }
    }
}
