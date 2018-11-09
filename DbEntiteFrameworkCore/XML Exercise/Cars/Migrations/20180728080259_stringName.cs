using Microsoft.EntityFrameworkCore.Migrations;

namespace Cars.Migrations
{
    public partial class stringName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Suppliers",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Suppliers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
