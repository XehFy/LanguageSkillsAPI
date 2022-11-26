using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageSkillsAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLanguageToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "language",
                table: "Cards",
                newName: "Language");

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "CardTranslations",
                type: "text",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "Cards",
                type: "text",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Language",
                table: "Cards",
                newName: "language");

            migrationBuilder.AlterColumn<byte>(
                name: "Language",
                table: "CardTranslations",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<byte>(
                name: "language",
                table: "Cards",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
