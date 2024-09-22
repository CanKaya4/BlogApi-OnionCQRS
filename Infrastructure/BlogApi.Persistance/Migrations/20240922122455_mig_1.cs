using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Priorty = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategory",
                columns: table => new
                {
                    ArticlesId = table.Column<int>(type: "int", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategory", x => new { x.ArticlesId, x.CategoriesId });
                    table.ForeignKey(
                        name: "FK_ArticleCategory_Articles_ArticlesId",
                        column: x => x.ArticlesId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleCategory_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "IsDeleted", "ParentId", "Priorty" },
                values: new object[,]
                {
                    { 1, "ASP.NET CORE", new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(8286), false, 0, 1 },
                    { 2, "C#", new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(8288), false, 0, 2 },
                    { 3, "ASP.NET CORE 2.0", new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(8289), false, 1, 1 },
                    { 4, "C# 6.0", new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(8291), false, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 22, 15, 24, 54, 812, DateTimeKind.Local).AddTicks(6550), false, "Automotive & Outdoors" },
                    { 2, new DateTime(2024, 9, 22, 15, 24, 54, 812, DateTimeKind.Local).AddTicks(6557), false, "Garden" },
                    { 3, new DateTime(2024, 9, 22, 15, 24, 54, 812, DateTimeKind.Local).AddTicks(6562), true, "Baby" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "IsDeleted", "TagId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Ama sit ad sequi tempora değerli sit aut çobanın dicta dergi labore voluptatem gitti filmini autem consequatur ducimus sayfası quaerat illo çobanın enim nisi nisi enim qui voluptatem lakin çorba açılmadan velit gördüm doğru veritatis cezbelendi sit vel sıfat architecto aut beğendim odio türemiş çakıl dışarı ekşili çarpan esse ki sandalye sit beatae dolayı corporis amet telefonu cezbelendi praesentium commodi bundan şafak tempora ötekinden eum non aut patlıcan olduğu dolorem quia dolor dignissimos dignissimos veritatis camisi qui şafak quia için ea layıkıyla sandalye cesurca cezbelendi adresini explicabo eos sed dolorem fugit kalemi un voluptatem ipsum perferendis aliquam tv blanditiis teldeki.", new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(6638), false, 1, "Refined Plastic Shirt" },
                    { 2, 2, "Vitae olduğu açılmadan bilgiyasayarı çıktılar praesentium aliquam batarya consequuntur çorba göze de sed ab sit sevindi sed quaerat biber ama quae tv adipisci dolorem quia enim ki kulu öyle in qui voluptatum göze bilgisayarı koştum totam cezbelendi ad sit aut sevindi oldular aspernatur corporis autem türemiş tempora velit ex nihil cezbelendi sit un consequatur dolor sevindi eaque quia türemiş yapacakmış velit consequuntur qui fugit aut dicta deleniti voluptas gül gidecekmiş.", new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(6829), false, 2, "Small Frozen Sausages" }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 22, 15, 24, 54, 811, DateTimeKind.Local).AddTicks(2785), "Architecto exercitationem domates voluptate ut.", false, "Totam." },
                    { 2, 3, new DateTime(2024, 9, 22, 15, 24, 54, 811, DateTimeKind.Local).AddTicks(2821), "Ut qui gülüyorum bilgisayarı consequatur.", true, "Sıla enim." },
                    { 3, 4, new DateTime(2024, 9, 22, 15, 24, 54, 811, DateTimeKind.Local).AddTicks(2852), "Filmini için neque nostrum biber.", false, "Çıktılar layıkıyla ducimus." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategory_CategoriesId",
                table: "ArticleCategory",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_TagId",
                table: "Articles",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategory");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
