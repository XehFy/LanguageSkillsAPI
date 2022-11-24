using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageSkillsAPI.Migrations
{
    /// <inheritdoc />
    public partial class TranslationIdForCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardTranslationId",
                table: "Cards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardTranslationId",
                table: "Cards",
                column: "CardTranslationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardTranslations_CardTranslationId",
                table: "Cards",
                column: "CardTranslationId",
                principalTable: "CardTranslations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardTranslations_CardTranslationId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_CardTranslationId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardTranslationId",
                table: "Cards");
        }
    }
}
