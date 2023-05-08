using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloneSAP_API.Migrations
{
    /// <inheritdoc />
    public partial class sizeCodandCollorcod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollorCod",
                table: "Grid");

            migrationBuilder.RenameColumn(
                name: "SizeCod",
                table: "Grid",
                newName: "GridCod");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GridCod",
                table: "Grid",
                newName: "SizeCod");

            migrationBuilder.AddColumn<string>(
                name: "CollorCod",
                table: "Grid",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
