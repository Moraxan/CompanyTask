using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class AddedSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePosition_Employees_Employeesid",
                table: "EmployeePosition");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePosition_Positions_Positionsid",
                table: "EmployeePosition");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Positions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "LinkPositions",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "PositionID",
                table: "LinkPositions",
                newName: "PositionId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Employees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Positionsid",
                table: "EmployeePosition",
                newName: "PositionsId");

            migrationBuilder.RenameColumn(
                name: "Employeesid",
                table: "EmployeePosition",
                newName: "EmployeesId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeePosition_Positionsid",
                table: "EmployeePosition",
                newName: "IX_EmployeePosition_PositionsId");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "Departments",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Departments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CompanyNames",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "CompanyNames",
                columns: new[] { "Id", "Company" },
                values: new object[,]
                {
                    { 1, "Corporate Data Sweden" },
                    { 2, "Corporate Data Norway" },
                    { 3, "Corporate Data Finland" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, 2, "Office" },
                    { 2, 1, "Engineering" },
                    { 3, 3, "Coding" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FirstName", "LastName", "Salary", "UnionAttached" },
                values: new object[,]
                {
                    { 1, 1, "Gösta", "Bernard", 50000, false },
                    { 2, 2, "Monika", "Zetterlund", 30000, true },
                    { 3, 3, "Svante", "Turesson", 30000, false }
                });

            migrationBuilder.InsertData(
                table: "LinkPositions",
                columns: new[] { "EmployeeId", "PositionId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 2, 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePosition_Employees_EmployeesId",
                table: "EmployeePosition",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePosition_Positions_PositionsId",
                table: "EmployeePosition",
                column: "PositionsId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePosition_Employees_EmployeesId",
                table: "EmployeePosition");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePosition_Positions_PositionsId",
                table: "EmployeePosition");

            migrationBuilder.DeleteData(
                table: "CompanyNames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompanyNames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompanyNames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LinkPositions",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "LinkPositions",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "LinkPositions",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "LinkPositions",
                keyColumns: new[] { "EmployeeId", "PositionId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Positions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "LinkPositions",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "LinkPositions",
                newName: "PositionID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PositionsId",
                table: "EmployeePosition",
                newName: "Positionsid");

            migrationBuilder.RenameColumn(
                name: "EmployeesId",
                table: "EmployeePosition",
                newName: "Employeesid");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeePosition_PositionsId",
                table: "EmployeePosition",
                newName: "IX_EmployeePosition_Positionsid");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Departments",
                newName: "CompanyID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Departments",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CompanyNames",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePosition_Employees_Employeesid",
                table: "EmployeePosition",
                column: "Employeesid",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePosition_Positions_Positionsid",
                table: "EmployeePosition",
                column: "Positionsid",
                principalTable: "Positions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
