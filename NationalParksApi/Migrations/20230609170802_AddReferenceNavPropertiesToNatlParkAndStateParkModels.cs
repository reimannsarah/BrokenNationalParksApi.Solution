using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParksApi.Migrations
{
    public partial class AddReferenceNavPropertiesToNatlParkAndStateParkModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StateParks_States_StateId1",
                table: "StateParks");

            migrationBuilder.DropIndex(
                name: "IX_StateParks_StateId1",
                table: "StateParks");

            migrationBuilder.DropColumn(
                name: "StateId1",
                table: "StateParks");

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "StateParks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StateParks_StateId",
                table: "StateParks",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_StateParks_States_StateId",
                table: "StateParks",
                column: "StateId",
                principalTable: "States",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StateParks_States_StateId",
                table: "StateParks");

            migrationBuilder.DropIndex(
                name: "IX_StateParks_StateId",
                table: "StateParks");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "StateParks");

            migrationBuilder.AddColumn<int>(
                name: "StateId1",
                table: "StateParks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StateParks_StateId1",
                table: "StateParks",
                column: "StateId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StateParks_States_StateId1",
                table: "StateParks",
                column: "StateId1",
                principalTable: "States",
                principalColumn: "StateId");
        }
    }
}
