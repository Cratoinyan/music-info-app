using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace musicinfoapp.Migrations
{
    /// <inheritdoc />
    public partial class updateSong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Singer",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Songs",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "BugLog",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Albums",
                newName: "CreationDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "UserPassword",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SingerId",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "ArtistsPassword",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Artists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Artists_SingerId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_SingerId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "UserPassword");

            migrationBuilder.DropColumn(
                name: "SingerId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "ArtistsPassword");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Artists");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Songs",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "BugLog",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Albums",
                newName: "ReleaseDate");

            migrationBuilder.AddColumn<string>(
                name: "Singer",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
