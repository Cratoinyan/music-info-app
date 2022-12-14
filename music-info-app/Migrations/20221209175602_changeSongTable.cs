using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace musicinfoapp.Migrations
{
    /// <inheritdoc />
    public partial class changeSongTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Artists_SingerId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_SingerId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "SingerId",
                table: "Songs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SingerId",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_SingerId",
                table: "Songs",
                column: "SingerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Artists_SingerId",
                table: "Songs",
                column: "SingerId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
