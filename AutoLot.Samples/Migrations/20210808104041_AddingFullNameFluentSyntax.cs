using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoLot.Samples.Migrations
{
    public partial class AddingFullNameFluentSyntax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDrivable",
                schema: "dbo",
                table: "Inventory",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "dbo",
                table: "Inventory",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "[PetName] + ' (' + [Color] + ' )'",
                stored: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "dbo",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "IsDrivable",
                schema: "dbo",
                table: "Inventory");
        }
    }
}
