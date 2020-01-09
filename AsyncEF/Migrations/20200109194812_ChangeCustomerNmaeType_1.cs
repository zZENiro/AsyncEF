using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncEF.Migrations
{
    public partial class ChangeCustomerNmaeType_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "CustomerKey",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddUniqueConstraint(
                name: "CustomerKey",
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerName" });
        }
    }
}
