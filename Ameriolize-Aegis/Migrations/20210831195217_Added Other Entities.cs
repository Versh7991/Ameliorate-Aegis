using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ameriolize_Aegis.Migrations
{
    public partial class AddedOtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "LessonPlans");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "LessonPlans",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "LessonPlans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "LessonPlans",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Centres",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DoB = table.Column<DateTime>(nullable: false),
                    CentreId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parents_Centres_CentreId",
                        column: x => x.CentreId,
                        principalTable: "Centres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CentreId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programs_Centres_CentreId",
                        column: x => x.CentreId,
                        principalTable: "Centres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pupils",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DoB = table.Column<DateTime>(nullable: false),
                    ParentId = table.Column<long>(nullable: false),
                    CentreId = table.Column<long>(nullable: false),
                    TeacherId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pupils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pupils_Centres_CentreId",
                        column: x => x.CentreId,
                        principalTable: "Centres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pupils_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pupils_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pro_Centres",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    ProgramId = table.Column<long>(nullable: false),
                    CentreId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pro_Centres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pro_Centres_Centres_CentreId",
                        column: x => x.CentreId,
                        principalTable: "Centres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pro_Centres_Programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pro_Enrollments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    PupilId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pro_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pro_Enrollments_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgressReports",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PupilId = table.Column<long>(nullable: false),
                    PeriodId = table.Column<long>(nullable: false),
                    ProgramId = table.Column<long>(nullable: false),
                    TeacherId = table.Column<long>(nullable: false),
                    Mark = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgressReports_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgressReports_Programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgressReports_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgressReports_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PupilAttendance",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    PupilId = table.Column<long>(nullable: false),
                    TeacherId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PupilAttendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PupilAttendance_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PupilAttendance_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parents_CentreId",
                table: "Parents",
                column: "CentreId");

            migrationBuilder.CreateIndex(
                name: "IX_Pro_Centres_CentreId",
                table: "Pro_Centres",
                column: "CentreId");

            migrationBuilder.CreateIndex(
                name: "IX_Pro_Centres_ProgramId",
                table: "Pro_Centres",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Pro_Enrollments_PupilId",
                table: "Pro_Enrollments",
                column: "PupilId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_CentreId",
                table: "Programs",
                column: "CentreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressReports_PeriodId",
                table: "ProgressReports",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressReports_ProgramId",
                table: "ProgressReports",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressReports_PupilId",
                table: "ProgressReports",
                column: "PupilId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressReports_TeacherId",
                table: "ProgressReports",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_PupilAttendance_PupilId",
                table: "PupilAttendance",
                column: "PupilId");

            migrationBuilder.CreateIndex(
                name: "IX_PupilAttendance_TeacherId",
                table: "PupilAttendance",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Pupils_CentreId",
                table: "Pupils",
                column: "CentreId");

            migrationBuilder.CreateIndex(
                name: "IX_Pupils_ParentId",
                table: "Pupils",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pupils_TeacherId",
                table: "Pupils",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pro_Centres");

            migrationBuilder.DropTable(
                name: "Pro_Enrollments");

            migrationBuilder.DropTable(
                name: "ProgressReports");

            migrationBuilder.DropTable(
                name: "PupilAttendance");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Pupils");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Centres");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "LessonPlans");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "LessonPlans");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "LessonPlans");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "LessonPlans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
