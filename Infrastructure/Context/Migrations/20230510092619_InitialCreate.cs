using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Context.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Directories_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieCategories",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategories", x => new { x.MovieId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_MovieCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCategories_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 5, 10, 12, 26, 19, 379, DateTimeKind.Local).AddTicks(3), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adventure", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 5, 10, 12, 26, 19, 379, DateTimeKind.Local).AddTicks(4), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comedy", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 5, 10, 12, 26, 19, 379, DateTimeKind.Local).AddTicks(6), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantasy", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 5, 10, 12, 26, 19, 379, DateTimeKind.Local).AddTicks(7), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horror", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2023, 5, 10, 12, 26, 19, 379, DateTimeKind.Local).AddTicks(9), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mystrey", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2023, 5, 10, 12, 26, 19, 379, DateTimeKind.Local).AddTicks(10), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romance", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Directories",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "FirstName", "LastName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1928, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9377), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stanley", "Kubrick", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1933, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9396), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roman", "Polanski", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9399), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quentin Jerome", "Tarantino", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1897, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9401), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank", "Capra", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1962, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9403), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Leo", "Fincher", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "DirectorId", "Image", "Name", "Status", "UpdatedDate", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9804), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A pragmatic U.S. Marine observes the dehumanizing effects the Vietnam War has on his fellow recruits from their brutal boot camp training to the bloody street fighting in Hue.", 1, "noimage.png", "Full Metal Jacket", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1987 },
                    { 2, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9813), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.", 1, "noimage.png", "The Shining", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1980 },
                    { 3, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9815), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II.", 2, "noimage.png", "The Pianist", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2002 },
                    { 4, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9818), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In 1894, French Captain Alfred Dreyfus is wrongfully convicted of treason and sentenced to life imprisonment at Devil's island.", 2, "noimage.png", "An Officer and A Spy", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2019 },
                    { 5, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9819), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A faded television actor and his stunt double strive to achieve fame and success in the final years of Hollywood's Golden Age in 1969 Los Angeles.", 3, "noimage.png", "Once Upon A Time In Hollywood", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2019 },
                    { 6, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9821), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "After awakening from a four-year coma, a former assassin wreaks vengeance on the team of assassins who betrayed her.", 3, "noimage.png", "Kill Bill Volume 1", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2003 },
                    { 7, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9822), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Broadway matinee idol famous for his black-face portrayals anonymously joins an amateur acting troupe and falls in love with the leading lady.", 4, "noimage.png", "The Matinee Idol", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1928 },
                    { 8, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9824), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Naive newspaper cub Clem lands a scoop when he's sent out to cover a murder. In his enthusiasm he writes that the main suspect is Jane. When she confronts Clem she convinces him to help her prove her innocence", 4, "noimage.png", "The Power of The Press", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1928 },
                    { 9, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9826), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tells the story of Benjamin Button, a man who starts aging backwards with consequences", 5, "noimage.png", "The Curios Case of Benjamin Button", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2008 },
                    { 10, new DateTime(2023, 5, 10, 12, 26, 19, 378, DateTimeKind.Local).AddTicks(9828), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "As Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, he is sued by the twins who claimed he stole their idea and by the co-founder who was later squeezed out of the business.", 5, "noimage.png", "The Social Network", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2010 }
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "CategoryId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 6, 4 },
                    { 7, 4 },
                    { 1, 5 },
                    { 5, 5 },
                    { 2, 6 },
                    { 3, 6 },
                    { 6, 6 },
                    { 2, 7 },
                    { 6, 7 },
                    { 1, 8 },
                    { 5, 8 },
                    { 4, 9 },
                    { 5, 9 },
                    { 6, 9 },
                    { 1, 10 },
                    { 3, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieCategories_CategoryId",
                table: "MovieCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies",
                column: "DirectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Directories");
        }
    }
}
