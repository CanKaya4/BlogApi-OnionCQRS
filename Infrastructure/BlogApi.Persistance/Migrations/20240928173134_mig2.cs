using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategory");

            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => new { x.ArticleId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ArticleCategories_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Düşünüyor modi ea quasi aliquid masanın doğru et umut cezbelendi et beğendim explicabo explicabo ki quia iusto lambadaki et laboriosam gül filmini labore anlamsız nesciunt quia et aut aspernatur öyle ullam türemiş ipsam quae beğendim bundan qui autem nostrum ut alias layıkıyla makinesi ama sit beğendim corporis praesentium voluptatem quaerat in masaya exercitationem et orta voluptatem olduğu sed odio lakin numquam layıkıyla değirmeni göze makinesi voluptatem otobüs aliquid quis dergi esse ratione architecto ex velit lambadaki eve aut ki sit voluptate bahar exercitationem layıkıyla labore quia çorba doloremque sıradanlıktan sit çobanın rem sinema velit laudantium quia kulu sunt veniam dolores.", new DateTime(2024, 9, 28, 20, 31, 34, 287, DateTimeKind.Local).AddTicks(2093), "Refined Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Corporis öyle değirmeni gidecekmiş sıla göze mi orta ut adresini ona sevindi masanın sarmal nihil ab corporis eaque çıktılar dolayı çobanın duyulmamış çobanın yaptı anlamsız ea mi consectetur commodi tempora non exercitationem voluptatem batarya de eve gördüm rem amet ipsam voluptatem numquam consequatur düşünüyor koyun ratione beğendim dolore batarya bilgiyasayarı patlıcan explicabo nemo qui ad doğru modi kapının dolayı dolore eaque quia de cezbelendi gidecekmiş duyulmamış koyun ea ötekinden modi.", new DateTime(2024, 9, 28, 20, 31, 34, 287, DateTimeKind.Local).AddTicks(2385), "Unbranded Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 20, 31, 34, 288, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 20, 31, 34, 288, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 20, 31, 34, 288, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 20, 31, 34, 288, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 31, 34, 294, DateTimeKind.Local).AddTicks(3442), "Gazete yazın laudantium kutusu iusto.", "Quia." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 31, 34, 294, DateTimeKind.Local).AddTicks(3477), "Voluptate quia gül quae bilgisayarı.", "Qui dolayı." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 31, 34, 294, DateTimeKind.Local).AddTicks(3512), "Duyulmamış voluptatum sit in dignissimos.", "Labore ki sevindi." });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 31, 34, 296, DateTimeKind.Local).AddTicks(6912), "Home, Beauty & Health" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 31, 34, 296, DateTimeKind.Local).AddTicks(6927), "Home, Electronics & Computers" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 31, 34, 296, DateTimeKind.Local).AddTicks(6938), "Shoes & Tools" });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategories_CategoryId",
                table: "ArticleCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategories");

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

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Ama sit ad sequi tempora değerli sit aut çobanın dicta dergi labore voluptatem gitti filmini autem consequatur ducimus sayfası quaerat illo çobanın enim nisi nisi enim qui voluptatem lakin çorba açılmadan velit gördüm doğru veritatis cezbelendi sit vel sıfat architecto aut beğendim odio türemiş çakıl dışarı ekşili çarpan esse ki sandalye sit beatae dolayı corporis amet telefonu cezbelendi praesentium commodi bundan şafak tempora ötekinden eum non aut patlıcan olduğu dolorem quia dolor dignissimos dignissimos veritatis camisi qui şafak quia için ea layıkıyla sandalye cesurca cezbelendi adresini explicabo eos sed dolorem fugit kalemi un voluptatem ipsum perferendis aliquam tv blanditiis teldeki.", new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(6638), "Refined Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Vitae olduğu açılmadan bilgiyasayarı çıktılar praesentium aliquam batarya consequuntur çorba göze de sed ab sit sevindi sed quaerat biber ama quae tv adipisci dolorem quia enim ki kulu öyle in qui voluptatum göze bilgisayarı koştum totam cezbelendi ad sit aut sevindi oldular aspernatur corporis autem türemiş tempora velit ex nihil cezbelendi sit un consequatur dolor sevindi eaque quia türemiş yapacakmış velit consequuntur qui fugit aut dicta deleniti voluptas gül gidecekmiş.", new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(6829), "Small Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 15, 24, 54, 809, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 24, 54, 811, DateTimeKind.Local).AddTicks(2785), "Architecto exercitationem domates voluptate ut.", "Totam." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 24, 54, 811, DateTimeKind.Local).AddTicks(2821), "Ut qui gülüyorum bilgisayarı consequatur.", "Sıla enim." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 24, 54, 811, DateTimeKind.Local).AddTicks(2852), "Filmini için neque nostrum biber.", "Çıktılar layıkıyla ducimus." });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 24, 54, 812, DateTimeKind.Local).AddTicks(6550), "Automotive & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 24, 54, 812, DateTimeKind.Local).AddTicks(6557), "Garden" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 24, 54, 812, DateTimeKind.Local).AddTicks(6562), "Baby" });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategory_CategoriesId",
                table: "ArticleCategory",
                column: "CategoriesId");
        }
    }
}
