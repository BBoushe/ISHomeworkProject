using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticketopia.Data.Migrations
{
    public partial class addedShoppingCarts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tickets",
                newName: "TicketId");

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.CartId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInShoppingCarts",
                columns: table => new
                {
                    TicketID = table.Column<int>(type: "int", nullable: false),
                    CartID = table.Column<int>(type: "int", nullable: false),
                    CardID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInShoppingCarts", x => new { x.CartID, x.TicketID });
                    table.ForeignKey(
                        name: "FK_ProductsInShoppingCarts_ShoppingCarts_CardID",
                        column: x => x.CardID,
                        principalTable: "ShoppingCarts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsInShoppingCarts_Tickets_TicketID",
                        column: x => x.TicketID,
                        principalTable: "Tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInShoppingCarts_CardID",
                table: "ProductsInShoppingCarts",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInShoppingCarts_TicketID",
                table: "ProductsInShoppingCarts",
                column: "TicketID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsInShoppingCarts");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Tickets",
                newName: "Id");
        }
    }
}
