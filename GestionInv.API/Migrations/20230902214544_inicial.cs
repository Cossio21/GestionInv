using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionInv.API.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investigadors",
                columns: table => new
                {
                    Investigadorid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Afiliacioninstitucional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    especializacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigadors", x => x.Investigadorid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Investigadors_Nombre",
                table: "Investigadors",
                column: "Nombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investigadors");
        }
    }
}
