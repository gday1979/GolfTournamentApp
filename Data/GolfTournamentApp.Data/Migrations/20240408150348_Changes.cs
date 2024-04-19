using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfTournamentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_ApplicationUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_GolfTournamentUser_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_ApplicationUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_GolfTournamentUser_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_GolfTournamentUser_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "AspNetUserRoles",
                newName: "GolfTournamentUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_GolfTournamentUserId");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "AspNetUserLogins",
                newName: "GolfTournamentUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_ApplicationUserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_GolfTournamentUserId");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "AspNetUserClaims",
                newName: "GolfTournamentUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_ApplicationUserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_GolfTournamentUserId");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_GolfTournamentUser_GolfTournamentUserId",
                table: "AspNetUserClaims",
                column: "GolfTournamentUserId",
                principalTable: "GolfTournamentUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_GolfTournamentUser_GolfTournamentUserId",
                table: "AspNetUserLogins",
                column: "GolfTournamentUserId",
                principalTable: "GolfTournamentUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_GolfTournamentUser_GolfTournamentUserId",
                table: "AspNetUserRoles",
                column: "GolfTournamentUserId",
                principalTable: "GolfTournamentUser",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_GolfTournamentUser_GolfTournamentUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_GolfTournamentUser_GolfTournamentUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_GolfTournamentUser_GolfTournamentUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "GolfTournamentUserId",
                table: "AspNetUserRoles",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_GolfTournamentUserId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "GolfTournamentUserId",
                table: "AspNetUserLogins",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_GolfTournamentUserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "GolfTournamentUserId",
                table: "AspNetUserClaims",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_GolfTournamentUserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_ApplicationUserId",
                table: "AspNetUserClaims",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_GolfTournamentUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "GolfTournamentUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_ApplicationUserId",
                table: "AspNetUserLogins",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_GolfTournamentUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "GolfTournamentUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_GolfTournamentUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "GolfTournamentUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
