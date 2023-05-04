using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloneSAP_API.Migrations
{
    /// <inheritdoc />
    public partial class stockid2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockID_Grid_gridId1",
                table: "StockID");

            migrationBuilder.DropForeignKey(
                name: "FK_StockID_Material_materialId1",
                table: "StockID");

            migrationBuilder.RenameColumn(
                name: "materialId1",
                table: "StockID",
                newName: "materialId");

            migrationBuilder.RenameColumn(
                name: "gridId1",
                table: "StockID",
                newName: "gridId");

            migrationBuilder.RenameIndex(
                name: "IX_StockID_materialId1",
                table: "StockID",
                newName: "IX_StockID_materialId");

            migrationBuilder.RenameIndex(
                name: "IX_StockID_gridId1",
                table: "StockID",
                newName: "IX_StockID_gridId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockID_Grid_gridId",
                table: "StockID",
                column: "gridId",
                principalTable: "Grid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockID_Material_materialId",
                table: "StockID",
                column: "materialId",
                principalTable: "Material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockID_Grid_gridId",
                table: "StockID");

            migrationBuilder.DropForeignKey(
                name: "FK_StockID_Material_materialId",
                table: "StockID");

            migrationBuilder.RenameColumn(
                name: "materialId",
                table: "StockID",
                newName: "materialId1");

            migrationBuilder.RenameColumn(
                name: "gridId",
                table: "StockID",
                newName: "gridId1");

            migrationBuilder.RenameIndex(
                name: "IX_StockID_materialId",
                table: "StockID",
                newName: "IX_StockID_materialId1");

            migrationBuilder.RenameIndex(
                name: "IX_StockID_gridId",
                table: "StockID",
                newName: "IX_StockID_gridId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StockID_Grid_gridId1",
                table: "StockID",
                column: "gridId1",
                principalTable: "Grid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockID_Material_materialId1",
                table: "StockID",
                column: "materialId1",
                principalTable: "Material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
