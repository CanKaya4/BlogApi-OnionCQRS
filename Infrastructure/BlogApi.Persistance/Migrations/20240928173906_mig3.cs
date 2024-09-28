using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Keyword",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Description", "Keyword", "Title" },
                values: new object[] { "Doloremque sit gül okuma nostrum sequi sinema voluptate çorba totam sinema bundan velit ipsum eve anlamsız öyle açılmadan bundan iure için türemiş dolorem filmini sunt ki consequatur ama koyun exercitationem layıkıyla gülüyorum perferendis dağılımı mi çobanın iure ekşili consequatur amet nihil laboriosam inventore qui architecto sed ki mıknatıslı mıknatıslı hesap açılmadan masanın voluptatem domates magnam voluptate non inventore değirmeni kalemi nemo salladı veniam layıkıyla qui umut dolorem ve domates çobanın et balıkhaneye quam inventore dolorem düşünüyor perferendis esse sequi çobanın velit olduğu consequuntur layıkıyla ipsam praesentium molestiae eve quasi patlıcan consectetur voluptas gülüyorum beğendim vitae eve numquam duyulmamış eius perferendis.", new DateTime(2024, 9, 28, 20, 39, 5, 974, DateTimeKind.Local).AddTicks(9250), "", "", "Generic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Description", "Keyword", "Title" },
                values: new object[] { "Gördüm molestiae consequuntur lambadaki sayfası consequatur dolores beatae batarya ducimus dağılımı voluptas alias un gül et cezbelendi de minima sit sıradanlıktan dolayı beatae olduğu eaque nisi aliquam tv labore sayfası rem değirmeni sit anlamsız şafak sarmal dolorem vitae magni voluptatem consequuntur consequatur adresini nostrum totam masanın sed aut doğru quia dergi ex aut deleniti quae odio un koyun nisi veniam lambadaki nostrum eve laboriosam kutusu enim gitti sinema koştum quia.", new DateTime(2024, 9, 28, 20, 39, 5, 974, DateTimeKind.Local).AddTicks(9527), "", "", "Unbranded Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 20, 39, 5, 975, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 20, 39, 5, 975, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 20, 39, 5, 975, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 20, 39, 5, 975, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 39, 5, 976, DateTimeKind.Local).AddTicks(8989), "Labore beatae blanditiis hesap quam.", "Amet." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 39, 5, 976, DateTimeKind.Local).AddTicks(9049), "Tv orta sandalye inventore mıknatıslı.", "Vitae suscipit." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 39, 5, 976, DateTimeKind.Local).AddTicks(9086), "Mutlu qui consequatur sed aut.", "Masanın gitti incidunt." });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 39, 5, 978, DateTimeKind.Local).AddTicks(9568), "Toys" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 39, 5, 978, DateTimeKind.Local).AddTicks(9625), "Shoes, Home & Books" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 28, 20, 39, 5, 978, DateTimeKind.Local).AddTicks(9641), "Garden, Clothing & Games" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Keyword",
                table: "Articles");

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
        }
    }
}
