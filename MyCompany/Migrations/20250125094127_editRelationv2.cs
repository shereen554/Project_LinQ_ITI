using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCompany.Migrations
{
    /// <inheritdoc />
    public partial class editRelationv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_Fors_Employees_ESSN",
                table: "Works_Fors");

            migrationBuilder.DropTable(
                name: "DepartmentEmployee");

            migrationBuilder.DropIndex(
                name: "IX_Departments_MGRSSN",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Works_Fors");

            migrationBuilder.DropColumn(
                name: "Pnumber",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Bdate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Nam",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MGRStartDate",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "ESSN",
                table: "Works_Fors",
                newName: "ESSn");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Projects",
                newName: "PNum");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "SSN");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Departments",
                newName: "Dnum");

            migrationBuilder.AlterColumn<string>(
                name: "Pname",
                table: "Projects",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Plocation",
                table: "Projects",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Dnum",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Salary",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Dname",
                table: "Departments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "MGRStart Date",
                table: "Departments",
                type: "datetime",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_Dnum",
                table: "Projects",
                column: "Dnum");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Dno",
                table: "Employees",
                column: "Dno");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MGRSSN",
                table: "Departments",
                column: "MGRSSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_Dno",
                table: "Employees",
                column: "Dno",
                principalTable: "Departments",
                principalColumn: "Dnum");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_Dnum",
                table: "Projects",
                column: "Dnum",
                principalTable: "Departments",
                principalColumn: "Dnum");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Fors_Employees_ESSn",
                table: "Works_Fors",
                column: "ESSn",
                principalTable: "Employees",
                principalColumn: "SSN",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_Dno",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_Dnum",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Fors_Employees_ESSn",
                table: "Works_Fors");

            migrationBuilder.DropIndex(
                name: "IX_Projects_Dnum",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Dno",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Departments_MGRSSN",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Dnum",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MGRStart Date",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "ESSn",
                table: "Works_Fors",
                newName: "ESSN");

            migrationBuilder.RenameColumn(
                name: "PNum",
                table: "Projects",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "SSN",
                table: "Employees",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "Dnum",
                table: "Departments",
                newName: "DepartmentId");

            migrationBuilder.AddColumn<int>(
                name: "Hours",
                table: "Works_Fors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Pname",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Plocation",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Pnumber",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<DateTime>(
                name: "Bdate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nam",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Dname",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<DateTime>(
                name: "MGRStartDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "DepartmentEmployee",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentEmployee", x => new { x.DepartmentId, x.EmployeesEmployeeId });
                    table.ForeignKey(
                        name: "FK_DepartmentEmployee_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentEmployee_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MGRSSN",
                table: "Departments",
                column: "MGRSSN",
                unique: true,
                filter: "[MGRSSN] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployee_EmployeesEmployeeId",
                table: "DepartmentEmployee",
                column: "EmployeesEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Fors_Employees_ESSN",
                table: "Works_Fors",
                column: "ESSN",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
