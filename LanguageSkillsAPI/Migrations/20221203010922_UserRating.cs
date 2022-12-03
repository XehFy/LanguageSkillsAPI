using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageSkillsAPI.Migrations
{
    /// <inheritdoc />
    public partial class UserRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Cards",
                newName: "IsVerified");

            migrationBuilder.AddColumn<int>(
                name: "UserRating",
                table: "Cards",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRating",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "IsVerified",
                table: "Cards",
                newName: "IsActive");
        }
    }
}
