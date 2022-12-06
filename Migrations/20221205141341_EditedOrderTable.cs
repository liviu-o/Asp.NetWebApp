using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asp.NetEmpty.Migrations
{
    /// <inheritdoc />
    public partial class EditedOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdressLine2",
                table: "Orders",
                newName: "AddressLine2");

            migrationBuilder.RenameColumn(
                name: "AdressLine1",
                table: "Orders",
                newName: "AddressLine1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressLine2",
                table: "Orders",
                newName: "AdressLine2");

            migrationBuilder.RenameColumn(
                name: "AddressLine1",
                table: "Orders",
                newName: "AdressLine1");
        }
    }
}
