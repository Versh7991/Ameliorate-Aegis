using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ameriolize_Aegis.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Centres",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "CreationTime", "Name" },
                values: new object[,]
                {
                    { 1L, "123 John Newton SW", "Newton Park", new DateTime(2021, 9, 2, 20, 27, 51, 86, DateTimeKind.Local).AddTicks(5374), "Kabega" },
                    { 2L, "237 John Newton SW", "New Brighton", new DateTime(2021, 9, 2, 20, 27, 51, 88, DateTimeKind.Local).AddTicks(9699), "Sol Futi" },
                    { 3L, "123 John Newton SW", "Newton Park", new DateTime(2021, 9, 2, 20, 27, 51, 88, DateTimeKind.Local).AddTicks(9777), "Daku" }
                });

            migrationBuilder.InsertData(
                table: "Periods",
                columns: new[] { "Id", "CreationTime", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(9456), "Term 1" },
                    { 2L, new DateTime(2021, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(838), "Term 2" },
                    { 3L, new DateTime(2021, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(877), "Term 3" },
                    { 4L, new DateTime(2021, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(879), "Term 4" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreationTime", "DoB", "FirstName", "LastName", "Qualification" },
                values: new object[] { 1L, new DateTime(2021, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(1896), new DateTime(1976, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(3567), "Margaret", "Van Hum", "Bachelor Of Education In Child Development" });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "CentreId", "CreationTime", "DoB", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(4904), new DateTime(1994, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(7104), "Jane", "Pope" },
                    { 5L, 1L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8355), new DateTime(1992, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8356), "Joshua", "Doe" },
                    { 9L, 1L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8370), new DateTime(1991, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8372), "Jongokhaya", "Khwili" },
                    { 2L, 2L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8221), new DateTime(1988, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8299), "Thembeka", "Qweba" },
                    { 4L, 2L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8350), new DateTime(1967, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8352), "Jon", "Doe" },
                    { 7L, 2L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8363), new DateTime(1996, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8364), "Amanda", "Qweba" },
                    { 3L, 3L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8344), new DateTime(1976, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8347), "Jane", "Doe" },
                    { 6L, 3L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8359), new DateTime(1972, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8360), "Thandi", "Newton" },
                    { 8L, 3L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8366), new DateTime(2000, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8368), "Amyoli", "Soze" },
                    { 10L, 3L, new DateTime(2021, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8375), new DateTime(1989, 9, 2, 20, 27, 51, 90, DateTimeKind.Local).AddTicks(8376), "Thandeka", "Khehle" }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CentreId", "CreationTime", "Description", "Name" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(3436), null, "Literacy Development" },
                    { 3L, 1L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(5593), null, "Song And Music" },
                    { 4L, 1L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(5596), null, "Art And Music" },
                    { 2L, 2L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(5540), null, "Math And Science" },
                    { 5L, 3L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(5599), null, "Language And Speech" }
                });

            migrationBuilder.InsertData(
                table: "Pupils",
                columns: new[] { "Id", "CentreId", "CreationTime", "DoB", "FirstName", "LastName", "ParentId", "TeacherId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2021, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(5685), new DateTime(2016, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(7770), "Peter", "Pope", 1L, 1L },
                    { 5L, 1L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(15), new DateTime(2015, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(17), "JJ", "Doe", 5L, 1L },
                    { 9L, 1L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(37), new DateTime(2017, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(38), "Khaya", "Khwili", 9L, 1L },
                    { 2L, 2L, new DateTime(2021, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(9780), new DateTime(2017, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(9916), "Amahle", "Qweba", 2L, 1L },
                    { 4L, 2L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(5), new DateTime(2017, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(12), "Jerry", "Doe", 4L, 1L },
                    { 7L, 2L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(27), new DateTime(2016, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(28), "Sinazo", "Qweba", 7L, 1L },
                    { 3L, 3L, new DateTime(2021, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(9962), new DateTime(2016, 9, 2, 20, 27, 51, 91, DateTimeKind.Local).AddTicks(9970), "Junior", "Doe", 3L, 1L },
                    { 6L, 3L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(20), new DateTime(2017, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(25), "Mihle", "Newton", 6L, 1L },
                    { 8L, 3L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(32), new DateTime(2015, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(34), "Buhle", "Soze", 8L, 1L },
                    { 10L, 3L, new DateTime(2021, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(42), new DateTime(2016, 9, 2, 20, 27, 51, 92, DateTimeKind.Local).AddTicks(44), "Kubeka", "Khehle", 10L, 1L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Pupils",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Centres",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Centres",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Centres",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
