using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Media_Backend.Migrations
{
    /// <inheritdoc />
    public partial class add_seeders_new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "UserLikedMedia",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "UserLikedMedia",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Has stage 4 cancer", "Luffy" },
                    { 2, "Man is edgy", "Guts" },
                    { 3, "Delta simpt voor haar", "Penny" }
                });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "Id", "Code", "Label" },
                values: new object[,]
                {
                    { 1, "ANIME", "Anime" },
                    { 2, "GAME", "Game" },
                    { 3, "MANGA", "Manga" },
                    { 4, "MOVIE", "Movie" },
                    { 5, "TV_SHOW", "TV Show" },
                    { 6, "BOOK", "Book" },
                    { 7, "COMIC", "Comic" },
                    { 8, "MUSIC", "Music" },
                    { 9, "PODCAST", "Podcast" },
                    { 10, "WEB_SERIES", "Web Series" },
                    { 11, "OTHER", "Other" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" },
                    { 3, "Moderator" },
                    { 4, "Editor" }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Description", "Name", "ReleaseDate", "TypeId" },
                values: new object[,]
                {
                    { 1, "A story about pirates", "One Piece", new DateOnly(1999, 10, 20), 1 },
                    { 2, "A story about two gay men", "Berserk", new DateOnly(1997, 10, 26), 1 },
                    { 3, "A dating sim for a ginger", "Stardew valley", new DateOnly(2016, 2, 26), 2 },
                    { 4, "A game about highschoolers fighting shadows", "Persona 3", new DateOnly(2006, 7, 13), 2 },
                    { 5, "A game about highschoolers fighting shadows in a newer coat of paint", "Persona 3 reload", new DateOnly(2024, 2, 2), 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc), "vandekolkjake@gmail.com", 1, "Jake" },
                    { 2, new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc), "deltatheginger@gmail.com", 2, "Delta" },
                    { 3, new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Utc), "thediscordmod@gmail.com", 3, "Michmans" }
                });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "FriendId", "UserId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "MediaCharacters",
                columns: new[] { "CharacterId", "MediaId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "RelatedMedia",
                columns: new[] { "MainMediaId", "SpinoffMediaId", "RelationType" },
                values: new object[] { 4, 5, "" });

            migrationBuilder.InsertData(
                table: "UserLikedMedia",
                columns: new[] { "MediaId", "UserId", "CompletedAt", "CreatedAt", "Score", "StartedAt", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 10, new DateTimeOffset(new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Completed", new DateTimeOffset(new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 3, 2, null, new DateTimeOffset(new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 10, new DateTimeOffset(new DateTime(2016, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Playing", new DateTimeOffset(new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumns: new[] { "FriendId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumns: new[] { "FriendId", "UserId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumns: new[] { "FriendId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MediaCharacters",
                keyColumns: new[] { "CharacterId", "MediaId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MediaCharacters",
                keyColumns: new[] { "CharacterId", "MediaId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MediaCharacters",
                keyColumns: new[] { "CharacterId", "MediaId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RelatedMedia",
                keyColumns: new[] { "MainMediaId", "SpinoffMediaId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserLikedMedia",
                keyColumns: new[] { "MediaId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserLikedMedia",
                keyColumns: new[] { "MediaId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "UserLikedMedia",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserLikedMedia",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");
        }
    }
}
