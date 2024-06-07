using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirBnb.DAL.Migrations
{
    /// <inheritdoc />
    public partial class radwaintal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Properties_PropertyId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_AspNetUsers_UserId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Bookings_BookingId",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "PropertyImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Properties",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countires",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Properties_PropertyId",
                table: "Bookings",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_AspNetUsers_UserId",
                table: "Properties",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Bookings_BookingId",
                table: "Reviews",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Properties_PropertyId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_AspNetUsers_UserId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Bookings_BookingId",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "PropertyImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Properties",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countires",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9363), new DateTime(2024, 6, 11, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 7, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9368), new DateTime(2024, 6, 12, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 8, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9373), new DateTime(2024, 6, 13, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9377), new DateTime(2024, 6, 14, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 10, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9382), new DateTime(2024, 6, 15, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 11, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9386), new DateTime(2024, 6, 16, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 12, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9391), new DateTime(2024, 6, 17, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9395), new DateTime(2024, 6, 18, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 14, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 6, 19, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9405), new DateTime(2024, 6, 20, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 16, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9410), new DateTime(2024, 6, 21, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9415), new DateTime(2024, 6, 22, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9419), new DateTime(2024, 6, 23, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 19, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9424), new DateTime(2024, 6, 24, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 20, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 6, 25, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9432), new DateTime(2024, 6, 26, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9437), new DateTime(2024, 6, 27, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 23, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9441), new DateTime(2024, 6, 28, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 24, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9446), new DateTime(2024, 6, 29, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 6, 30, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9311), new DateTime(2024, 6, 11, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9517), new DateTime(2024, 6, 11, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 7, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9522), new DateTime(2024, 6, 12, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 8, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9575), new DateTime(2024, 6, 13, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9581), new DateTime(2024, 6, 14, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 10, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9586), new DateTime(2024, 6, 15, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 11, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9592), new DateTime(2024, 6, 16, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 12, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9597), new DateTime(2024, 6, 17, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9602), new DateTime(2024, 6, 18, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 14, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9607), new DateTime(2024, 6, 19, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9612), new DateTime(2024, 6, 20, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 16, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9618), new DateTime(2024, 6, 21, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9622), new DateTime(2024, 6, 22, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9628), new DateTime(2024, 6, 23, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 19, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9634), new DateTime(2024, 6, 24, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 20, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9639), new DateTime(2024, 6, 25, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9644), new DateTime(2024, 6, 26, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9649), new DateTime(2024, 6, 27, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 23, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9654), new DateTime(2024, 6, 28, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 24, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9659), new DateTime(2024, 6, 29, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9664), new DateTime(2024, 6, 30, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9508), new DateTime(2024, 6, 11, 0, 54, 29, 868, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Properties_PropertyId",
                table: "Bookings",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_AspNetUsers_UserId",
                table: "Properties",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Bookings_BookingId",
                table: "Reviews",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
