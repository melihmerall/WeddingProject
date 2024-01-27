using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeddingProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutPages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutSecondTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescHome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescHome2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescHome3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescHomeImagePath1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescHomeImagePath2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescHomeImagePath3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescHomeImagePath4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutOurMission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutOurMissionDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurMissionImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service1Count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service1Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service2Count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service2Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service3Count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service3Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service4Count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service4Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactPages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContctTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactSecondTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactFace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactInsta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactWp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slider1Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slider1ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slider2Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slider2ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slider3Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slider3ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurHistoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurHistoryDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurHistoryStick1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurHistoryStick2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurHistoryStick3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurHistoryStick4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurHistoryStick5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurHistoryStick6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service1Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service1Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service2Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service3Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service3Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service4Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service4Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePages", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutPages");

            migrationBuilder.DropTable(
                name: "ContactPages");

            migrationBuilder.DropTable(
                name: "HomePages");
        }
    }
}
