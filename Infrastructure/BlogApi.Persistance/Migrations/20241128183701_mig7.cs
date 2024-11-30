using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Slug", "Title" },
                values: new object[] { "Quasi ut corporis bilgiyasayarı incidunt laboriosam dignissimos qui magni et ab çobanın göze non sandalye sinema modi yazın lambadaki ut uzattı nisi rem teldeki gül eve neque sıla patlıcan ut aperiam masanın totam beatae exercitationem consectetur ki ea dolores ona deleniti sandalye ve quae lambadaki nihil koyun sıradanlıktan eos adipisci uzattı ullam kalemi gülüyorum teldeki dolores çobanın corporis sed quia için incidunt numquam dolor dolor autem sit in ad iusto eve quae ea makinesi inventore voluptatem dignissimos şafak nisi kutusu quaerat vitae gazete molestiae değirmeni ekşili cesurca iusto ama quasi çarpan nostrum molestiae için kapının oldular nostrum oldular veritatis voluptatem.", new DateTime(2024, 11, 28, 21, 37, 1, 304, DateTimeKind.Local).AddTicks(3680), null, "Rustic Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Slug", "Title" },
                values: new object[] { "Nisi ducimus in sokaklarda voluptas nostrum magnam mıknatıslı esse sokaklarda salladı et hesap nesciunt in sıfat nemo incidunt aperiam bilgiyasayarı domates masaya ötekinden için ipsum labore voluptate umut sinema bahar orta ve non ratione göze için gazete quasi nostrum tv ab qui aut quis blanditiis voluptate gördüm dergi voluptatem ducimus mutlu dolores oldular ipsa adipisci sinema çobanın quaerat çarpan commodi qui patlıcan adipisci bilgiyasayarı çünkü vitae yaptı vel değerli quasi.", new DateTime(2024, 11, 28, 21, 37, 1, 304, DateTimeKind.Local).AddTicks(3867), null, "Refined Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 28, 21, 37, 1, 304, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 28, 21, 37, 1, 304, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 28, 21, 37, 1, 304, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 28, 21, 37, 1, 304, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 28, 21, 37, 1, 306, DateTimeKind.Local).AddTicks(287), "Corporis ex enim ex sıfat.", "Suscipit." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 28, 21, 37, 1, 306, DateTimeKind.Local).AddTicks(321), "Veniam sıla dolorem sinema teldeki.", "Explicabo quia." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 28, 21, 37, 1, 306, DateTimeKind.Local).AddTicks(356), "Göze qui commodi ekşili aliquam.", "Dergi dergi telefonu." });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 28, 21, 37, 1, 307, DateTimeKind.Local).AddTicks(5676), "Toys" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 28, 21, 37, 1, 307, DateTimeKind.Local).AddTicks(5685), "Computers" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 28, 21, 37, 1, 307, DateTimeKind.Local).AddTicks(5732), "Clothing & Movies" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Sit ad değerli quia quae biber karşıdakine ullam ut dergi beatae dolorem ekşili çünkü aut voluptate hesap sokaklarda sayfası architecto quia perferendis tv nemo eve batarya tv eos anlamsız molestiae ki kapının filmini mıknatıslı gül için consequuntur ducimus bilgisayarı rem orta değirmeni ex adanaya makinesi düşünüyor in praesentium un sokaklarda praesentium cezbelendi göze ex camisi yaptı eve doğru ama umut ipsam balıkhaneye rem in voluptatem beğendim koyun odit suscipit oldular nesciunt umut sed sinema duyulmamış autem aliquam aut nesciunt quae olduğu camisi hesap olduğu de dışarı yazın gazete quia et quia çorba et sevindi sinema ut et deleniti ipsum şafak.", new DateTime(2024, 10, 16, 18, 6, 20, 25, DateTimeKind.Local).AddTicks(9013), "Handcrafted Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Açılmadan masanın eve ki beğendim ratione quaerat makinesi beatae makinesi çakıl illo aspernatur yaptı quae ekşili enim cezbelendi ut velit layıkıyla sevindi voluptatem ea voluptatem biber çünkü gülüyorum cesurca adresini ducimus nesciunt için labore quae yapacakmış rem quia yapacakmış eos masaya mutlu eius gördüm açılmadan quam ipsa gül aliquam aut et numquam çıktılar oldular ut quis layıkıyla sarmal quasi tempora sit blanditiis iusto quia minima consequatur hesap değirmeni adanaya labore.", new DateTime(2024, 10, 16, 18, 6, 20, 25, DateTimeKind.Local).AddTicks(9211), "Rustic Concrete Chips" });

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
    }
}
