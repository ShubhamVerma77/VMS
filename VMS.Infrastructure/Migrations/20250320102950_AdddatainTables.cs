using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdddatainTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "ID", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "A stunning villa with a private beach view.", "https://villascroatia.com/storage/2020/08/modern-luxury-villa-pool-medulin-croatia-13-1.jpg", "Beachfront Villa", 6, 1200.0, 2500, null },
                    { 2, null, "A modern villa located on a scenic hillside.", "https://www.exceptionalvillas.com/public/upload/carousel/USA-Isola-Reunion-Resort-Orlando.jpg", "Luxury Hillside Villa", 8, 1500.0, 3000, null },
                    { 3, null, "A peaceful villa surrounded by lush greenery.", "https://img.jamesedition.com/listing_images/2019/11/22/15/56/26/81626a90-7b02-4a2c-b2f4-4fa897f54395/je/2000xxs.jpg", "Tropical Garden Villa", 5, 1000.0, 2200, null },
                    { 4, null, "A secluded villa with a private pool.", "https://imperiobanus.com/wp/wp-content/uploads/2018/04/1-1.jpg", "Private Pool Villa", 10, 1800.0, 3500, null },
                    { 5, null, "A cozy villa with breathtaking mountain views.", "https://wallpapercave.com/wp/wp10292952.jpg", "Mountain Retreat Villa", 7, 1300.0, 2800, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
