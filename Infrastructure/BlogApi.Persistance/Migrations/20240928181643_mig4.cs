using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Articles");

            migrationBuilder.AlterColumn<string>(
                name: "Keyword",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Description", "Keyword", "Title" },
                values: new object[] { "Okuma adresini sunt dağılımı eos sed doloremque vitae consequuntur gördüm kapının umut autem voluptatem çünkü commodi et nihil cezbelendi otobüs umut duyulmamış sed ve nisi rem dolayı çakıl quia okuma lambadaki için lakin de kalemi olduğu explicabo sıfat masaya eos quaerat filmini ışık lakin hesap laudantium doğru çobanın modi tv de ex quasi dignissimos yaptı domates et aspernatur eius ex gidecekmiş çakıl sunt quasi doloremque cezbelendi ratione modi quam için dignissimos voluptatem numquam dışarı et batarya autem voluptatem mıknatıslı ex cezbelendi accusantium eaque numquam yazın eius doloremque ut sit in filmini gidecekmiş ex aliquam minima değerli architecto consectetur et gitti.", new DateTime(2024, 9, 28, 21, 16, 43, 161, DateTimeKind.Local).AddTicks(1438), null, null, "Incredible Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Description", "Keyword", "Title" },
                values: new object[] { "Magnam tv telefonu otobüs balıkhaneye hesap quasi non alias deleniti karşıdakine voluptatem bahar türemiş ekşili ona consequatur adresini sokaklarda ea karşıdakine salladı consequuntur quaerat batarya ea lambadaki nemo dicta dolorem aut bilgisayarı salladı perferendis nesciunt adanaya nisi quis voluptas çarpan amet otobüs yapacakmış voluptatem praesentium yapacakmış consequuntur otobüs reprehenderit koştum cezbelendi quam modi şafak şafak dolor enim adipisci çıktılar non eius düşünüyor sarmal balıkhaneye kapının et layıkıyla labore bundan quia.", new DateTime(2024, 9, 28, 21, 16, 43, 161, DateTimeKind.Local).AddTicks(1691), null, null, "Ergonomic Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 21, 16, 43, 161, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 21, 16, 43, 161, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 21, 16, 43, 161, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 21, 16, 43, 161, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 28, 21, 16, 43, 162, DateTimeKind.Local).AddTicks(8798), "Eum et tv ut voluptatum.", "Explicabo." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 28, 21, 16, 43, 162, DateTimeKind.Local).AddTicks(8835), "Nemo açılmadan bilgiyasayarı praesentium ona.", "Orta ki." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 28, 21, 16, 43, 162, DateTimeKind.Local).AddTicks(8872), "Eaque dolores sıfat gidecekmiş beğendim.", "Sit laudantium labore." });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 28, 21, 16, 43, 164, DateTimeKind.Local).AddTicks(4300), "Electronics" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 28, 21, 16, 43, 164, DateTimeKind.Local).AddTicks(4307), "Tools" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 28, 21, 16, 43, 164, DateTimeKind.Local).AddTicks(5701), "Tools, Computers & Garden" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Keyword",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Content", "CreatedDate", "Description", "Keyword", "Title" },
                values: new object[] { 1, "Doloremque sit gül okuma nostrum sequi sinema voluptate çorba totam sinema bundan velit ipsum eve anlamsız öyle açılmadan bundan iure için türemiş dolorem filmini sunt ki consequatur ama koyun exercitationem layıkıyla gülüyorum perferendis dağılımı mi çobanın iure ekşili consequatur amet nihil laboriosam inventore qui architecto sed ki mıknatıslı mıknatıslı hesap açılmadan masanın voluptatem domates magnam voluptate non inventore değirmeni kalemi nemo salladı veniam layıkıyla qui umut dolorem ve domates çobanın et balıkhaneye quam inventore dolorem düşünüyor perferendis esse sequi çobanın velit olduğu consequuntur layıkıyla ipsam praesentium molestiae eve quasi patlıcan consectetur voluptas gülüyorum beğendim vitae eve numquam duyulmamış eius perferendis.", new DateTime(2024, 9, 28, 20, 39, 5, 974, DateTimeKind.Local).AddTicks(9250), "", "", "Generic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Content", "CreatedDate", "Description", "Keyword", "Title" },
                values: new object[] { 2, "Gördüm molestiae consequuntur lambadaki sayfası consequatur dolores beatae batarya ducimus dağılımı voluptas alias un gül et cezbelendi de minima sit sıradanlıktan dolayı beatae olduğu eaque nisi aliquam tv labore sayfası rem değirmeni sit anlamsız şafak sarmal dolorem vitae magni voluptatem consequuntur consequatur adresini nostrum totam masanın sed aut doğru quia dergi ex aut deleniti quae odio un koyun nisi veniam lambadaki nostrum eve laboriosam kutusu enim gitti sinema koştum quia.", new DateTime(2024, 9, 28, 20, 39, 5, 974, DateTimeKind.Local).AddTicks(9527), "", "", "Unbranded Wooden Bike" });

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
    }
}
