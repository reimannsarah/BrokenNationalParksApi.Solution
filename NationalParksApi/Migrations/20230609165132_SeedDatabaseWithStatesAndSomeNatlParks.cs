using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParksApi.Migrations
{
    public partial class SeedDatabaseWithStatesAndSomeNatlParks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "Name" },
                values: new object[,]
                {
                    { 1, "Alabama" },
                    { 2, "Alaska" },
                    { 3, "Arizona" },
                    { 4, "Arkansas" },
                    { 5, "California" },
                    { 6, "Colorado" },
                    { 7, "Connecticut" },
                    { 8, "Delaware" },
                    { 9, "Florida" },
                    { 10, "Georgia" },
                    { 11, "Hawaii" },
                    { 12, "Idaho" },
                    { 13, "Illinois" },
                    { 14, "Indiana" },
                    { 15, "Iowa" },
                    { 16, "Kansas" },
                    { 17, "Kentucky" },
                    { 18, "Lousiana" },
                    { 19, "Maine" },
                    { 20, "Maryland" },
                    { 21, "Massachusetss" },
                    { 22, "Michigan" },
                    { 23, "Minnesota" },
                    { 24, "Mississippi" },
                    { 25, "Missouri" },
                    { 26, "Montana" },
                    { 27, "Nebraska" },
                    { 28, "Nevada" },
                    { 29, "New Hampshire" },
                    { 30, "New Jersey" },
                    { 31, "New Mexico" },
                    { 32, "New York" },
                    { 33, "North Carolina" },
                    { 34, "North Dakota" },
                    { 35, "Ohio" },
                    { 36, "Oklahoma" },
                    { 37, "Oregon" },
                    { 38, "Pennsylvania" },
                    { 39, "Rhode Island" },
                    { 40, "South Carolina" },
                    { 41, "South Dakota" },
                    { 42, "Tennessee" },
                    { 43, "Texas" },
                    { 44, "Utah" },
                    { 45, "Vermont" },
                    { 46, "Virginia" },
                    { 47, "Washington" },
                    { 48, "West Virginia" },
                    { 49, "Wisconsin" },
                    { 50, "Wyoming" }
                });

            migrationBuilder.InsertData(
                table: "NatlParks",
                columns: new[] { "NatlParkId", "Description", "Name", "StateId" },
                values: new object[,]
                {
                    { 1, "Features the tallest mountain on the Atlantic Coast of the United States.", "Acadia", 19 },
                    { 2, "Features more than 2,000 natural sanstone arches.", "Arches", 44 },
                    { 3, "Collection of buttes, pinnacles, spires, and mixed grass prairies.", "Badlands", 41 },
                    { 4, "Named for the prominent bend in the Rio Grande along the U.S. -- Mexico border.", "Big Bend", 43 },
                    { 5, "Mostly underwater park at the north end of the Florida Keys.", "Biscayne", 19 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 44);
        }
    }
}
