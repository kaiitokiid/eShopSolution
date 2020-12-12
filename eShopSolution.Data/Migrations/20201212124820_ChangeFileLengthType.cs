using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2aaa415-6d6d-4cd3-8831-b2edd12fc3a2"),
                column: "ConcurrencyStamp",
                value: "96153f7b-b6d9-4f7d-a2d8-12dea73768f4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c149b2f1-b9b2-4fd1-86f1-2044ba50cba2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80493575-4788-4005-84f5-25ae502fc253", "AQAAAAEAACcQAAAAEJs43GXzCSoVWN/F1jAMl4clZq3pc+geZNNXCfP6C4O7SNY+U8oCKaHAP3LWWNbW7A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 12, 19, 48, 19, 613, DateTimeKind.Local).AddTicks(7694));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

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
        }
    }
}
