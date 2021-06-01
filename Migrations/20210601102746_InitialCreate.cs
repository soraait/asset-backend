using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoodsDetail",
                columns: table => new
                {
                    GoodsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsName = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    GoodsNo = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    GoodsBrand = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    GoodsModel = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    GoodsSerailNumber = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsDetail", x => x.GoodsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsDetail");
        }
    }
}
