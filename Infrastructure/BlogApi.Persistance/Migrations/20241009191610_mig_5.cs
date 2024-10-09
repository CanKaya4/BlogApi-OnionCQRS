using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Değerli consequuntur suscipit beğendim eos dergi odit masanın modi çobanın gördüm qui uzattı enim bilgiyasayarı et bundan deleniti sarmal eius consequuntur esse quasi ratione camisi gül consequatur cesurca qui adanaya quia sit kutusu ut iure praesentium dergi düşünüyor layıkıyla türemiş değirmeni nostrum sequi totam cezbelendi kutusu ut sed orta sed voluptatem rem ona açılmadan iusto deleniti non nihil ipsam voluptate reprehenderit aut incidunt sıla eaque teldeki de nesciunt odio makinesi accusantium inventore ut beğendim adipisci in mutlu labore için rem karşıdakine sokaklarda magni masanın cezbelendi sıfat aut adresini aliquam exercitationem aspernatur çarpan incidunt dicta dergi beatae doğru consequatur aliquid un.", new DateTime(2024, 10, 9, 22, 16, 9, 715, DateTimeKind.Local).AddTicks(7716), "Rustic Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Anlamsız ki ışık adanaya voluptatem dolorem yazın okuma ut bundan ad lakin gitti değerli ea dağılımı eos ullam ducimus dignissimos sokaklarda sokaklarda dışarı aut labore ipsa otobüs exercitationem kalemi dicta dolor fugit ut et nisi ut sit eos yaptı eius duyulmamış minima olduğu gördüm fugit layıkıyla çakıl karşıdakine qui çobanın çarpan sıradanlıktan iure qui dicta makinesi gül açılmadan ona esse bahar deleniti cezbelendi eos bilgisayarı dicta hesap voluptate odio ducimus.", new DateTime(2024, 10, 9, 22, 16, 9, 715, DateTimeKind.Local).AddTicks(7899), "Small Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 9, 22, 16, 9, 715, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 9, 22, 16, 9, 715, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 9, 22, 16, 9, 715, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 9, 22, 16, 9, 715, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 16, 9, 717, DateTimeKind.Local).AddTicks(4150), "Makinesi nemo voluptatem aliquid quaerat.", "Fugit." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 16, 9, 717, DateTimeKind.Local).AddTicks(4207), "Eos eius dolor aliquam kutusu.", "Consequuntur orta." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 16, 9, 717, DateTimeKind.Local).AddTicks(4270), "Ut voluptas voluptatem ötekinden voluptatem.", "Sinema aperiam nihil." });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 16, 9, 718, DateTimeKind.Local).AddTicks(7508), "Beauty & Industrial" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 16, 9, 718, DateTimeKind.Local).AddTicks(7515), "Toys" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 16, 9, 718, DateTimeKind.Local).AddTicks(7522), "Electronics" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Lambadaki bundan gülüyorum balıkhaneye camisi quis aut enim quaerat kulu ex sarmal architecto qui çarpan kutusu ve ex okuma odio aspernatur odio odio layıkıyla ducimus türemiş kulu vel modi ea ötekinden voluptatem sandalye dicta biber orta quia makinesi eius çünkü qui voluptas ki illo dağılımı et layıkıyla gül dolor consequatur sunt aut sed voluptatum totam otobüs için quam değerli iure et mi nostrum mi quasi blanditiis kulu beatae düşünüyor sayfası illo uzattı koştum laudantium hesap koşuyorlar qui filmini mi perferendis gitti doğru iusto autem neque umut quia teldeki aperiam laudantium mi eos perferendis ama biber ab koşuyorlar et blanditiis enim.", new DateTime(2024, 9, 29, 16, 44, 47, 938, DateTimeKind.Local).AddTicks(4085), "Handmade Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Totam et sayfası sed autem ki voluptatem olduğu modi çobanın balıkhaneye için ea nisi quis quae voluptatem voluptatem gül bahar accusantium nihil koşuyorlar voluptatem sequi ducimus kalemi blanditiis gördüm ex laboriosam gördüm düşünüyor iusto deleniti çorba non kapının aliquid ab sıradanlıktan qui sarmal iusto salladı voluptatem de ad cezbelendi doloremque nisi sequi quia et nisi iure mıknatıslı ve ut quis sit ut un quam corporis lakin illo neque ama suscipit.", new DateTime(2024, 9, 29, 16, 44, 47, 938, DateTimeKind.Local).AddTicks(4258), "Refined Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 16, 44, 47, 938, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 16, 44, 47, 938, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 16, 44, 47, 938, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 16, 44, 47, 938, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 44, 47, 940, DateTimeKind.Local).AddTicks(1096), "Sit ipsa nemo aliquam enim.", "Aperiam." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 44, 47, 940, DateTimeKind.Local).AddTicks(1135), "Sıradanlıktan aut çorba labore camisi.", "Masaya magni." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 44, 47, 940, DateTimeKind.Local).AddTicks(1170), "Consequatur düşünüyor non gördüm okuma.", "Beğendim sarmal gülüyorum." });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 44, 47, 941, DateTimeKind.Local).AddTicks(5292), "Health" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 44, 47, 941, DateTimeKind.Local).AddTicks(5297), "Garden" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 44, 47, 941, DateTimeKind.Local).AddTicks(5397), "Clothing & Automotive" });
        }
    }
}
