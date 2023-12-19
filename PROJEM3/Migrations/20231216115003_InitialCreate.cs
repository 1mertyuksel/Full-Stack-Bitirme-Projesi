using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJEM.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TümSorular",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SoruMetni = table.Column<string>(type: "TEXT", nullable: true),
                    DogruCevap = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TümSorular", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Secenekler",
                columns: table => new
                {
                    SecenekID = table.Column<string>(type: "TEXT", nullable: false),
                    SecenekMetni = table.Column<string>(type: "TEXT", nullable: true),
                    SoruID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secenekler", x => x.SecenekID);
                    table.ForeignKey(
                        name: "FK_Secenekler_TümSorular_SoruID",
                        column: x => x.SoruID,
                        principalTable: "TümSorular",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Secenekler_SoruID",
                table: "Secenekler",
                column: "SoruID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Secenekler");

            migrationBuilder.DropTable(
                name: "TümSorular");
        }
    }
}
