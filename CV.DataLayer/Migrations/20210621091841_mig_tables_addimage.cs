using Microsoft.EntityFrameworkCore.Migrations;

namespace CV.DataLayer.Migrations
{
    public partial class mig_tables_addimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserImageName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserImageName",
                table: "Users");
        }
    }
}
