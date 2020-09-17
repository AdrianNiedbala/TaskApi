using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.Migrations
{
    public partial class RefactorTaskClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "taskTitle",
                table: "Tasks",
                newName: "TaskTitle");

            migrationBuilder.RenameColumn(
                name: "taskDescritpion",
                table: "Tasks",
                newName: "TaskDescritpion");

            migrationBuilder.RenameColumn(
                name: "isDone",
                table: "Tasks",
                newName: "IsDone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaskTitle",
                table: "Tasks",
                newName: "taskTitle");

            migrationBuilder.RenameColumn(
                name: "TaskDescritpion",
                table: "Tasks",
                newName: "taskDescritpion");

            migrationBuilder.RenameColumn(
                name: "IsDone",
                table: "Tasks",
                newName: "isDone");
        }
    }
}
