using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReadCount",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "ReadCount", "Title" },
                values: new object[] { "Sit ad değerli quia quae biber karşıdakine ullam ut dergi beatae dolorem ekşili çünkü aut voluptate hesap sokaklarda sayfası architecto quia perferendis tv nemo eve batarya tv eos anlamsız molestiae ki kapının filmini mıknatıslı gül için consequuntur ducimus bilgisayarı rem orta değirmeni ex adanaya makinesi düşünüyor in praesentium un sokaklarda praesentium cezbelendi göze ex camisi yaptı eve doğru ama umut ipsam balıkhaneye rem in voluptatem beğendim koyun odit suscipit oldular nesciunt umut sed sinema duyulmamış autem aliquam aut nesciunt quae olduğu camisi hesap olduğu de dışarı yazın gazete quia et quia çorba et sevindi sinema ut et deleniti ipsum şafak.", new DateTime(2024, 10, 16, 18, 6, 20, 25, DateTimeKind.Local).AddTicks(9013), 0, "Handcrafted Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "ReadCount", "Title" },
                values: new object[] { "Açılmadan masanın eve ki beğendim ratione quaerat makinesi beatae makinesi çakıl illo aspernatur yaptı quae ekşili enim cezbelendi ut velit layıkıyla sevindi voluptatem ea voluptatem biber çünkü gülüyorum cesurca adresini ducimus nesciunt için labore quae yapacakmış rem quia yapacakmış eos masaya mutlu eius gördüm açılmadan quam ipsa gül aliquam aut et numquam çıktılar oldular ut quis layıkıyla sarmal quasi tempora sit blanditiis iusto quia minima consequatur hesap değirmeni adanaya labore.", new DateTime(2024, 10, 16, 18, 6, 20, 25, DateTimeKind.Local).AddTicks(9211), 0, "Rustic Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 18, 6, 20, 26, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 18, 6, 20, 26, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 18, 6, 20, 26, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 18, 6, 20, 26, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 16, 18, 6, 20, 27, DateTimeKind.Local).AddTicks(6469), "Çakıl yazın aut esse de.", "Minima." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 16, 18, 6, 20, 27, DateTimeKind.Local).AddTicks(6527), "İpsa layıkıyla vel gördüm dicta.", "Beatae consequuntur." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 10, 16, 18, 6, 20, 27, DateTimeKind.Local).AddTicks(6565), "Yazın bundan doloremque ama olduğu.", "Tv filmini dolores." });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 16, 18, 6, 20, 29, DateTimeKind.Local).AddTicks(5988), "Jewelery, Toys & Music" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 16, 18, 6, 20, 29, DateTimeKind.Local).AddTicks(5996), "Music" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 16, 18, 6, 20, 29, DateTimeKind.Local).AddTicks(6011), "Grocery & Beauty" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReadCount",
                table: "Articles");

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
    }
}
