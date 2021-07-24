using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApp.Database.Migrations
{
    public partial class AddesUnderTasksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnderTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
                    MainTaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderTasks_MainTasks_MainTaskId",
                        column: x => x.MainTaskId,
                        principalTable: "MainTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnderTasks_MainTaskId",
                table: "UnderTasks",
                column: "MainTaskId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnderTasks");
        }
    }
}
