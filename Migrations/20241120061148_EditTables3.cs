using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment2.Migrations
{
    /// <inheritdoc />
    public partial class EditTables3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reason",
                table: "appointments",
                newName: "reason");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "appointments",
                newName: "date_time2");

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumn: "reason",
                keyValue: null,
                column: "reason",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "reason",
                table: "appointments",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "reason",
                table: "appointments",
                newName: "Reason");

            migrationBuilder.RenameColumn(
                name: "date_time2",
                table: "appointments",
                newName: "AppointmentDate");

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "appointments",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
