using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class AddedSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lyrics",
                table: "Songs",
                newName: "Performer");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "Performer", "SongName" },
                values: new object[,]
                {
                    { 1, 1, "Auliʻi Cravalho", "How Far I'll Go" },
                    { 2, 1, "Dwyane The Rock Johnson", "You're Welcome" },
                    { 3, 2, "Kenny Loggins", "Danger Zone" },
                    { 4, 2, "The Righteous Brothers ", "You've Lost That Lovin' Feeling" },
                    { 5, 3, "Thutmose", "Memories" },
                    { 6, 3, "Amine", "Invincible" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6);

            migrationBuilder.RenameColumn(
                name: "Performer",
                table: "Songs",
                newName: "Lyrics");
        }
    }
}
