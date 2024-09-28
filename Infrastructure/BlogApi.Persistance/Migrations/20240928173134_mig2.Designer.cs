﻿// <auto-generated />
using System;
using BlogApi.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogApi.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240928173134_mig2")]
    partial class mig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogApi.Domain.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Content = "Düşünüyor modi ea quasi aliquid masanın doğru et umut cezbelendi et beğendim explicabo explicabo ki quia iusto lambadaki et laboriosam gül filmini labore anlamsız nesciunt quia et aut aspernatur öyle ullam türemiş ipsam quae beğendim bundan qui autem nostrum ut alias layıkıyla makinesi ama sit beğendim corporis praesentium voluptatem quaerat in masaya exercitationem et orta voluptatem olduğu sed odio lakin numquam layıkıyla değirmeni göze makinesi voluptatem otobüs aliquid quis dergi esse ratione architecto ex velit lambadaki eve aut ki sit voluptate bahar exercitationem layıkıyla labore quia çorba doloremque sıradanlıktan sit çobanın rem sinema velit laudantium quia kulu sunt veniam dolores.",
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 287, DateTimeKind.Local).AddTicks(2093),
                            IsDeleted = false,
                            TagId = 1,
                            Title = "Refined Wooden Soap"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Content = "Corporis öyle değirmeni gidecekmiş sıla göze mi orta ut adresini ona sevindi masanın sarmal nihil ab corporis eaque çıktılar dolayı çobanın duyulmamış çobanın yaptı anlamsız ea mi consectetur commodi tempora non exercitationem voluptatem batarya de eve gördüm rem amet ipsam voluptatem numquam consequatur düşünüyor koyun ratione beğendim dolore batarya bilgiyasayarı patlıcan explicabo nemo qui ad doğru modi kapının dolayı dolore eaque quia de cezbelendi gidecekmiş duyulmamış koyun ea ötekinden modi.",
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 287, DateTimeKind.Local).AddTicks(2385),
                            IsDeleted = false,
                            TagId = 2,
                            Title = "Unbranded Granite Keyboard"
                        });
                });

            modelBuilder.Entity("BlogApi.Domain.Entities.ArticleCategory", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ArticleCategories");
                });

            modelBuilder.Entity("BlogApi.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "ASP.NET CORE",
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 288, DateTimeKind.Local).AddTicks(1311),
                            IsDeleted = false,
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "C#",
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 288, DateTimeKind.Local).AddTicks(1313),
                            IsDeleted = false,
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "ASP.NET CORE 2.0",
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 288, DateTimeKind.Local).AddTicks(1316),
                            IsDeleted = false,
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "C# 6.0",
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 288, DateTimeKind.Local).AddTicks(1318),
                            IsDeleted = false,
                            ParentId = 2,
                            Priorty = 1
                        });
                });

            modelBuilder.Entity("BlogApi.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
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
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 294, DateTimeKind.Local).AddTicks(3442),
                            Description = "Gazete yazın laudantium kutusu iusto.",
                            IsDeleted = false,
                            Title = "Quia."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 294, DateTimeKind.Local).AddTicks(3477),
                            Description = "Voluptate quia gül quae bilgisayarı.",
                            IsDeleted = true,
                            Title = "Qui dolayı."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 294, DateTimeKind.Local).AddTicks(3512),
                            Description = "Duyulmamış voluptatum sit in dignissimos.",
                            IsDeleted = false,
                            Title = "Labore ki sevindi."
                        });
                });

            modelBuilder.Entity("BlogApi.Domain.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 296, DateTimeKind.Local).AddTicks(6912),
                            IsDeleted = false,
                            Name = "Home, Beauty & Health"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 296, DateTimeKind.Local).AddTicks(6927),
                            IsDeleted = false,
                            Name = "Home, Electronics & Computers"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 9, 28, 20, 31, 34, 296, DateTimeKind.Local).AddTicks(6938),
                            IsDeleted = true,
                            Name = "Shoes & Tools"
                        });
                });

            modelBuilder.Entity("BlogApi.Domain.Entities.Article", b =>
                {
                    b.HasOne("BlogApi.Domain.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("BlogApi.Domain.Entities.ArticleCategory", b =>
                {
                    b.HasOne("BlogApi.Domain.Entities.Article", "Article")
                        .WithMany("ArticleCategories")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogApi.Domain.Entities.Category", "Category")
                        .WithMany("ArticleCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlogApi.Domain.Entities.Detail", b =>
                {
                    b.HasOne("BlogApi.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlogApi.Domain.Entities.Article", b =>
                {
                    b.Navigation("ArticleCategories");
                });

            modelBuilder.Entity("BlogApi.Domain.Entities.Category", b =>
                {
                    b.Navigation("ArticleCategories");

                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
