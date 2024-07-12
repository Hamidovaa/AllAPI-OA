﻿// <auto-generated />
using System;
using AllAPI.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AllAPI.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240712194209_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 881, DateTimeKind.Local).AddTicks(5779),
                            IsDeleted = false,
                            Name = "Beauty, Baby & Electronics"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 881, DateTimeKind.Local).AddTicks(5800),
                            IsDeleted = false,
                            Name = "Health & Kids"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 881, DateTimeKind.Local).AddTicks(5811),
                            IsDeleted = true,
                            Name = "Tools"
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
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 882, DateTimeKind.Local).AddTicks(423),
                            IsDeleted = false,
                            Name = "Elektrik",
                            ParentId = 0,
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 882, DateTimeKind.Local).AddTicks(425),
                            IsDeleted = false,
                            Name = "Fashion",
                            ParentId = 0,
                            Priority = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 882, DateTimeKind.Local).AddTicks(428),
                            IsDeleted = false,
                            Name = "Notebook",
                            ParentId = 1,
                            Priority = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 882, DateTimeKind.Local).AddTicks(431),
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
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 885, DateTimeKind.Local).AddTicks(3841),
                            Description = "Quis karşıdakine nostrum suscipit velit.",
                            IsDeleted = false,
                            Title = "Vel."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 885, DateTimeKind.Local).AddTicks(3889),
                            Description = "Velit orta accusantium ea değirmeni.",
                            IsDeleted = true,
                            Title = "Orta."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 885, DateTimeKind.Local).AddTicks(3934),
                            Description = "Ve dolor çobanın quia oldular.",
                            IsDeleted = false,
                            Title = "Et."
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
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 888, DateTimeKind.Local).AddTicks(8208),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Discount = 0.08956610587998550m,
                            IsDeleted = false,
                            Price = 486.03m,
                            Title = "Refined Frozen Pants"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreateDate = new DateTime(2024, 7, 12, 23, 42, 8, 888, DateTimeKind.Local).AddTicks(8244),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Discount = 0.7180795257501260m,
                            IsDeleted = false,
                            Price = 112.42m,
                            Title = "Handcrafted Fresh Sausages"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
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

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("AllAPI.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllAPI.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AllAPI.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
