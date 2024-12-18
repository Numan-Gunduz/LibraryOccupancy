using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryOccupancy.Migrations
{
    /// <inheritdoc />
    public partial class mig_init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibraryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudyTableCapacity = table.Column<int>(type: "int", nullable: false),
                    StudyTableOccupied = table.Column<int>(type: "int", nullable: false),
                    ComputerTableCapacity = table.Column<int>(type: "int", nullable: false),
                    ComputerTableOccupied = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
