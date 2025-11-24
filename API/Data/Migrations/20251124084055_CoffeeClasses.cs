using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CoffeeClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coffees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CoffeeName = table.Column<string>(type: "TEXT", nullable: false),
                    CoffeeDesc = table.Column<string>(type: "TEXT", nullable: false),
                    RoastLevel = table.Column<string>(type: "TEXT", nullable: false),
                    Origin = table.Column<string>(type: "TEXT", nullable: false),
                    CaffeineLevel = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoffeeUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastLoginAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Bio = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoffeeUsers_AppUsers_Id",
                        column: x => x.Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlavorProfiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FlavorName = table.Column<string>(type: "TEXT", nullable: false),
                    FlavorCategory = table.Column<string>(type: "TEXT", nullable: false),
                    FlavorDesc = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlavorProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoffeePreferences",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    CoffeeId = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false),
                    IsLiked = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeePreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoffeePreferences_CoffeeUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "CoffeeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoffeePreferences_Coffees_CoffeeId",
                        column: x => x.CoffeeId,
                        principalTable: "Coffees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoffeeRecommendations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    CoffeeId = table.Column<string>(type: "TEXT", nullable: false),
                    Score = table.Column<decimal>(type: "TEXT", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: false),
                    WasAccepted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ViewAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeRecommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoffeeRecommendations_CoffeeUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "CoffeeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoffeeRecommendations_Coffees_CoffeeId",
                        column: x => x.CoffeeId,
                        principalTable: "Coffees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoffeeFlavorProfiles",
                columns: table => new
                {
                    CoffeeId = table.Column<string>(type: "TEXT", nullable: false),
                    FlavorProfileId = table.Column<string>(type: "TEXT", nullable: false),
                    Intensity = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeFlavorProfiles", x => new { x.CoffeeId, x.FlavorProfileId });
                    table.ForeignKey(
                        name: "FK_CoffeeFlavorProfiles_Coffees_CoffeeId",
                        column: x => x.CoffeeId,
                        principalTable: "Coffees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoffeeFlavorProfiles_FlavorProfiles_FlavorProfileId",
                        column: x => x.FlavorProfileId,
                        principalTable: "FlavorProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoffeeFlavorProfiles_FlavorProfileId",
                table: "CoffeeFlavorProfiles",
                column: "FlavorProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_CoffeePreferences_CoffeeId",
                table: "CoffeePreferences",
                column: "CoffeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CoffeePreferences_UserId",
                table: "CoffeePreferences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CoffeeRecommendations_CoffeeId",
                table: "CoffeeRecommendations",
                column: "CoffeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CoffeeRecommendations_UserId",
                table: "CoffeeRecommendations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoffeeFlavorProfiles");

            migrationBuilder.DropTable(
                name: "CoffeePreferences");

            migrationBuilder.DropTable(
                name: "CoffeeRecommendations");

            migrationBuilder.DropTable(
                name: "FlavorProfiles");

            migrationBuilder.DropTable(
                name: "CoffeeUsers");

            migrationBuilder.DropTable(
                name: "Coffees");
        }
    }
}
