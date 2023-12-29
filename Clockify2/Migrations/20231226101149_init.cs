using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clockify2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    P_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    imagelocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registeredAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.P_Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    teamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teamName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.teamId);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    taskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PId = table.Column<int>(type: "int", nullable: false),
                    taskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    priority = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.taskId);
                    table.ForeignKey(
                        name: "FK_Tasks_Persons_PId",
                        column: x => x.PId,
                        principalTable: "Persons",
                        principalColumn: "P_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    JoinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PId = table.Column<int>(type: "int", nullable: false),
                    TId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.JoinId);
                    table.ForeignKey(
                        name: "FK_Members_Persons_PId",
                        column: x => x.PId,
                        principalTable: "Persons",
                        principalColumn: "P_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Members_Teams_TId",
                        column: x => x.TId,
                        principalTable: "Teams",
                        principalColumn: "teamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubTasks",
                columns: table => new
                {
                    st_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TId = table.Column<int>(type: "int", nullable: false),
                    st_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTasks", x => x.st_id);
                    table.ForeignKey(
                        name: "FK_SubTasks_Tasks_TId",
                        column: x => x.TId,
                        principalTable: "Tasks",
                        principalColumn: "taskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activitys",
                columns: table => new
                {
                    A_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stId = table.Column<int>(type: "int", nullable: false),
                    timeOfActivity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    activty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activitys", x => x.A_id);
                    table.ForeignKey(
                        name: "FK_Activitys_SubTasks_stId",
                        column: x => x.stId,
                        principalTable: "SubTasks",
                        principalColumn: "st_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activitys_stId",
                table: "Activitys",
                column: "stId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_PId",
                table: "Members",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_TId",
                table: "Members",
                column: "TId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_TId",
                table: "SubTasks",
                column: "TId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_PId",
                table: "Tasks",
                column: "PId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activitys");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "SubTasks");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
