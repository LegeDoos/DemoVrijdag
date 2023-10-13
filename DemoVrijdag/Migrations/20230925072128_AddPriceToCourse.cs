using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoVrijdag.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceToCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Course",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Course");
        }
    }
}
