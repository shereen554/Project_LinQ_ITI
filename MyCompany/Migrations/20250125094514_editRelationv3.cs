using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCompany.Migrations
{
    /// <inheritdoc />
    public partial class editRelationv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_MGRSSN",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MGRSSN",
                table: "Departments",
                column: "MGRSSN",
                unique: true,
                filter: "[MGRSSN] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_MGRSSN",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MGRSSN",
                table: "Departments",
                column: "MGRSSN");
        }
    }
}
