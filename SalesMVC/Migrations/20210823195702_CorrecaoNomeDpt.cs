using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesMVC.Migrations
{
    public partial class CorrecaoNomeDpt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentID",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Seller",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentID",
                table: "Seller",
                newName: "IX_Seller_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "DeptName",
                table: "Department",
                newName: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Seller",
                newName: "DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller",
                newName: "IX_Seller_DepartmentID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Department",
                newName: "DeptName");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentID",
                table: "Seller",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
