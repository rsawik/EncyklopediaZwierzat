using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EncyklopediaZwierzat.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zwierzeta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nazwa = table.Column<string>(nullable: true),
                    Rasa = table.Column<string>(nullable: true),
                    Srodowisko = table.Column<string>(nullable: true),
                    KrajWystepowania = table.Column<string>(nullable: true),
                    Odzywianie = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    SredniaDlugoscZycia = table.Column<double>(nullable: false),
                    ZdjecieUrl = table.Column<string>(nullable: true),
                    MiniaturkaUrl = table.Column<string>(nullable: true),
                    CzyZnajdeGoWPolsce = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zwierzeta", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zwierzeta");
        }
    }
}
