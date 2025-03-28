﻿// <auto-generated />
using System;
using Abby.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Abby.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250323080236_ShoppingCart")]
    partial class ShoppingCart
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Abby.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Vorspeisen"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Hauptgerichte"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Desserts"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Getränke"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Vegane Speisen"
                        });
                });

            modelBuilder.Entity("Abby.Models.FoodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Vegetarisch"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fleisch"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fisch"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Vegan"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Glutenfrei"
                        });
                });

            modelBuilder.Entity("Abby.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FoodTypeId");

                    b.ToTable("MenuItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Frischer Römersalat mit Parmesan & Croutons",
                            FoodTypeId = 1,
                            Image = "https://example.com/salad.jpg",
                            Name = "Caesar Salad",
                            Price = 8.9900000000000002
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Klassische italienische Pasta mit Speck & Ei",
                            FoodTypeId = 2,
                            Image = "https://example.com/carbonara.jpg",
                            Name = "Spaghetti Carbonara",
                            Price = 12.99
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Gegrillter Lachs mit Zitronenbutter & Gemüse",
                            FoodTypeId = 3,
                            Image = "https://example.com/salmon.jpg",
                            Name = "Lachsfilet",
                            Price = 18.5
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "Saftiger Schokokuchen mit warmer Schokosauce",
                            FoodTypeId = 1,
                            Image = "https://example.com/chocolatecake.jpg",
                            Name = "Schokoladenkuchen",
                            Price = 6.9900000000000002
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            Description = "Frischer Smoothie mit Mango & Banane",
                            FoodTypeId = 4,
                            Image = "https://example.com/mango_smoothie.jpg",
                            Name = "Mango Smoothie",
                            Price = 4.5
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 5,
                            Description = "Hausgemachte Falafel mit Hummus & Gemüse",
                            FoodTypeId = 4,
                            Image = "https://example.com/falafel.jpg",
                            Name = "Falafel Wrap",
                            Price = 9.9900000000000002
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Saftiges Steak mit Rosmarinkartoffeln",
                            FoodTypeId = 2,
                            Image = "https://example.com/steak.jpg",
                            Name = "Steak Medium-Rare",
                            Price = 24.989999999999998
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Klassisches italienisches Dessert mit Mascarpone",
                            FoodTypeId = 1,
                            Image = "https://example.com/tiramisu.jpg",
                            Name = "Tiramisu",
                            Price = 7.5
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "Wärmende Linsensuppe mit orientalischen Gewürzen",
                            FoodTypeId = 5,
                            Image = "https://example.com/lentilsoup.jpg",
                            Name = "Linsensuppe",
                            Price = 6.9900000000000002
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            Description = "Gesunde Bowl mit Quinoa, Kichererbsen & Avocado",
                            FoodTypeId = 4,
                            Image = "https://example.com/buddhabowl.jpg",
                            Name = "Vegane Buddha Bowl",
                            Price = 10.99
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "Klassische italienische Pizza mit Mozzarella & Basilikum",
                            FoodTypeId = 1,
                            Image = "https://example.com/images/margherita_pizza.jpg",
                            Name = "Margherita Pizza",
                            Price = 9.9900000000000002
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Verschiedene Sushi-Rollen mit Wasabi & Sojasauce",
                            FoodTypeId = 3,
                            Image = "https://example.com/images/sushi_mix.jpg",
                            Name = "Sushi Mix",
                            Price = 14.99
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Saftiger Hähnchenburger mit Salat & Mayo",
                            FoodTypeId = 2,
                            Image = "https://example.com/images/chicken_burger.jpg",
                            Name = "Chicken Burger",
                            Price = 11.5
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 1,
                            Description = "Leichte Suppe mit frischem Gemüse",
                            FoodTypeId = 5,
                            Image = "https://example.com/images/gemuesesuppe.jpg",
                            Name = "Gemüsesuppe",
                            Price = 6.5
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 4,
                            Description = "Fruchtiger Smoothie mit Erdbeeren & Joghurt",
                            FoodTypeId = 4,
                            Image = "https://example.com/images/erdbeer_smoothie.jpg",
                            Name = "Erdbeer-Smoothie",
                            Price = 4.9900000000000002
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Abby.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Abby.Models.MenuItem", b =>
                {
                    b.HasOne("Abby.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Abby.Models.FoodType", "FoodType")
                        .WithMany()
                        .HasForeignKey("FoodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("FoodType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
