using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryOccupancy.Migrations
{
    /// <inheritdoc />
    public partial class mig_DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "ComputerTableCapacity", "ComputerTableOccupied", "LibraryName", "StudyTableCapacity", "StudyTableOccupied" },
                values: new object[] { 1, 20, 0, "Prof. Dr. Abdulkadir Karahan Kütüphanesi", 100, 80 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
