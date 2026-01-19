using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class HisAttention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HisAttentions",
                columns: table => new
                {
                    AppointmentId = table.Column<long>(type: "bigint", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    AttendanceDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Batch = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumPag = table.Column<int>(type: "int", nullable: false),
                    NumReg = table.Column<int>(type: "int", nullable: false),
                    HealthServiceUnitCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EstablishmentCode = table.Column<int>(type: "int", nullable: false),
                    Renipress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EducationalInstitutionCode = table.Column<int>(type: "int", nullable: false),
                    PatientCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RegistrarId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FinancierCode = table.Column<int>(type: "int", nullable: false),
                    AgeReg = table.Column<int>(type: "int", nullable: false),
                    AgeType = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    PatientCurrentYear = table.Column<int>(type: "int", nullable: false),
                    PatientCurrentMonth = table.Column<int>(type: "int", nullable: false),
                    PatientCurrentDay = table.Column<int>(type: "int", nullable: false),
                    RiskGroupDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PregnancyCondition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrePregnancyWeight = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    ShiftId = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DiagnosisType = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    LabValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CorrelativeId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LabCorrelativeId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DoseId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Height = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Hemoglobin = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: true),
                    AbdominalCircumference = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    HeadCircumference = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    LastMenstrualPeriod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HbRequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HbResultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CountryCode = table.Column<int>(type: "int", nullable: false),
                    OriginApplicationId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Alert = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HisAttentions", x => x.AppointmentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HisAttentions");
        }
    }
}
