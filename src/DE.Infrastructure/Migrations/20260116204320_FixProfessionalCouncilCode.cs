using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixProfessionalCouncilCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_ProfessionalCouncil_Code_Positive",
                table: "ProfessionalCouncils");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProfessionalCouncils",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddCheckConstraint(
                name: "CK_ProfessionalCouncil_Code_Positive",
                table: "ProfessionalCouncils",
                sql: "[Code] > -1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_ProfessionalCouncil_Code_Positive",
                table: "ProfessionalCouncils");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProfessionalCouncils",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddCheckConstraint(
                name: "CK_ProfessionalCouncil_Code_Positive",
                table: "ProfessionalCouncils",
                sql: "[Code] > 0");
        }
    }
}
