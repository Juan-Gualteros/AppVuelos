using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vuelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ciudadOrigen = table.Column<string>(type: "TEXT", nullable: false),
                    ciudadDestino = table.Column<string>(type: "TEXT", nullable: false),
                    fecha = table.Column<string>(type: "TEXT", nullable: false),
                    horaSalida = table.Column<int>(type: "INTEGER", nullable: false),
                    horaLlegada = table.Column<int>(type: "INTEGER", nullable: false),
                    numeroDeVuelo = table.Column<int>(type: "INTEGER", nullable: false),
                    aerolinea = table.Column<string>(type: "TEXT", nullable: false),
                    estadoDelVuelo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vuelos");
        }
    }
}
