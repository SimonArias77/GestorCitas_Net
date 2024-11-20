using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment2.Migrations
{
    /// <inheritdoc />
    public partial class EditTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDate",
                table: "appointments",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "appointments",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "HistoryDates",
                columns: new[] { "id", "appointment_id", "date_time", "reason" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), "Consulta inicial por dolores de cabeza frecuentes" },
                    { 2, 2, new DateTime(2024, 10, 18, 11, 30, 0, 0, DateTimeKind.Unspecified), "Revisión de resultados de análisis de sangre" },
                    { 3, 3, new DateTime(2024, 10, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "Seguimiento de tratamiento para hipertensión" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "id", "date_born", "email", "last_name", "name", "phone_number" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "juan.perez@example.com", "Pérez", "Juan", "1234567890" },
                    { 2, new DateTime(1990, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "maria.garcia@example.com", "García", "María", "9876543210" },
                    { 3, new DateTime(1978, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "carlos.lopez@example.com", "López", "Carlos", "4567891230" },
                    { 4, new DateTime(1995, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ana.martinez@example.com", "Martínez", "Ana", "3216549870" },
                    { 5, new DateTime(1982, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "luis.rodriguez@example.com", "Rodríguez", "Luis", "7890123456" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_email",
                table: "Doctors",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_administrators_email",
                table: "administrators",
                column: "email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Doctors_email",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_administrators_email",
                table: "administrators");

            migrationBuilder.DeleteData(
                table: "HistoryDates",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HistoryDates",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HistoryDates",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "appointments");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "appointments");
        }
    }
}
