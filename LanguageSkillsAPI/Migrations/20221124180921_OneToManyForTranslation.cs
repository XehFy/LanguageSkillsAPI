using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageSkillsAPI.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyForTranslation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "CardTranslations",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "language",
                table: "Cards",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateIndex(
                name: "IX_CardTranslations_CardId",
                table: "CardTranslations",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardTranslations_Cards_CardId",
                table: "CardTranslations",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardTranslations_Cards_CardId",
                table: "CardTranslations");

            migrationBuilder.DropIndex(
                name: "IX_CardTranslations_CardId",
                table: "CardTranslations");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "CardTranslations");

            migrationBuilder.DropColumn(
                name: "language",
                table: "Cards");

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
    }
}
