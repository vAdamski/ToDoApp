using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApp.Database.Migrations
{
    public partial class AddUserIdRowToMainTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MainTasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0543bfce-535d-4b21-9d78-7a110db56fc6", "62bcc31f-3900-41df-b2be-e205702a055a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0543bfce-535d-4b21-9d78-7a110db56fc6");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MainTasks");
        }
    }
}
