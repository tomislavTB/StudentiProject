using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentiProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(maxLength: 5, nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colleges_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CollegeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divisions_Colleges_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "Colleges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DivisionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    DivisionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Executors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    CourceId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Executors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Executors_Courses_CourceId",
                        column: x => x.CourceId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Executors_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExamTime = table.Column<string>(nullable: false),
                    Evaluation = table.Column<int>(nullable: false),
                    CourceId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Croatia" },
                    { 2, "United States" },
                    { 3, "France" },
                    { 4, "England" },
                    { 5, "Netherlands" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name", "Zip" },
                values: new object[,]
                {
                    { 1, 1, "Velika Gorica", "10000" },
                    { 2, 2, "New York", "10001" },
                    { 4, 3, "Paris", "75000" },
                    { 3, 4, "London ", "56273" },
                    { 5, 5, "Amsterdam ", "1011" }
                });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Address", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, "Zagrebačka ul. 5", 1, "University of Applied Sciences Velika Gorica" },
                    { 3, "Vrbik 8", 1, "Tehničko veleučilište u Zagrebu" },
                    { 2, "1585 Massachusetts Avenue", 2, "Columbia University" },
                    { 5, "5 Rue Thomas Mann", 4, "Paris Diderot University" },
                    { 4, "Senate House Malet Street London", 3, "University of London" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Address", "CityId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Nova Cesta 5", 1, "Davor ", "Znasve" },
                    { 2, "Stara Cesta 4", 2, "Tomislav ", "Nestovisezna" },
                    { 4, "Stari Put 2", 4, "Ivan ", "Mozeibolje" },
                    { 3, "Novi Put 3", 3, "Josip ", "Neznabas" },
                    { 5, "Nova Ulica 1", 5, "Marko ", "Voliucit" }
                });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "CollegeId", "Name" },
                values: new object[] { 1, 1, "Computer System Maintenance" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "CollegeId", "Name" },
                values: new object[] { 2, 2, "Computer Science" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DivisionId", "Name" },
                values: new object[,]
                {
                    { 3, "Creating web application", 1, "Web Development" },
                    { 4, "Full internet infrastructure", 1, "Internet Infrastructure" },
                    { 1, "Full Python Course", 2, "Python Course" },
                    { 2, "Creating sql database", 2, "SQL Course" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CityId", "DivisionId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, 1, "Tomislav ", "Buhovac" },
                    { 2, 2, 2, "Marko ", "Markic" },
                    { 3, 3, 2, "Ivan ", "Ivic" },
                    { 4, 4, 2, "Josip ", "Nesto" },
                    { 5, 5, 2, "Filip ", "Novi" }
                });

            migrationBuilder.InsertData(
                table: "Executors",
                columns: new[] { "Id", "CourceId", "Description", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1, "Learning syntax", 1 },
                    { 2, 2, "Introductory lecture", 2 }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourceId", "CourseId", "Evaluation", "ExamTime", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, null, 5, "01:30H", 1 },
                    { 7, 1, null, 5, "01:15H", 1 },
                    { 9, 3, null, 5, "01:00H", 1 },
                    { 2, 2, null, 4, "01:15H", 2 },
                    { 5, 3, null, 2, "01:45H", 2 },
                    { 3, 3, null, 4, "01:30H", 3 },
                    { 6, 2, null, 4, "01:30H", 3 },
                    { 4, 4, null, 3, "01:00H", 4 },
                    { 8, 4, null, 3, "01:30H", 4 },
                    { 10, 1, null, 5, "01:45H", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Colleges_CityId",
                table: "Colleges",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DivisionId",
                table: "Courses",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_CollegeId",
                table: "Divisions",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Executors_CourceId",
                table: "Executors",
                column: "CourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Executors_TeacherId",
                table: "Executors",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_CourseId",
                table: "Grades",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CityId",
                table: "Students",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DivisionId",
                table: "Students",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CityId",
                table: "Teachers",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Executors");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Colleges");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
