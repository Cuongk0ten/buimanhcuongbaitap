using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Employeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudenID",
                table: "Person",
                newName: "SDT");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeeID",
                table: "Person",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeeID",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "SDT",
                table: "Person",
                newName: "StudenID");
        }
    }
}
