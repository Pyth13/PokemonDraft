using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PokemonDraft.Migrations
{
    /// <inheritdoc />
    public partial class useraccountwithpolicies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user_account",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_account", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_account_policy",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_account_id = table.Column<int>(type: "int", nullable: false),
                    user_policy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_account_policy", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "user_account",
                columns: new[] { "id", "password", "user_name" },
                values: new object[,]
                {
                    { 1, "guest1", "guest" },
                    { 2, "player1", "player" },
                    { 3, "admin1", "admin" }
                });

            migrationBuilder.InsertData(
                table: "user_account_policy",
                columns: new[] { "id", "is_enabled", "user_account_id", "user_policy" },
                values: new object[,]
                {
                    { 1, false, 1, "VIEW_PRODUCT" },
                    { 2, false, 1, "ADD_PRODUCT" },
                    { 3, false, 1, "EDIT PRODUCT" },
                    { 4, false, 1, "DELETE_PRODUCT" },
                    { 5, true, 2, "VIEW_PRODUCT" },
                    { 6, false, 2, "ADD_PRODUCT" },
                    { 7, false, 2, "EDIT PRODUCT" },
                    { 8, false, 2, "DELETE_PRODUCT" },
                    { 9, true, 3, "VIEW_PRODUCT" },
                    { 10, true, 3, "ADD_PRODUCT" },
                    { 11, true, 3, "EDIT PRODUCT" },
                    { 12, true, 3, "DELETE_PRODUCT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_account");

            migrationBuilder.DropTable(
                name: "user_account_policy");
        }
    }
}
