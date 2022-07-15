using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class parametrs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parametrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ekran = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ROM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kamera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ceki = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametrs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parametrs");
        }
    }
}
