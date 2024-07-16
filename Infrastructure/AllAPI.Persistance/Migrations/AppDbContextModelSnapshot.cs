﻿// <auto-generated />
using System;
using AllAPI.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AllAPI.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AllAPI.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 906, DateTimeKind.Local).AddTicks(8799),
                            IsDeleted = false,
                            Name = "Tools & Home"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 906, DateTimeKind.Local).AddTicks(8838),
                            IsDeleted = false,
                            Name = "Music, Sports & Home"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 906, DateTimeKind.Local).AddTicks(8851),
                            IsDeleted = true,
                            Name = "Computers"
                        });
                });

            modelBuilder.Entity("AllAPI.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 907, DateTimeKind.Local).AddTicks(4786),
                            IsDeleted = false,
                            Name = "Elektrik",
                            ParentId = 0,
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 907, DateTimeKind.Local).AddTicks(4789),
                            IsDeleted = false,
                            Name = "Fashion",
                            ParentId = 0,
                            Priority = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 907, DateTimeKind.Local).AddTicks(4791),
                            IsDeleted = false,
                            Name = "Notebook",
                            ParentId = 1,
                            Priority = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 907, DateTimeKind.Local).AddTicks(4794),
                            IsDeleted = false,
                            Name = "Qadin",
                            ParentId = 2,
                            Priority = 1
                        });
                });

            modelBuilder.Entity("AllAPI.Domain.Entities.Details", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 910, DateTimeKind.Local).AddTicks(9139),
                            Description = "Velit eaque qui için layıkıyla.",
                            IsDeleted = false,
                            Title = "Cesurca."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 910, DateTimeKind.Local).AddTicks(9202),
                            Description = "Ullam gül mi sıla neque.",
                            IsDeleted = true,
                            Title = "Et."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 910, DateTimeKind.Local).AddTicks(9268),
                            Description = "Commodi lakin çorba iusto adipisci.",
                            IsDeleted = false,
                            Title = "Cesurca."
                        });
                });

            modelBuilder.Entity("AllAPI.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 916, DateTimeKind.Local).AddTicks(3289),
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Discount = 0.4584361401855090m,
                            IsDeleted = false,
                            Price = 231.72m,
                            Title = "Intelligent Concrete Shoes"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreateDate = new DateTime(2024, 7, 15, 21, 39, 44, 916, DateTimeKind.Local).AddTicks(3339),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Discount = 0.05727024137525870m,
                            IsDeleted = false,
                            Price = 928.36m,
                            Title = "Tasty Cotton Shoes"
                        });
                });

            modelBuilder.Entity("AllAPI.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("AllAPI.Domain.Entities.Details", b =>
                {
                    b.HasOne("AllAPI.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AllAPI.Domain.Entities.Product", b =>
                {
                    b.HasOne("AllAPI.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("AllAPI.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("AllAPI.Domain.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllAPI.Domain.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AllAPI.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");

                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("AllAPI.Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
