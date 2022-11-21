using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DCDentalCare.Migrations
{
    /// <inheritdoc />
    public partial class Clavesforaneasaplicadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEspecialidad",
                table: "Doctores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEspecialidad",
                table: "Doctores");
        }
    }
}
