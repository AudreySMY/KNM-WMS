using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloneSAP_API.Migrations
{
    /// <inheritdoc />
    public partial class stockid3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockID_Grid_gridId",
                table: "StockID");

            migrationBuilder.DropForeignKey(
                name: "FK_StockID_Material_materialId",
                table: "StockID");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageUnit_StockID_stockIDn",
                table: "StorageUnit");

            migrationBuilder.RenameColumn(
                name: "stockIDn",
                table: "StorageUnit",
                newName: "StockIDn");

            migrationBuilder.RenameIndex(
                name: "IX_StorageUnit_stockIDn",
                table: "StorageUnit",
                newName: "IX_StorageUnit_StockIDn");

            migrationBuilder.RenameColumn(
                name: "materialId",
                table: "StockID",
                newName: "MaterialId");

            migrationBuilder.RenameColumn(
                name: "gridId",
                table: "StockID",
                newName: "GridId");

            migrationBuilder.RenameColumn(
                name: "stockIDn",
                table: "StockID",
                newName: "StockIDn");

            migrationBuilder.RenameIndex(
                name: "IX_StockID_materialId",
                table: "StockID",
                newName: "IX_StockID_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_StockID_gridId",
                table: "StockID",
                newName: "IX_StockID_GridId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockID_Grid_GridId",
                table: "StockID",
                column: "GridId",
                principalTable: "Grid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockID_Material_MaterialId",
                table: "StockID",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StorageUnit_StockID_StockIDn",
                table: "StorageUnit",
                column: "StockIDn",
                principalTable: "StockID",
                principalColumn: "StockIDn",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockID_Grid_GridId",
                table: "StockID");

            migrationBuilder.DropForeignKey(
                name: "FK_StockID_Material_MaterialId",
                table: "StockID");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageUnit_StockID_StockIDn",
                table: "StorageUnit");

            migrationBuilder.RenameColumn(
                name: "StockIDn",
                table: "StorageUnit",
                newName: "stockIDn");

            migrationBuilder.RenameIndex(
                name: "IX_StorageUnit_StockIDn",
                table: "StorageUnit",
                newName: "IX_StorageUnit_stockIDn");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "StockID",
                newName: "materialId");

            migrationBuilder.RenameColumn(
                name: "GridId",
                table: "StockID",
                newName: "gridId");

            migrationBuilder.RenameColumn(
                name: "StockIDn",
                table: "StockID",
                newName: "stockIDn");

            migrationBuilder.RenameIndex(
                name: "IX_StockID_MaterialId",
                table: "StockID",
                newName: "IX_StockID_materialId");

            migrationBuilder.RenameIndex(
                name: "IX_StockID_GridId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_StorageUnit_StockID_stockIDn",
                table: "StorageUnit",
                column: "stockIDn",
                principalTable: "StockID",
                principalColumn: "stockIDn",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
