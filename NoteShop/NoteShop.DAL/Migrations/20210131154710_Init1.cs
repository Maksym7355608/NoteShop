using Microsoft.EntityFrameworkCore.Migrations;

namespace NoteShop.DAL.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CartId", "Count", "LikesId", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 16, null, 100, null, "Notebook Poligraphist 12", 1f, 0L },
                    { 1, null, 190, null, "Notebook Poligraphist 18", 1.25f, 0L },
                    { 2, null, 220, null, "Notebook Poligraphist 24", 3.5f, 0L },
                    { 3, null, 310, null, "Notebook Poligraphist 12", 1.2f, 0L },
                    { 4, null, 70, null, "Notebook 1st September 48", 15f, 0L },
                    { 5, null, 80, null, "Notebook 1st September 18", 2.25f, 0L },
                    { 6, null, 150, null, "Notebook 1st September 12", 1.2f, 0L },
                    { 7, null, 50, null, "Diary Ranok", 35f, 1L },
                    { 8, null, 27, null, "Diary Rozumniy", 50f, 1L },
                    { 9, null, 10, null, "Diary Elite", 70f, 1L },
                    { 10, null, 100, null, "Pen Pilot", 1f, 2L },
                    { 11, null, 70, null, "Pen MaxWriter", 4f, 2L },
                    { 12, null, 40, null, "Pen BIG", 5f, 2L },
                    { 13, null, 60, null, "Pen cells 10km", 10f, 2L },
                    { 14, null, 170, null, "Pencil LowMarco", 2f, 3L },
                    { 15, null, 200, null, "Pencil Marco", 4f, 3L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
