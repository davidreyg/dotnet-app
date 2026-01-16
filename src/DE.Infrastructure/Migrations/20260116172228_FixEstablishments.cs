using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixEstablishments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Establishment_DisaCode_Positive",
                table: "Establishments"
            );

            migrationBuilder.DropCheckConstraint(
                name: "CK_Establishment_MicroRedCode_Positive",
                table: "Establishments"
            );

            migrationBuilder.DropCheckConstraint(
                name: "CK_Establishment_RedCode_Positive",
                table: "Establishments"
            );

            migrationBuilder.DropCheckConstraint(
                name: "CK_Establishment_SectorCode_Positive",
                table: "Establishments"
            );

            migrationBuilder.DropCheckConstraint(
                name: "CK_Establishment_UniqueCode_Positive",
                table: "Establishments"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_Establishment_DisaCode_Positive",
                table: "Establishments",
                sql: "[DisaCode] > -1"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_Establishment_MicroRedCode_Positive",
                table: "Establishments",
                sql: "[MicroRedCode] > -1"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_Establishment_RedCode_Positive",
                table: "Establishments",
                sql: "[RedCode] > -1"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_Establishment_SectorCode_Positive",
                table: "Establishments",
                sql: "[SectorCode] > -1"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_Establishment_UniqueCode_Positive",
                table: "Establishments",
                sql: "[UniqueCode] > -1"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Establishment_DisaCode_Positive",
                table: "Establishments"
            );

            migrationBuilder.DropCheckConstraint(
                name: "CK_Establishment_MicroRedCode_Positive",
                table: "Establishments"
            );

            migrationBuilder.DropCheckConstraint(
                name: "CK_Establishment_RedCode_Positive",
                table: "Establishments"
            );

            migrationBuilder.DropCheckConstraint(
                name: "CK_Establishment_SectorCode_Positive",
                table: "Establishments"
            );

            migrationBuilder.DropCheckConstraint(
                name: "CK_Establishment_UniqueCode_Positive",
                table: "Establishments"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_Establishment_DisaCode_Positive",
                table: "Establishments",
                sql: "[DisaCode] > 0"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_Establishment_MicroRedCode_Positive",
                table: "Establishments",
                sql: "[MicroRedCode] > 0"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_Establishment_RedCode_Positive",
                table: "Establishments",
                sql: "[RedCode] > 0"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_Establishment_SectorCode_Positive",
                table: "Establishments",
                sql: "[SectorCode] > 0"
            );

            migrationBuilder.AddCheckConstraint(
                name: "CK_Establishment_UniqueCode_Positive",
                table: "Establishments",
                sql: "[UniqueCode] > 0"
            );
        }
    }
}
