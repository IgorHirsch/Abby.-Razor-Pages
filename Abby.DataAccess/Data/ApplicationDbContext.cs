using Abby.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Abby.DataAccess.Data;
public class ApplicationDbContext : IdentityDbContext
{
    
    public DbSet<Category> Category { get; set; }

    public DbSet<FoodType> FoodType { get; set; }

    public DbSet<MenuItem> MenuItem { get; set; }

    public DbSet<ApplicationUser> ApplicationUser { get; set; }

    public DbSet<ShoppingCart> ShoppingCart { get; set; }

    public DbSet<OrderHeader> OrderHeader { get; set; }

    public DbSet<OrderDetails> OrderDetails { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var categories = new List<Category>
    {
        new() { Id = 1, Name = "Vorspeisen", DisplayOrder = 1 },
        new() { Id = 2, Name = "Hauptgerichte", DisplayOrder = 2 },
        new() { Id = 3, Name = "Desserts", DisplayOrder = 3 },
        new() { Id = 4, Name = "Getränke", DisplayOrder = 4 },
        new() { Id = 5, Name = "Vegane Speisen", DisplayOrder = 5 }
    };

        modelBuilder.Entity<Category>().HasData(categories);

        var foodTypes = new List<FoodType>
    {
        new() { Id = 1, Name = "Vegetarisch" },
        new() { Id = 2, Name = "Fleisch" },
        new() { Id = 3, Name = "Fisch" },
        new() { Id = 4, Name = "Vegan" },
        new() { Id = 5, Name = "Glutenfrei" }
    };

        modelBuilder.Entity<FoodType>().HasData(foodTypes);

        var menuItems = new List<MenuItem>
    {
        new() { Id = 1, Name = "Caesar Salad", Description = "Frischer Römersalat mit Parmesan & Croutons", Image = "https://example.com/salad.jpg", Price = 8.99, CategoryId = 1, FoodTypeId = 1 },
        new() { Id = 2, Name = "Spaghetti Carbonara", Description = "Klassische italienische Pasta mit Speck & Ei", Image = "https://example.com/carbonara.jpg", Price = 12.99, CategoryId = 2, FoodTypeId = 2 },
        new() { Id = 3, Name = "Lachsfilet", Description = "Gegrillter Lachs mit Zitronenbutter & Gemüse", Image = "https://example.com/salmon.jpg", Price = 18.50, CategoryId = 2, FoodTypeId = 3 },
        new() { Id = 4, Name = "Schokoladenkuchen", Description = "Saftiger Schokokuchen mit warmer Schokosauce", Image = "https://example.com/chocolatecake.jpg", Price = 6.99, CategoryId = 3, FoodTypeId = 1 },
        new() { Id = 5, Name = "Mango Smoothie", Description = "Frischer Smoothie mit Mango & Banane", Image = "https://example.com/mango_smoothie.jpg", Price = 4.50, CategoryId = 4, FoodTypeId = 4 },
        new() { Id = 6, Name = "Falafel Wrap", Description = "Hausgemachte Falafel mit Hummus & Gemüse", Image = "https://example.com/falafel.jpg", Price = 9.99, CategoryId = 5, FoodTypeId = 4 },
        new() { Id = 7, Name = "Steak Medium-Rare", Description = "Saftiges Steak mit Rosmarinkartoffeln", Image = "https://example.com/steak.jpg", Price = 24.99, CategoryId = 2, FoodTypeId = 2 },
        new() { Id = 8, Name = "Tiramisu", Description = "Klassisches italienisches Dessert mit Mascarpone", Image = "https://example.com/tiramisu.jpg", Price = 7.50, CategoryId = 3, FoodTypeId = 1 },
        new() { Id = 9, Name = "Linsensuppe", Description = "Wärmende Linsensuppe mit orientalischen Gewürzen", Image = "https://example.com/lentilsoup.jpg", Price = 6.99, CategoryId = 1, FoodTypeId = 5 },
        new() { Id = 10, Name = "Vegane Buddha Bowl", Description = "Gesunde Bowl mit Quinoa, Kichererbsen & Avocado", Image = "https://example.com/buddhabowl.jpg", Price = 10.99, CategoryId = 5, FoodTypeId = 4 },
        new() { Id = 11, Name = "Margherita Pizza", Description = "Klassische italienische Pizza mit Mozzarella & Basilikum", Image = "https://example.com/images/margherita_pizza.jpg", Price = 9.99, CategoryId = 2, FoodTypeId = 1 },
        new() { Id = 12, Name = "Sushi Mix", Description = "Verschiedene Sushi-Rollen mit Wasabi & Sojasauce", Image = "https://example.com/images/sushi_mix.jpg", Price = 14.99, CategoryId = 2, FoodTypeId = 3 },
        new() { Id = 13, Name = "Chicken Burger", Description = "Saftiger Hähnchenburger mit Salat & Mayo", Image = "https://example.com/images/chicken_burger.jpg", Price = 11.50, CategoryId = 2, FoodTypeId = 2 },
        new() { Id = 14, Name = "Gemüsesuppe", Description = "Leichte Suppe mit frischem Gemüse", Image = "https://example.com/images/gemuesesuppe.jpg", Price = 6.50, CategoryId = 1, FoodTypeId = 5 },
        new() { Id = 15, Name = "Erdbeer-Smoothie", Description = "Fruchtiger Smoothie mit Erdbeeren & Joghurt", Image = "https://example.com/images/erdbeer_smoothie.jpg", Price = 4.99, CategoryId = 4, FoodTypeId = 4 }
    };

        modelBuilder.Entity<MenuItem>().HasData(menuItems);

        
    }
}