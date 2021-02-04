using Microsoft.EntityFrameworkCore.Migrations;

namespace NoteShop.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Sum = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    Sum = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    StyleCover = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diaries_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notebooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    Murkup = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notebooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notebooks_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pencils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Hardness = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pencils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pencils_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<long>(type: "bigint", nullable: false),
                    Thickness = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pens_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Height", "Width" },
                values: new object[,]
                {
                    { 1, 0, 0 },
                    { 2, 0, 0 },
                    { 3, 0, 0 },
                    { 4, 0, 0 },
                    { 5, 0, 0 },
                    { 6, 0, 0 },
                    { 7, 0, 0 },
                    { 8, 0, 0 },
                    { 9, 0, 0 },
                    { 10, 0, 0 },
                    { 11, 0, 0 },
                    { 12, 0, 0 },
                    { 13, 0, 0 },
                    { 14, 0, 0 },
                    { 15, 0, 0 },
                    { 16, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CartId", "Count", "ImageId", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { 1, null, 100, 1, "Notebook Poligraphist 12", null, 1f },
                    { 2, null, 190, 2, "Notebook Poligraphist 18", null, 1.25f },
                    { 3, null, 310, 3, "Notebook Poligraphist 12", null, 1.2f },
                    { 4, null, 70, 4, "Notebook 1st September 48", null, 15f },
                    { 5, null, 80, 5, "Notebook 1st September 18", null, 2.25f },
                    { 6, null, 150, 6, "Notebook 1st September 12", null, 1.2f },
                    { 7, null, 220, 7, "Notebook Poligraphist 24", null, 3.5f },
                    { 8, null, 50, 8, "Diary Ranok", null, 35f },
                    { 9, null, 27, 9, "Diary Rozumniy", null, 50f },
                    { 10, null, 10, 10, "Diary Elite", null, 70f },
                    { 11, null, 100, 11, "Pen Pilot", null, 1f },
                    { 12, null, 70, 12, "Pen MaxWriter", null, 4f },
                    { 13, null, 40, 13, "Pen BIG", null, 5f },
                    { 14, null, 70, 14, "Pen cells 10km", null, 15f },
                    { 15, null, 170, 15, "Pencil LowMarco", null, 2f },
                    { 16, null, 200, 16, "Pencil Marco", null, 4f }
                });

            migrationBuilder.InsertData(
                table: "Diaries",
                columns: new[] { "Id", "StyleCover" },
                values: new object[,]
                {
                    { 8, 1L },
                    { 9, 0L },
                    { 10, 2L }
                });

            migrationBuilder.InsertData(
                table: "Notebooks",
                columns: new[] { "Id", "Murkup", "PageCount", "Size" },
                values: new object[,]
                {
                    { 1, 2L, 12, 1L },
                    { 2, 0L, 18, 1L },
                    { 3, 1L, 12, 1L },
                    { 4, 2L, 48, 0L },
                    { 5, 2L, 18, 1L },
                    { 6, 2L, 12, 2L },
                    { 7, 2L, 24, 0L }
                });

            migrationBuilder.InsertData(
                table: "Pencils",
                columns: new[] { "Id", "Hardness" },
                values: new object[,]
                {
                    { 15, 2L },
                    { 16, 1L }
                });

            migrationBuilder.InsertData(
                table: "Pens",
                columns: new[] { "Id", "Color", "Thickness" },
                values: new object[,]
                {
                    { 11, 0L, 0.85f },
                    { 12, 1L, 0.5f },
                    { 13, 2L, 0.75f },
                    { 14, 3L, 0.65f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartId",
                table: "Products",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageId",
                table: "Products",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diaries");

            migrationBuilder.DropTable(
                name: "Notebooks");

            migrationBuilder.DropTable(
                name: "Pencils");

            migrationBuilder.DropTable(
                name: "Pens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
