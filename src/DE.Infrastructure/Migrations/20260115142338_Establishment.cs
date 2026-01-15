using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Establishment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Establishments",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(
                        type: "nvarchar(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    Ubigeo = table.Column<int>(type: "int", nullable: false),
                    DisaCode = table.Column<int>(type: "int", nullable: false),
                    DisaName = table.Column<string>(
                        type: "nvarchar(150)",
                        maxLength: 150,
                        nullable: false
                    ),
                    RedCode = table.Column<int>(type: "int", nullable: false),
                    RedName = table.Column<string>(
                        type: "nvarchar(150)",
                        maxLength: 150,
                        nullable: false
                    ),
                    MicroRedCode = table.Column<int>(type: "int", nullable: false),
                    MicroRedName = table.Column<string>(
                        type: "nvarchar(150)",
                        maxLength: 150,
                        nullable: false
                    ),
                    UniqueCode = table.Column<int>(type: "int", nullable: false),
                    SectorCode = table.Column<int>(type: "int", nullable: false),
                    SectorDescription = table.Column<string>(
                        type: "nvarchar(150)",
                        maxLength: 150,
                        nullable: false
                    ),
                    Department = table.Column<string>(
                        type: "nvarchar(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    Province = table.Column<string>(
                        type: "nvarchar(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    District = table.Column<string>(
                        type: "nvarchar(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Establishments", x => x.Id);
                    table.CheckConstraint("CK_Establishment_DisaCode_Positive", "[DisaCode] > 0");
                    table.CheckConstraint(
                        "CK_Establishment_MicroRedCode_Positive",
                        "[MicroRedCode] > 0"
                    );
                    table.CheckConstraint("CK_Establishment_RedCode_Positive", "[RedCode] > 0");
                    table.CheckConstraint(
                        "CK_Establishment_SectorCode_Positive",
                        "[SectorCode] > 0"
                    );
                    table.CheckConstraint("CK_Establishment_Ubigeo_Positive", "[Ubigeo] > 0");
                    table.CheckConstraint(
                        "CK_Establishment_UniqueCode_Positive",
                        "[UniqueCode] > 0"
                    );
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Establishments");
        }
    }
}
