using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirBnb.DAL.Migrations
{
    /// <inheritdoc />
    public partial class radwaaddsomedatainproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rules_Properties_PropertyId",
                table: "Rules");

            migrationBuilder.DropIndex(
                name: "IX_Rules_PropertyId",
                table: "Rules");

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "CheckIn",
                table: "Properties",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "CheckOut",
                table: "Properties",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "DisplayedImage",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfGuest",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Pets",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TakePhotos",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5177), new DateTime(2024, 6, 12, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 8, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5183), new DateTime(2024, 6, 13, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 6, 14, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5192), new DateTime(2024, 6, 15, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 11, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5196), new DateTime(2024, 6, 16, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 12, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5201), new DateTime(2024, 6, 17, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5205), new DateTime(2024, 6, 18, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 14, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5210), new DateTime(2024, 6, 19, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5215), new DateTime(2024, 6, 20, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 16, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5219), new DateTime(2024, 6, 21, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 17, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5223), new DateTime(2024, 6, 22, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5228), new DateTime(2024, 6, 23, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 19, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5232), new DateTime(2024, 6, 24, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5237), new DateTime(2024, 6, 25, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 21, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 6, 26, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 22, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5245), new DateTime(2024, 6, 27, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5250), new DateTime(2024, 6, 28, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 6, 29, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 25, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5258), new DateTime(2024, 6, 30, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 26, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5265), new DateTime(2024, 7, 1, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(4993), new DateTime(2024, 6, 12, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5372), new DateTime(2024, 6, 12, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 8, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 6, 13, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5382), new DateTime(2024, 6, 14, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5387), new DateTime(2024, 6, 15, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 11, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5392), new DateTime(2024, 6, 16, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 12, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5397), new DateTime(2024, 6, 17, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5402), new DateTime(2024, 6, 18, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 14, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5407), new DateTime(2024, 6, 19, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5412), new DateTime(2024, 6, 20, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 16, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5417), new DateTime(2024, 6, 21, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 17, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5422), new DateTime(2024, 6, 22, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5427), new DateTime(2024, 6, 23, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 19, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5432), new DateTime(2024, 6, 24, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5437), new DateTime(2024, 6, 25, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 21, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5442), new DateTime(2024, 6, 26, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 22, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5447), new DateTime(2024, 6, 27, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5451), new DateTime(2024, 6, 28, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5456), new DateTime(2024, 6, 29, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 25, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5461), new DateTime(2024, 6, 30, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 26, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 7, 1, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5365), new DateTime(2024, 6, 12, 17, 32, 0, 275, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckIn", "CheckOut", "DisplayedImage", "NumberOfGuest", "Pets", "TakePhotos" },
                values: new object[] { new TimeOnly(0, 0, 0), new TimeOnly(0, 0, 0), null, 0, false, false });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "PropertyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "PropertyId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PropertyId",
                table: "Reviews",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Properties_PropertyId",
                table: "Reviews",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Properties_PropertyId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_PropertyId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CheckIn",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "CheckOut",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "DisplayedImage",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "NumberOfGuest",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Pets",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "TakePhotos",
                table: "Properties");

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 6, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8782), new DateTime(2024, 6, 11, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 7, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8789), new DateTime(2024, 6, 12, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 8, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8795), new DateTime(2024, 6, 13, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8801), new DateTime(2024, 6, 14, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 10, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8807), new DateTime(2024, 6, 15, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 11, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8813), new DateTime(2024, 6, 16, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 12, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8819), new DateTime(2024, 6, 17, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8826), new DateTime(2024, 6, 18, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 14, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8832), new DateTime(2024, 6, 19, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 15, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8838), new DateTime(2024, 6, 20, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 16, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8845), new DateTime(2024, 6, 21, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 17, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8851), new DateTime(2024, 6, 22, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8857), new DateTime(2024, 6, 23, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 19, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8863), new DateTime(2024, 6, 24, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 20, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8967), new DateTime(2024, 6, 25, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 21, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8975), new DateTime(2024, 6, 26, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 22, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8981), new DateTime(2024, 6, 27, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 23, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8986), new DateTime(2024, 6, 28, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8995), new DateTime(2024, 6, 29, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 25, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 6, 30, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 6, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 6, 11, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 6, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9085), new DateTime(2024, 6, 11, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 7, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 6, 12, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 8, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9098), new DateTime(2024, 6, 13, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9105), new DateTime(2024, 6, 14, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 10, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9112), new DateTime(2024, 6, 15, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 11, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9118), new DateTime(2024, 6, 16, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 12, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 6, 17, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9132), new DateTime(2024, 6, 18, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 14, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9138), new DateTime(2024, 6, 19, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 15, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9145), new DateTime(2024, 6, 20, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 16, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 6, 21, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 17, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 6, 22, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 6, 23, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 19, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 6, 24, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 20, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9179), new DateTime(2024, 6, 25, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 21, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 6, 26, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 22, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9192), new DateTime(2024, 6, 27, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 23, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9199), new DateTime(2024, 6, 28, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9205), new DateTime(2024, 6, 29, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 25, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9212), new DateTime(2024, 6, 30, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 6, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9076), new DateTime(2024, 6, 11, 10, 57, 53, 830, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.CreateIndex(
                name: "IX_Rules_PropertyId",
                table: "Rules",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_Properties_PropertyId",
                table: "Rules",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
