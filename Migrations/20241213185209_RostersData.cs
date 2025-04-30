using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonDraft.Migrations
{
    /// <inheritdoc />
    public partial class RostersData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rosters",
                keyColumn: "id",
                keyValue: 1,
                column: "trade_a",
                value: "Quagsire");

            migrationBuilder.UpdateData(
                table: "Rosters",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "trade_a", "trade_b", "trade_c" },
                values: new object[] { "Latias", "Zeraora", "Whimsicott" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rosters",
                keyColumn: "id",
                keyValue: 1,
                column: "trade_a",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rosters",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "trade_a", "trade_b", "trade_c" },
                values: new object[] { null, null, null });
        }
    }
}
