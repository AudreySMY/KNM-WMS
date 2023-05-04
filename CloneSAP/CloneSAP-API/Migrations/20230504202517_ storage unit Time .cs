using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloneSAP_API.Migrations
{
    /// <inheritdoc />
    public partial class storageunitTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatingDating",
                table: "StorageUnit",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModif",
                table: "StorageUnit",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatingDating",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "LastModif",
                table: "StorageUnit");
        }
    }
}
