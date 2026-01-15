using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContractTypes",
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
                    table.PrimaryKey("PK_ContractTypes", x => x.Id);
                    table.CheckConstraint("CK_ContractType_Code_Positive", "[Code] > 0");
                }
            );

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(
                        type: "nvarchar(10)",
                        maxLength: 10,
                        nullable: false
                    ),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                }
            );

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

            migrationBuilder.CreateTable(
                name: "Ethnicities",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(
                        type: "nvarchar(50)",
                        maxLength: 50,
                        nullable: false
                    ),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ethnicities", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "ExtraConditions",
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
                    table.PrimaryKey("PK_ExtraConditions", x => x.Id);
                    table.CheckConstraint("CK_ExtraCondition_Code_Positive", "[Code] > 0");
                }
            );

            migrationBuilder.CreateTable(
                name: "Financiers",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    ),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financiers", x => x.Id);
                    table.CheckConstraint("CK_Financier_Code_Positive", "[Code] > 0");
                }
            );

            migrationBuilder.CreateTable(
                name: "HealthServiceUnits",
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
                    table.PrimaryKey("PK_HealthServiceUnits", x => x.Id);
                    table.CheckConstraint("CK_HealthServiceUnit_Code_Positive", "[Code] > 0");
                }
            );

            migrationBuilder.CreateTable(
                name: "IdentityDocumentTypes",
                columns: table => new
                {
                    Id = table
                        .Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(
                        type: "nvarchar(10)",
                        maxLength: 10,
                        nullable: false
                    ),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GuidCode = table.Column<Guid>(
                        type: "uniqueidentifier",
                        nullable: false,
                        defaultValueSql: "NEWID()"
                    ),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    IsDeleted = table.Column<bool>(
                        type: "bit",
                        nullable: false,
                        defaultValue: false
                    ),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityDocumentTypes", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "MedicalProcedures",
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
                    table.PrimaryKey("PK_MedicalProcedures", x => x.Id);
                    table.CheckConstraint("CK_MedicalProcedure_Code_Positive", "[Code] > 0");
                }
            );

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
                    table.UniqueConstraint("AK_ProfessionalCouncils_Code", x => x.Code);
                    table.CheckConstraint("CK_ProfessionalCouncil_Code_Positive", "[Code] > 0");
                }
            );

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ProfessionalCouncilCode = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                    table.CheckConstraint("CK_Profession_Code_Positive", "[Code] > 0");
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "ContractTypes");

            migrationBuilder.DropTable(name: "Countries");

            migrationBuilder.DropTable(name: "Establishments");

            migrationBuilder.DropTable(name: "Ethnicities");

            migrationBuilder.DropTable(name: "ExtraConditions");

            migrationBuilder.DropTable(name: "Financiers");

            migrationBuilder.DropTable(name: "HealthServiceUnits");

            migrationBuilder.DropTable(name: "IdentityDocumentTypes");

            migrationBuilder.DropTable(name: "MedicalProcedures");

            migrationBuilder.DropTable(name: "ProfessionalCouncils");

            migrationBuilder.DropTable(name: "Professions");
        }
    }
}
