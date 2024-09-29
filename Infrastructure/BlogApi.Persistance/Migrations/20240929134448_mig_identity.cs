using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Okuma adresini sunt dağılımı eos sed doloremque vitae consequuntur gördüm kapının umut autem voluptatem çünkü commodi et nihil cezbelendi otobüs umut duyulmamış sed ve nisi rem dolayı çakıl quia okuma lambadaki için lakin de kalemi olduğu explicabo sıfat masaya eos quaerat filmini ışık lakin hesap laudantium doğru çobanın modi tv de ex quasi dignissimos yaptı domates et aspernatur eius ex gidecekmiş çakıl sunt quasi doloremque cezbelendi ratione modi quam için dignissimos voluptatem numquam dışarı et batarya autem voluptatem mıknatıslı ex cezbelendi accusantium eaque numquam yazın eius doloremque ut sit in filmini gidecekmiş ex aliquam minima değerli architecto consectetur et gitti.", new DateTime(2024, 9, 28, 21, 16, 43, 161, DateTimeKind.Local).AddTicks(1438), "Incredible Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Title" },
                values: new object[] { "Magnam tv telefonu otobüs balıkhaneye hesap quasi non alias deleniti karşıdakine voluptatem bahar türemiş ekşili ona consequatur adresini sokaklarda ea karşıdakine salladı consequuntur quaerat batarya ea lambadaki nemo dicta dolorem aut bilgisayarı salladı perferendis nesciunt adanaya nisi quis voluptas çarpan amet otobüs yapacakmış voluptatem praesentium yapacakmış consequuntur otobüs reprehenderit koştum cezbelendi quam modi şafak şafak dolor enim adipisci çıktılar non eius düşünüyor sarmal balıkhaneye kapının et layıkıyla labore bundan quia.", new DateTime(2024, 9, 28, 21, 16, 43, 161, DateTimeKind.Local).AddTicks(1691), "Ergonomic Rubber Bike" });

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
    }
}
