using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_ProfessionalCouncils_Code",
                table: "ProfessionalCouncils",
                column: "Code"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_ProfessionalCouncils_Code",
                table: "ProfessionalCouncils"
            );
        }
    }
}
