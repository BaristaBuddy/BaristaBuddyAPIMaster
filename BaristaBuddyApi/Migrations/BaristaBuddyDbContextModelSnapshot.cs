﻿// <auto-generated />
using System;
using BaristaBuddyApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaristaBuddyApi.Migrations
{
    [DbContext(typeof(BaristaBuddyDbContext))]
    partial class BaristaBuddyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BaristaBuddyApi.Models.Identity.BaristaBuddyUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.Identity.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AdditionalCost")
                        .HasColumnType("money");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdditionalCost = 0m,
                            ItemId = 2,
                            OrderId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            AdditionalCost = 0m,
                            ItemId = 3,
                            OrderId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3,
                            AdditionalCost = 0m,
                            ItemId = 4,
                            OrderId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 4,
                            AdditionalCost = 0m,
                            ItemId = 4,
                            OrderId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 5,
                            AdditionalCost = 0m,
                            ItemId = 4,
                            OrderId = 4,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("StoreId");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Ingredients = "Almond Milk, Cocoa nibs, Honey, Cinnamon",
                            Name = "Brennan's Hot Chocolate",
                            Price = 3.13m,
                            StoreId = 1
                        },
                        new
                        {
                            ItemId = 2,
                            Name = "Matt's Espresso Macchiato",
                            Price = 4.17m,
                            StoreId = 1
                        },
                        new
                        {
                            ItemId = 3,
                            Name = "Sihem's Caramel Latte",
                            Price = 4.00m,
                            StoreId = 2
                        },
                        new
                        {
                            ItemId = 4,
                            Ingredients = "Enough caffiene to kill a small horse",
                            Name = "James's Triple Death",
                            Price = 6.66m,
                            StoreId = 3
                        });
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.ItemModifier", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ModifierId")
                        .HasColumnType("int");

                    b.Property<decimal>("AdditionalCost")
                        .HasColumnType("money");

                    b.HasKey("ItemId", "ModifierId");

                    b.HasIndex("ModifierId");

                    b.ToTable("itemModifier");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            ModifierId = 1,
                            AdditionalCost = 0.75m
                        },
                        new
                        {
                            ItemId = 4,
                            ModifierId = 2,
                            AdditionalCost = 1.50m
                        },
                        new
                        {
                            ItemId = 3,
                            ModifierId = 3,
                            AdditionalCost = 0.75m
                        });
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.ItemSize", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("AdditionalCost")
                        .HasColumnType("money");

                    b.HasKey("ItemId", "Size");

                    b.ToTable("ItemSize");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Size = "Dwarf",
                            AdditionalCost = 0m
                        },
                        new
                        {
                            ItemId = 1,
                            Size = "Human",
                            AdditionalCost = 0.50m
                        },
                        new
                        {
                            ItemId = 1,
                            Size = "Giant",
                            AdditionalCost = 1.00m
                        },
                        new
                        {
                            ItemId = 2,
                            Size = "Dwarf",
                            AdditionalCost = 0m
                        },
                        new
                        {
                            ItemId = 2,
                            Size = "Human",
                            AdditionalCost = 0.50m
                        },
                        new
                        {
                            ItemId = 2,
                            Size = "Giant",
                            AdditionalCost = 1.00m
                        },
                        new
                        {
                            ItemId = 3,
                            Size = "Dwarf",
                            AdditionalCost = 0m
                        },
                        new
                        {
                            ItemId = 3,
                            Size = "Human",
                            AdditionalCost = 0.50m
                        },
                        new
                        {
                            ItemId = 3,
                            Size = "Giant",
                            AdditionalCost = 1.00m
                        },
                        new
                        {
                            ItemId = 4,
                            Size = "Dwarf",
                            AdditionalCost = 0m
                        },
                        new
                        {
                            ItemId = 4,
                            Size = "Human",
                            AdditionalCost = 0.50m
                        },
                        new
                        {
                            ItemId = 4,
                            Size = "Giant",
                            AdditionalCost = 1.00m
                        });
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PickupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PickupTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderTime = new DateTime(2020, 7, 7, 21, 29, 25, 375, DateTimeKind.Utc).AddTicks(4300),
                            PickupName = "sihem",
                            PickupTime = new DateTime(2020, 7, 7, 21, 29, 25, 375, DateTimeKind.Utc).AddTicks(4751)
                        },
                        new
                        {
                            Id = 2,
                            OrderTime = new DateTime(2020, 7, 7, 21, 29, 25, 375, DateTimeKind.Utc).AddTicks(5119),
                            PickupName = "brannan",
                            PickupTime = new DateTime(2020, 7, 7, 21, 29, 25, 375, DateTimeKind.Utc).AddTicks(5127)
                        },
                        new
                        {
                            Id = 3,
                            OrderTime = new DateTime(2020, 7, 7, 21, 29, 25, 375, DateTimeKind.Utc).AddTicks(5134),
                            PickupName = "matt",
                            PickupTime = new DateTime(2020, 7, 7, 21, 29, 25, 375, DateTimeKind.Utc).AddTicks(5135)
                        },
                        new
                        {
                            Id = 4,
                            OrderTime = new DateTime(2020, 7, 7, 21, 29, 25, 375, DateTimeKind.Utc).AddTicks(5136),
                            PickupName = "james",
                            PickupTime = new DateTime(2020, 7, 7, 21, 29, 25, 375, DateTimeKind.Utc).AddTicks(5137)
                        });
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Iowa City",
                            Name = "Matt's Place",
                            State = "Iowa",
                            StreetAddress = "1918 H St.",
                            Zip = "52240"
                        },
                        new
                        {
                            Id = 2,
                            City = "Cedar Rapids",
                            Name = "Roastopia",
                            State = "Iowa",
                            StreetAddress = "1313 1st Ave.",
                            Zip = "52240"
                        },
                        new
                        {
                            Id = 3,
                            City = "Des Moines",
                            Name = "King Keith's Cafe",
                            State = "Iowa",
                            StreetAddress = "121 Dodge St.",
                            Zip = "52240"
                        });
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.StoreModifier", b =>
                {
                    b.Property<int>("ModifierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("ModifierId");

                    b.HasIndex("StoreId");

                    b.ToTable("StoreModifier");

                    b.HasData(
                        new
                        {
                            ModifierId = 1,
                            Name = "Mint",
                            StoreId = 1
                        },
                        new
                        {
                            ModifierId = 2,
                            Name = "Espresso Shot",
                            StoreId = 1
                        },
                        new
                        {
                            ModifierId = 3,
                            Name = "Caramel",
                            StoreId = 2
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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.Identity.OrderItem", b =>
                {
                    b.HasOne("BaristaBuddyApi.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaristaBuddyApi.Models.Orders", "Order")
                        .WithMany("OrderItem")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.Item", b =>
                {
                    b.HasOne("BaristaBuddyApi.Models.Store", "Store")
                        .WithMany("Items")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.ItemModifier", b =>
                {
                    b.HasOne("BaristaBuddyApi.Models.Item", "Item")
                        .WithMany("ItemModifiers")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaristaBuddyApi.Models.StoreModifier", "Modifier")
                        .WithMany()
                        .HasForeignKey("ModifierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.ItemSize", b =>
                {
                    b.HasOne("BaristaBuddyApi.Models.Item", "Item")
                        .WithMany("ItemSizes")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.Orders", b =>
                {
                    b.HasOne("BaristaBuddyApi.Models.Identity.BaristaBuddyUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BaristaBuddyApi.Models.StoreModifier", b =>
                {
                    b.HasOne("BaristaBuddyApi.Models.Store", "Store")
                        .WithMany("Modifiers")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("BaristaBuddyApi.Models.Identity.BaristaBuddyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BaristaBuddyApi.Models.Identity.BaristaBuddyUser", null)
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

                    b.HasOne("BaristaBuddyApi.Models.Identity.BaristaBuddyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BaristaBuddyApi.Models.Identity.BaristaBuddyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
