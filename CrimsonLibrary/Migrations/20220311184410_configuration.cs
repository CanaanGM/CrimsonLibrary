using Microsoft.EntityFrameworkCore.Migrations;

namespace CrimsonLibrary.Migrations
{
    public partial class configuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3341b505-aa48-43fd-b17c-d1d71ae60848");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "569b177e-98a9-4704-add7-e3b2b5af5910");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca24492c-443c-412c-8795-f335877d3c09", "fa8cc905-46b6-4b13-8ec6-e90ca10288e3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5676b88-1d8c-4829-9eb2-a52ddd2849e0", "6de2acd0-1d41-48a7-9655-a374c8179587", "Adminstrator", "ADMINSTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5676b88-1d8c-4829-9eb2-a52ddd2849e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca24492c-443c-412c-8795-f335877d3c09");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "569b177e-98a9-4704-add7-e3b2b5af5910", "cf4ac4b1-7252-4264-a68d-f72a371d2199", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3341b505-aa48-43fd-b17c-d1d71ae60848", "c0b7ad13-5e9e-4ba5-9dba-20bf784a8807", "Adminstrator", "ADMINSTRATOR" });
        }
    }
}
