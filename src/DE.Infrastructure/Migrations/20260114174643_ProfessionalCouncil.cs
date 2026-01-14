using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProfessionalCouncil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfessionalCouncils",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalCouncils", x => x.Id);
                    table.CheckConstraint("CK_ProfessionalCouncil_Code_Positive", "[Code] > 0");
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "ProfessionalCouncils");
        }
    }
}
