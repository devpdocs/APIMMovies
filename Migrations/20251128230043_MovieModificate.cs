using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIMMovies.Migrations
{
    /// <inheritdoc />
    public partial class MovieModificate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");
        }
    }
}
