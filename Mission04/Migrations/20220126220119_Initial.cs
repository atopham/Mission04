using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission04.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieResponse",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    rating = table.Column<string>(nullable: true),
                    edited = table.Column<bool>(nullable: false),
                    lentto = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieResponse", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "MovieResponse",
                columns: new[] { "MovieId", "category", "director", "edited", "lentto", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action/Adventure", "Kevin Reynolds", false, "", "One of the best movies ever made", "PG-13", "The Count of Monte Cristo", 2002 });

            migrationBuilder.InsertData(
                table: "MovieResponse",
                columns: new[] { "MovieId", "category", "director", "edited", "lentto", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Action/Adventure", "Michael Curtis", false, "", "One of the best movies ever made", "PG", "The Adventure of Robin Hood", 1938 });

            migrationBuilder.InsertData(
                table: "MovieResponse",
                columns: new[] { "MovieId", "category", "director", "edited", "lentto", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Sci-Fi", "Christopher Nolan", false, "", "One of the best movies ever made", "PG-13", "Inception", 2010 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieResponse");
        }
    }
}
