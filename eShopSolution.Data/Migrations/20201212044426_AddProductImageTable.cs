using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 8, 52, 886, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2aaa415-6d6d-4cd3-8831-b2edd12fc3a2"),
                column: "ConcurrencyStamp",
                value: "da23faab-c361-41a3-a650-526ac0345dde");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c149b2f1-b9b2-4fd1-86f1-2044ba50cba2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34db4bc3-3029-4517-b78b-2c892b157f0b", "AQAAAAEAACcQAAAAEMUUykMMx8bq9+ID8msk87O6ryuEq/0wtKurXU+JEkEm8RI5S/BFgco7pks+08Uz0w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 12, 11, 44, 25, 839, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 9, 8, 52, 886, DateTimeKind.Local).AddTicks(7184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2aaa415-6d6d-4cd3-8831-b2edd12fc3a2"),
                column: "ConcurrencyStamp",
                value: "331fe0c9-dca3-490e-a20a-b608be253898");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c149b2f1-b9b2-4fd1-86f1-2044ba50cba2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a2fd635-ecb1-42e6-b8be-cf35f2689f48", "AQAAAAEAACcQAAAAECWMDdf6erAUGbABZmga1m30vJZknJ65RYNE/apaAPdV4NViJ6e/r/QEB6DCCNflfA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 12, 9, 8, 52, 903, DateTimeKind.Local).AddTicks(888));
        }
    }
}
