using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class AddPaymenttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "CarRequests",
                newName: "RentalStatus");

            migrationBuilder.RenameColumn(
                name: "RealDate",
                table: "CarRequests",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "BookingDate",
                table: "CarRequests",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "CarRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "CarRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "CarRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PaymentStatus",
                table: "CarRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "CarRequests",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Method = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_CarRequests_CarRequestId",
                        column: x => x.CarRequestId,
                        principalTable: "CarRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CarRequestId",
                table: "Payments",
                column: "CarRequestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CarRequests");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "CarRequests");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "CarRequests");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "CarRequests");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "CarRequests");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "CarRequests",
                newName: "RealDate");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "CarRequests",
                newName: "BookingDate");

            migrationBuilder.RenameColumn(
                name: "RentalStatus",
                table: "CarRequests",
                newName: "Status");
        }
    }
}
