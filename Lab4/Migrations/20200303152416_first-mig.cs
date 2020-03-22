using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelAPI.Migrations
{
    public partial class firstmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    FullPath = table.Column<string>(nullable: true),
                    MovieName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Event = table.Column<string>(nullable: true),
                    TaggedPersons = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    FlgMoved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    FullPath = table.Column<string>(nullable: true),
                    MovieName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Event = table.Column<string>(nullable: true),
                    TaggedPersons = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Weitght = table.Column<int>(nullable: false),
                    FlgMoved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    MovieOrPhotoID = table.Column<Guid>(nullable: false),
                    PropCode = table.Column<Guid>(nullable: false),
                    PropDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PropertyCodes",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCodes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "PropertyCodes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
