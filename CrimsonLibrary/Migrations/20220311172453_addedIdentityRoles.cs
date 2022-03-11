using Microsoft.EntityFrameworkCore.Migrations;

namespace CrimsonLibrary.Migrations
{
    public partial class addedIdentityRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "569b177e-98a9-4704-add7-e3b2b5af5910", "cf4ac4b1-7252-4264-a68d-f72a371d2199", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3341b505-aa48-43fd-b17c-d1d71ae60848", "c0b7ad13-5e9e-4ba5-9dba-20bf784a8807", "Adminstrator", "ADMINSTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3341b505-aa48-43fd-b17c-d1d71ae60848");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "569b177e-98a9-4704-add7-e3b2b5af5910");
        }
    }
}
