using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJEM.Migrations
{
    /// <inheritdoc />
    public partial class SoruGuncelleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SoruMetni",
                table: "TümSorular",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DogruCevap",
                table: "TümSorular",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KullaniciCevabi",
                table: "TümSorular",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Sonuc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SoruID = table.Column<int>(type: "INTEGER", nullable: false),
                    KullaniciID = table.Column<string>(type: "TEXT", nullable: false),
                    VerilenCevap = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sonuc", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sonuc");

            migrationBuilder.DropColumn(
                name: "KullaniciCevabi",
                table: "TümSorular");

            migrationBuilder.AlterColumn<string>(
                name: "SoruMetni",
                table: "TümSorular",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "DogruCevap",
                table: "TümSorular",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
