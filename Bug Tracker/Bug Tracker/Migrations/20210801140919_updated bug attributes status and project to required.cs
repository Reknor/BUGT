using Microsoft.EntityFrameworkCore.Migrations;

namespace Bug_Tracker.Migrations
{
    public partial class updatedbugattributesstatusandprojecttorequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Projects_ProjectId",
                table: "Bugs");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Bugs",
                maxLength: 50,
                nullable: false,
                defaultValue: "reported",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValue: "reported");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Bugs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Projects_ProjectId",
                table: "Bugs",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Projects_ProjectId",
                table: "Bugs");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Bugs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValue: "reported",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValue: "reported");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Bugs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Projects_ProjectId",
                table: "Bugs",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
