using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 9, 8, 52, 886, DateTimeKind.Local).AddTicks(7184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 8, 26, 22, 59, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("a2aaa415-6d6d-4cd3-8831-b2edd12fc3a2"), "331fe0c9-dca3-490e-a20a-b608be253898", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a2aaa415-6d6d-4cd3-8831-b2edd12fc3a2"), new Guid("c149b2f1-b9b2-4fd1-86f1-2044ba50cba2") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c149b2f1-b9b2-4fd1-86f1-2044ba50cba2"), 0, "3a2fd635-ecb1-42e6-b8be-cf35f2689f48", new DateTime(1999, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "12a1nguyenquocbao1412@gmail.com", true, "Bao", "Nguyen Quoc", false, null, "12a1nguyenquocbao1412@gmail.com", "admin", "AQAAAAEAACcQAAAAECWMDdf6erAUGbABZmga1m30vJZknJ65RYNE/apaAPdV4NViJ6e/r/QEB6DCCNflfA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 12, 9, 8, 52, 903, DateTimeKind.Local).AddTicks(888));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a2aaa415-6d6d-4cd3-8831-b2edd12fc3a2"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a2aaa415-6d6d-4cd3-8831-b2edd12fc3a2"), new Guid("c149b2f1-b9b2-4fd1-86f1-2044ba50cba2") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c149b2f1-b9b2-4fd1-86f1-2044ba50cba2"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 8, 26, 22, 59, DateTimeKind.Local).AddTicks(2552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 8, 52, 886, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 12, 8, 26, 22, 76, DateTimeKind.Local).AddTicks(2560));
        }
    }
}
