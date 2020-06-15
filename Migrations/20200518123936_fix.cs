using Microsoft.EntityFrameworkCore.Migrations;

namespace RPGHelper.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Agility",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArmorClass",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Charisma",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "CharacterSheets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Condition",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Exp",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hp",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HpTemp",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Initative",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Inteligence",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "CharacterSheets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Personality",
                table: "CharacterSheets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CharacterSheets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Wisdom",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_AspNetUsers_UserId",
                table: "CharacterSheets");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSheets_UserId",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Agility",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "ArmorClass",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Charisma",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Exp",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "HpTemp",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Initative",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Inteligence",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Personality",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Wisdom",
                table: "CharacterSheets");
        }
    }
}
