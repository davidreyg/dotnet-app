using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeCode = table.Column<int>(type: "int", nullable: false),
                    DocumentNumber = table.Column<string>(
                        type: "nvarchar(20)",
                        maxLength: 20,
                        nullable: false
                    ),
                    LastName = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    ),
                    MotherLastName = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    ),
                    FirstName = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    ),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    ContractTypeCode = table.Column<int>(type: "int", nullable: false),
                    ProfessionCode = table.Column<int>(type: "int", nullable: false),
                    ProfessionalCouncilCode = table.Column<int>(type: "int", nullable: false),
                    LicenseNumber = table.Column<string>(
                        type: "nvarchar(20)",
                        maxLength: 20,
                        nullable: true
                    ),
                    EstablishmentCode = table.Column<int>(type: "int", nullable: false),
                    HireDate = table.Column<DateTime>(type: "date", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "date", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Employees");
        }
    }
}
