using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DCDentalCare.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EstadoId",
                table: "Reservas",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Estados_EstadoId",
                table: "Reservas",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Estados_EstadoId",
                table: "Reservas");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_EstadoId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Reservas");
        }
    }
}
