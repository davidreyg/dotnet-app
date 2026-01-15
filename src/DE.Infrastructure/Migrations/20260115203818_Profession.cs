using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Profession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ProfessionalCouncilCode = table.Column<int>(type: "int", nullable: false),
                    ProfessionalCouncilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                    table.CheckConstraint("CK_Profession_Code_Positive", "[Code] > 0");
                    table.ForeignKey(
                        name: "FK_Professions_ProfessionalCouncils_ProfessionalCouncilId",
                        column: x => x.ProfessionalCouncilId,
                        principalTable: "ProfessionalCouncils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Professions_ProfessionalCouncilId",
                table: "Professions",
                column: "ProfessionalCouncilId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Professions");
        }
    }
}
