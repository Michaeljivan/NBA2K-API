using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NBA2K_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeightIn = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    WingSpanIn = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Architype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CloseShot = table.Column<int>(type: "int", nullable: false),
                    DrivingLayup = table.Column<int>(type: "int", nullable: false),
                    DrivingDunk = table.Column<int>(type: "int", nullable: false),
                    StandingDunk = table.Column<int>(type: "int", nullable: false),
                    PostHook = table.Column<int>(type: "int", nullable: false),
                    MidRangeShot = table.Column<int>(type: "int", nullable: false),
                    ThreePointShot = table.Column<int>(type: "int", nullable: false),
                    FreeThrow = table.Column<int>(type: "int", nullable: false),
                    PostFade = table.Column<int>(type: "int", nullable: false),
                    PassAccuracy = table.Column<int>(type: "int", nullable: false),
                    BallHandle = table.Column<int>(type: "int", nullable: false),
                    PostControl = table.Column<int>(type: "int", nullable: false),
                    InteriorDefense = table.Column<int>(type: "int", nullable: false),
                    PerimeterDefense = table.Column<int>(type: "int", nullable: false),
                    LateralQuickness = table.Column<int>(type: "int", nullable: false),
                    Steal = table.Column<int>(type: "int", nullable: false),
                    Block = table.Column<int>(type: "int", nullable: false),
                    OffensiveRebound = table.Column<int>(type: "int", nullable: false),
                    DefensiveRebound = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Acceleration = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Vertical = table.Column<int>(type: "int", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
