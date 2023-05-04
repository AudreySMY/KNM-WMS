using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloneSAP_API.Migrations
{
    /// <inheritdoc />
    public partial class Gridlinkedmaterial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "gridId",
                table: "Material",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Material_gridId",
                table: "Material",
                column: "gridId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Grid_gridId",
                table: "Material",
                column: "gridId",
                principalTable: "Grid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Grid_gridId",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_gridId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "gridId",
                table: "Material");
        }
    }
}
