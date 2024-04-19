#nullable disable

namespace GolfTournamentApp.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    /// <inheritdoc />
    public partial class NewTableModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Newses_Tournaments_TournamentId",
                table: "Newses");

            migrationBuilder.DropTable(
                name: "CourseNewses");

            migrationBuilder.DropTable(
                name: "CourseTournament");

            migrationBuilder.DropTable(
                name: "GolfRankings");

            migrationBuilder.DropIndex(
                name: "IX_Newses_TournamentId",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "Organizer",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "Newses");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Tournaments",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Rankings",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Rankings",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Courses",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Rankings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Rankings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RankingId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CoursesPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursesPlayers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoursesPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TournamentsPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentsPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentsPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TournamentsPlayers_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_RankingId",
                table: "Players",
                column: "RankingId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesPlayers_CourseId",
                table: "CoursesPlayers",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesPlayers_PlayerId",
                table: "CoursesPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentsPlayers_PlayerId",
                table: "TournamentsPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentsPlayers_TournamentId",
                table: "TournamentsPlayers",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Rankings_RankingId",
                table: "Players",
                column: "RankingId",
                principalTable: "Rankings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Rankings_RankingId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "CoursesPlayers");

            migrationBuilder.DropTable(
                name: "TournamentsPlayers");

            migrationBuilder.DropIndex(
                name: "IX_Players_RankingId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Rankings");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Rankings");

            migrationBuilder.DropColumn(
                name: "RankingId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Tournaments",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Rankings",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Rankings",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Courses",
                newName: "Image");

            migrationBuilder.AddColumn<string>(
                name: "Organizer",
                table: "Tournaments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: " ");

            migrationBuilder.AddColumn<int>(
                name: "TournamentId",
                table: "Newses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseNewses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseNewses", x => new { x.CourseId, x.NewsId });
                    table.ForeignKey(
                        name: "FK_CourseNewses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseNewses_GolfTournamentUser_UserId",
                        column: x => x.UserId,
                        principalTable: "GolfTournamentUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CourseNewses_Newses_NewsId",
                        column: x => x.NewsId,
                        principalTable: "Newses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseTournament",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    TournamentsId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTournament", x => new { x.CoursesId, x.TournamentsId });
                    table.ForeignKey(
                        name: "FK_CourseTournament_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseTournament_Tournaments_TournamentsId",
                        column: x => x.TournamentsId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GolfRankings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    RankingId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TournamentId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfRankings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GolfRankings_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GolfRankings_Rankings_RankingId",
                        column: x => x.RankingId,
                        principalTable: "Rankings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GolfRankings_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Newses_TournamentId",
                table: "Newses",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseNewses_IsDeleted",
                table: "CourseNewses",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CourseNewses_NewsId",
                table: "CourseNewses",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseNewses_UserId",
                table: "CourseNewses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTournament_TournamentsId",
                table: "CourseTournament",
                column: "TournamentsId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfRankings_IsDeleted",
                table: "GolfRankings",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_GolfRankings_PlayerId",
                table: "GolfRankings",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfRankings_RankingId",
                table: "GolfRankings",
                column: "RankingId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfRankings_TournamentId",
                table: "GolfRankings",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Newses_Tournaments_TournamentId",
                table: "Newses",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id");
        }
    }
}
