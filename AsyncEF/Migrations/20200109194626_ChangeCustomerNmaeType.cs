using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncEF.Migrations
{
    public partial class ChangeCustomerNmaeType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CustomerName",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
