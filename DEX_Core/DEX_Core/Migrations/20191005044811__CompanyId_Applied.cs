using Microsoft.EntityFrameworkCore.Migrations;

namespace DEX_Core_WebAPI.Migrations
{
    public partial class _CompanyId_Applied : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Companies_CompanyId",
                table: "Contact");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "City", "Name" },
                values: new object[] { 1, null, "Wellington", "Datacom" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "City", "Name" },
                values: new object[] { 2, null, "Tokyo", "Fujitsu" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "City", "Name" },
                values: new object[] { 3, null, "New York", "MetLife" });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "CompanyId", "EmailAddress", "Name", "PhoneNumber" },
                values: new object[] { 1, 1, "johndoe@nowhere.com", "Person 1", null });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "CompanyId", "EmailAddress", "Name", "PhoneNumber" },
                values: new object[] { 2, 1, "johndoe@nowhere.com", "Person 2", null });

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Companies_CompanyId",
                table: "Contact",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Companies_CompanyId",
                table: "Contact");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Contact",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Companies_CompanyId",
                table: "Contact",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
