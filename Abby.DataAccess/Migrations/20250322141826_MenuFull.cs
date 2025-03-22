using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Abby.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MenuFull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    FoodTypeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItem_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItem_FoodType_FoodTypeId",
                        column: x => x.FoodTypeId,
                        principalTable: "FoodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Vorspeisen" },
                    { 2, 2, "Hauptgerichte" },
                    { 3, 3, "Desserts" },
                    { 4, 4, "Getränke" },
                    { 5, 5, "Vegane Speisen" }
                });

            migrationBuilder.InsertData(
                table: "FoodType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Vegetarisch" },
                    { 2, "Fleisch" },
                    { 3, "Fisch" },
                    { 4, "Vegan" },
                    { 5, "Glutenfrei" }
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "CategoryId", "Description", "FoodTypeId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Frischer Römersalat mit Parmesan & Croutons", 1, "https://example.com/salad.jpg", "Caesar Salad", 8.9900000000000002 },
                    { 2, 2, "Klassische italienische Pasta mit Speck & Ei", 2, "https://example.com/carbonara.jpg", "Spaghetti Carbonara", 12.99 },
                    { 3, 2, "Gegrillter Lachs mit Zitronenbutter & Gemüse", 3, "https://example.com/salmon.jpg", "Lachsfilet", 18.5 },
                    { 4, 3, "Saftiger Schokokuchen mit warmer Schokosauce", 1, "https://example.com/chocolatecake.jpg", "Schokoladenkuchen", 6.9900000000000002 },
                    { 5, 4, "Frischer Smoothie mit Mango & Banane", 4, "https://example.com/mango_smoothie.jpg", "Mango Smoothie", 4.5 },
                    { 6, 5, "Hausgemachte Falafel mit Hummus & Gemüse", 4, "https://example.com/falafel.jpg", "Falafel Wrap", 9.9900000000000002 },
                    { 7, 2, "Saftiges Steak mit Rosmarinkartoffeln", 2, "https://example.com/steak.jpg", "Steak Medium-Rare", 24.989999999999998 },
                    { 8, 3, "Klassisches italienisches Dessert mit Mascarpone", 1, "https://example.com/tiramisu.jpg", "Tiramisu", 7.5 },
                    { 9, 1, "Wärmende Linsensuppe mit orientalischen Gewürzen", 5, "https://example.com/lentilsoup.jpg", "Linsensuppe", 6.9900000000000002 },
                    { 10, 5, "Gesunde Bowl mit Quinoa, Kichererbsen & Avocado", 4, "https://example.com/buddhabowl.jpg", "Vegane Buddha Bowl", 10.99 },
                    { 11, 2, "Klassische italienische Pizza mit Mozzarella & Basilikum", 1, "https://example.com/images/margherita_pizza.jpg", "Margherita Pizza", 9.9900000000000002 },
                    { 12, 2, "Verschiedene Sushi-Rollen mit Wasabi & Sojasauce", 3, "https://example.com/images/sushi_mix.jpg", "Sushi Mix", 14.99 },
                    { 13, 2, "Saftiger Hähnchenburger mit Salat & Mayo", 2, "https://example.com/images/chicken_burger.jpg", "Chicken Burger", 11.5 },
                    { 14, 1, "Leichte Suppe mit frischem Gemüse", 5, "https://example.com/images/gemuesesuppe.jpg", "Gemüsesuppe", 6.5 },
                    { 15, 4, "Fruchtiger Smoothie mit Erdbeeren & Joghurt", 4, "https://example.com/images/erdbeer_smoothie.jpg", "Erdbeer-Smoothie", 4.9900000000000002 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_CategoryId",
                table: "MenuItem",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_FoodTypeId",
                table: "MenuItem",
                column: "FoodTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "FoodType");
        }
    }
}
