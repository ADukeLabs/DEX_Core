using Microsoft.EntityFrameworkCore.Migrations;

namespace DEX_Core_WebAPI.Migrations
{
    public partial class CityID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_City_CityId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CityId",
                table: "Companies");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Companies",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Wellington" },
                    { 2, "Tokyo" },
                    { 3, "New York" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, null, 1, "Datacom" },
                    { 2, null, 2, "Fujitsu" },
                    { 3, null, 3, "MetLife" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "CompanyId", "EmailAddress", "Name", "PhoneNumber" },
                values: new object[] { 1, 1, "johndoe@nowhere.com", "Person 1", null });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "CompanyId", "EmailAddress", "Name", "PhoneNumber" },
                values: new object[] { 2, 1, "johndoe@nowhere.com", "Person 2", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3);

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
                name: "CityId",
                table: "Companies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityId",
                table: "Companies",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_City_CityId",
                table: "Companies",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
