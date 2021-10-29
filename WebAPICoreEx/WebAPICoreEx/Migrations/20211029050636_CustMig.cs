using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPICoreEx.Migrations
{
    public partial class CustMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CId = table.Column<string>(nullable: false),
                    CName = table.Column<string>(maxLength: 50, nullable: false),
                    CCity = table.Column<string>(maxLength: 50, nullable: false),
                    CODLimit = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
