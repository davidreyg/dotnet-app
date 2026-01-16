using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixMedicalProcedureCodeType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_MedicalProcedure_Code_Positive",
                table: "MedicalProcedures"
            );

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MedicalProcedures",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)"
            );

            migrationBuilder.AlterColumn<double>(
                name: "Code",
                table: "MedicalProcedures",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MedicalProcedures",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255
            );

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "MedicalProcedures",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_MedicalProcedure_Code_Positive",
                table: "MedicalProcedures",
                sql: "[Code] > 0"
            );
        }
    }
}
