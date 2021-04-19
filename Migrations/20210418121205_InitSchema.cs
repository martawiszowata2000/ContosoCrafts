using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoCrafts.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(maxLength: 40, nullable: true),
                    Maker = table.Column<string>(maxLength: 20, nullable: true),
                    Image = table.Column<string>(maxLength: 120, nullable: true),
                    Url = table.Column<string>(maxLength: 120, nullable: true),
                    Title = table.Column<string>(maxLength: 70, nullable: true),
                    Description = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
