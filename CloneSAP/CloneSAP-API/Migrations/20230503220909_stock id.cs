using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloneSAP_API.Migrations
{
    /// <inheritdoc />
    public partial class stockid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Grid_gridId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageUnit_Material_materialId",
                table: "StorageUnit");

            migrationBuilder.DropIndex(
                name: "IX_Material_gridId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "gridId",
                table: "Material");

            migrationBuilder.RenameColumn(
                name: "materialId",
                table: "StorageUnit",
                newName: "stockIDn");

            migrationBuilder.RenameIndex(
                name: "IX_StorageUnit_materialId",
                table: "StorageUnit",
                newName: "IX_StorageUnit_stockIDn");

            migrationBuilder.CreateTable(
                name: "StockID",
                columns: table => new
                {
                    stockIDn = table.Column<int>(type: "int", maxLength: 999999999, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    materialId1 = table.Column<int>(type: "int", nullable: false),
                    gridId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockID", x => x.stockIDn);
                    table.ForeignKey(
                        name: "FK_StockID_Grid_gridId1",
                        column: x => x.gridId1,
                        principalTable: "Grid",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockID_Material_materialId1",
                        column: x => x.materialId1,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_StockID_gridId1",
                table: "StockID",
                column: "gridId1");

            migrationBuilder.CreateIndex(
                name: "IX_StockID_materialId1",
                table: "StockID",
                column: "materialId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageUnit_StockID_stockIDn",
                table: "StorageUnit",
                column: "stockIDn",
                principalTable: "StockID",
                principalColumn: "stockIDn",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StorageUnit_StockID_stockIDn",
                table: "StorageUnit");

            migrationBuilder.DropTable(
                name: "StockID");

            migrationBuilder.RenameColumn(
                name: "stockIDn",
                table: "StorageUnit",
                newName: "materialId");

            migrationBuilder.RenameIndex(
                name: "IX_StorageUnit_stockIDn",
                table: "StorageUnit",
                newName: "IX_StorageUnit_materialId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_StorageUnit_Material_materialId",
                table: "StorageUnit",
                column: "materialId",
                principalTable: "Material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
