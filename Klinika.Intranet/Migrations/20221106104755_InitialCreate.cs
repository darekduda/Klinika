using Microsoft.EntityFrameworkCore.Migrations;

namespace Klinika.Intranet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    IdAdresu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KodPocztowy = table.Column<string>(type: "nvarchar(max)", maxLength: 7, nullable: false),
                    Numer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PozycjaWyswietlania = table.Column<int>(nullable: false),
                    CzyAktywny = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.IdAdresu);
                });

            migrationBuilder.CreateTable(
                name: "GodzinyOtwarcia",
                columns: table => new
                {
                    IdGodzinyOtwarcia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dzien = table.Column<string>(maxLength: 20, nullable: false),
                    GodzinaOtwarciaOd = table.Column<string>(maxLength: 12, nullable: false),
                    GodzinaOtwarciaDo = table.Column<string>(maxLength: 12, nullable: false),
                    PozycjaWyswietlania = table.Column<int>(nullable: false),
                    CzyAktywny = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GodzinyOtwarcia", x => x.IdGodzinyOtwarcia);
                });

            migrationBuilder.CreateTable(
                name: "Kontakt",
                columns: table => new
                {
                    IdKontaktu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TytułKontakt = table.Column<string>(maxLength: 20, nullable: true),
                    NumerTelefonu = table.Column<string>(maxLength: 12, nullable: false),
                    NazwaKontaktu = table.Column<string>(maxLength: 30, nullable: false),
                    PozycjaWyswietlania = table.Column<int>(nullable: false),
                    CzyAktywny = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontakt", x => x.IdKontaktu);
                });

            migrationBuilder.CreateTable(
                name: "Parametry",
                columns: table => new
                {
                    IdParametru = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(nullable: false),
                    CzyAktywny = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametry", x => x.IdParametru);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropTable(
                name: "GodzinyOtwarcia");

            migrationBuilder.DropTable(
                name: "Kontakt");

            migrationBuilder.DropTable(
                name: "Parametry");
        }
    }
}
