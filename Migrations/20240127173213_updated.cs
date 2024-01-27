using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeddingProject.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HomePage1ImgPath",
                table: "HomePages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomePage2ImgPath",
                table: "HomePages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomePage3ImgPath",
                table: "HomePages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomePage4ImgPath",
                table: "HomePages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomePageDesc1",
                table: "HomePages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomePageDesc2",
                table: "HomePages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomePageDescTitle",
                table: "HomePages",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomePage1ImgPath",
                table: "HomePages");

            migrationBuilder.DropColumn(
                name: "HomePage2ImgPath",
                table: "HomePages");

            migrationBuilder.DropColumn(
                name: "HomePage3ImgPath",
                table: "HomePages");

            migrationBuilder.DropColumn(
                name: "HomePage4ImgPath",
                table: "HomePages");

            migrationBuilder.DropColumn(
                name: "HomePageDesc1",
                table: "HomePages");

            migrationBuilder.DropColumn(
                name: "HomePageDesc2",
                table: "HomePages");

            migrationBuilder.DropColumn(
                name: "HomePageDescTitle",
                table: "HomePages");
        }
    }
}
