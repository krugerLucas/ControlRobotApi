using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlRobotApi.Migrations
{
    public partial class creatingSQLite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    stateLeftelbow = table.Column<string>(type: "TEXT", nullable: true),
                    stateLeftWrist = table.Column<string>(type: "TEXT", nullable: true),
                    stateRightelbow = table.Column<string>(type: "TEXT", nullable: true),
                    stateRightWrist = table.Column<string>(type: "TEXT", nullable: true),
                    stateHeadInclination = table.Column<string>(type: "TEXT", nullable: true),
                    stateHeadRotation = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
