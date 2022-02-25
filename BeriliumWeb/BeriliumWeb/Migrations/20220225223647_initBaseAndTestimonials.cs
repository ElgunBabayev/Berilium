using Microsoft.EntityFrameworkCore.Migrations;

namespace BeriliumWeb.Migrations
{
    public partial class initBaseAndTestimonials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpWriter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownWriter = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
