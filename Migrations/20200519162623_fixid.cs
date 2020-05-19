using Microsoft.EntityFrameworkCore.Migrations;

namespace RPGHelper.Migrations
{
    public partial class fixid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_AspNetUsers_UserId",
                table: "CharacterSheets");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSheets_UserId",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CharacterSheets");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "CharacterSheets",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_ApplicationUserId",
                table: "CharacterSheets",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSheets_AspNetUsers_ApplicationUserId",
                table: "CharacterSheets",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_AspNetUsers_ApplicationUserId",
                table: "CharacterSheets");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSheets_ApplicationUserId",
                table: "CharacterSheets");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "CharacterSheets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CharacterSheets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_UserId",
                table: "CharacterSheets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSheets_AspNetUsers_UserId",
                table: "CharacterSheets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
