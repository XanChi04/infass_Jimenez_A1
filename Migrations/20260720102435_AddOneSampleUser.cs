using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infass_Jimenez_A1.Migrations
{
    /// <inheritdoc />
    public partial class AddOneSampleUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Password" },
                values: new object[] { 1, "user1@example.com", "Password1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
