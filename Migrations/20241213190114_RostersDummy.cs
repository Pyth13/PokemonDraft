using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PokemonDraft.Migrations
{
    /// <inheritdoc />
    public partial class RostersDummy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rosters",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rosters",
                keyColumn: "id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rosters",
                columns: new[] { "id", "deaths", "gp", "kos", "losses", "mega", "opp_plus_minus", "pick_number", "plus_minus", "team_name", "team_owner", "tier_five_a", "tier_five_b", "tier_four_a", "tier_four_b", "tier_one_a", "tier_one_b", "tier_three_a", "tier_three_b", "tier_two_a", "tier_two_b", "trade_a", "trade_b", "trade_c", "trade_d", "trade_e", "trade_f", "trade_g", "trade_h", "trade_i", "trade_j", "wins", "wl" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, 0, "Sableye", 0, 0, 0, "Spiteful Sableyes", "Pyth", "Grafaiai", "Togedemaru", "Salazzle", "Tsareena", "Tornadus-T", "Clefable", "Slowking", "Tangrowth", "Zygarde-50%", "Metagross", "Quagsire", null, null, null, null, null, null, null, null, null, 0, 0 },
                    { 2, 0, 0, 0, 0, "Charizard-Y", 0, 0, 0, "North Bay Nickits", "Inuktitut", "Rotom-F", "Leafeon", "Tinkaton", "Gastrodon", "Great Tusk", "Tapu Lele", "H-Zoroark", "Crobat", "Jirachi", "H-Samurott", "Latias", "Zeraora", "Whimsicott", null, null, null, null, null, null, null, 0, 0 }
                });
        }
    }
}
