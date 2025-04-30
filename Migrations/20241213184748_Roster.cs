using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PokemonDraft.Migrations
{
    /// <inheritdoc />
    public partial class Roster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonStats",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    team = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    pick = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    gp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    kos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    deaths = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    plus_minus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    multi_kill = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    max_kill = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonStats", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rosters",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    team_owner = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    team_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    mega = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier_one_a = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier_one_b = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier_two_a = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier_two_b = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier_three_a = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier_three_b = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier_four_a = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier_four_b = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier_five_a = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tier_five_b = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_a = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_b = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_c = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_d = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_e = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_f = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_g = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_h = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_i = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_j = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    pick_number = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    gp = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    wins = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    losses = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    wl = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    kos = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    deaths = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    plus_minus = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    opp_plus_minus = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rosters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TradeStats",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trade_team = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_previous_team = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_tier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_pick = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_gp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_k = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_d = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_plus_minus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_multi_kill = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trade_max_kill = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeStats", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Rosters",
                columns: new[] { "id", "deaths", "gp", "kos", "losses", "mega", "opp_plus_minus", "pick_number", "plus_minus", "team_name", "team_owner", "tier_five_a", "tier_five_b", "tier_four_a", "tier_four_b", "tier_one_a", "tier_one_b", "tier_three_a", "tier_three_b", "tier_two_a", "tier_two_b", "trade_a", "trade_b", "trade_c", "trade_d", "trade_e", "trade_f", "trade_g", "trade_h", "trade_i", "trade_j", "wins", "wl" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, 0, "Sableye", 0, 0, 0, "Spiteful Sableyes", "Pyth", "Grafaiai", "Togedemaru", "Salazzle", "Tsareena", "Tornadus-T", "Clefable", "Slowking", "Tangrowth", "Zygarde-50%", "Metagross", null, null, null, null, null, null, null, null, null, null, 0, 0 },
                    { 2, 0, 0, 0, 0, "Charizard-Y", 0, 0, 0, "North Bay Nickits", "Inuktitut", "Rotom-F", "Leafeon", "Tinkaton", "Gastrodon", "Great Tusk", "Tapu Lele", "H-Zoroark", "Crobat", "Jirachi", "H-Samurott", null, null, null, null, null, null, null, null, null, null, 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonStats");

            migrationBuilder.DropTable(
                name: "Rosters");

            migrationBuilder.DropTable(
                name: "TradeStats");
        }
    }
}
