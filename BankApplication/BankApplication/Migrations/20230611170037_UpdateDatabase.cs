using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankApplication.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Open_bal",
                table: "customer",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<string>(
                name: "Occupation",
                table: "customer",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "customer",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "Atype",
                table: "customer",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "Astatus",
                table: "customer",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Relational:ColumnOrder", 10)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "customer",
                type: "text",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "customer");

            migrationBuilder.AlterColumn<int>(
                name: "Open_bal",
                table: "customer",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "Occupation",
                table: "customer",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "customer",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date")
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<string>(
                name: "Atype",
                table: "customer",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<string>(
                name: "Astatus",
                table: "customer",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 10);
        }
    }
}
