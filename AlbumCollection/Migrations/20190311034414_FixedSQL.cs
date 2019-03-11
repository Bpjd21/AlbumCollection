using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class FixedSQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Songs_SongId1",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_SongId1",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "SongId1",
                table: "Songs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SongId1",
                table: "Songs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_SongId1",
                table: "Songs",
                column: "SongId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Songs_SongId1",
                table: "Songs",
                column: "SongId1",
                principalTable: "Songs",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
