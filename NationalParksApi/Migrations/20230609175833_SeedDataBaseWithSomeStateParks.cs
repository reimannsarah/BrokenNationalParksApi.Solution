using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParksApi.Migrations
{
    public partial class SeedDataBaseWithSomeStateParks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StateParks",
                columns: new[] { "StateParkId", "Description", "Name", "StateId" },
                values: new object[,]
                {
                    { 1, "300-foot redwoods, remote beaches, and waterfalls.", "Julia Pfeiffer Burns State Park", 5 },
                    { 2, "12,000 acres of mudstone and sandstone bandlnds speckled with orange-gray tent rocks.", "Makoshika State Park", 5 },
                    { 3, "Home to a vareity of wildlife, from hawks to black bears who make their home amid the park's peaceful lakes and waterfalls", "Baxter State Park", 19 },
                    { 4, "Dense rainforest canopy dominated by the Iao Needle", "Iao Valley State Park", 11 },
                    { 5, "Gets its name from the enormous, striped red rock formations that cover the area.", "Valley of Fire State Park", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 5);
        }
    }
}
