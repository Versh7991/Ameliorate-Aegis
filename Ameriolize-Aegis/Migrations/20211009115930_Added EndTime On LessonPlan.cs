using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ameriolize_Aegis.Migrations
{
    public partial class AddedEndTimeOnLessonPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "LessonPlans");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "LessonPlans",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "LessonPlans",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "LessonPlans");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "LessonPlans");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "LessonPlans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
