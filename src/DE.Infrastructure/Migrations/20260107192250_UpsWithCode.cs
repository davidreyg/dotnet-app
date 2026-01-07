using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpsWithCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Ups",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "Ups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddCheckConstraint(
                name: "CK_Ups_Code_Positive",
                table: "Ups",
                sql: "[Code] > 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Ups_Code_Positive",
                table: "Ups");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Ups");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Ups",
                newName: "Descripcion");
        }
    }
}
