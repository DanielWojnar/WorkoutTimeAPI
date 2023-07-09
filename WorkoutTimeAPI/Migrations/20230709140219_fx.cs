using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutTimeAPI.Migrations
{
    public partial class fx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Popularity",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Popularity",
                table: "Workouts");
        }
    }
}
