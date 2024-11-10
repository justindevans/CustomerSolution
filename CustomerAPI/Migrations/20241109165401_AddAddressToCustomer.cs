using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerAPI.Migrations
{
    public partial class AddAddressToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerTitle",
                table: "Customers",
                newName: "customerTitle");

            migrationBuilder.RenameColumn(
                name: "CustomerTelephone",
                table: "Customers",
                newName: "customerTelephone");

            migrationBuilder.RenameColumn(
                name: "CustomerLastName",
                table: "Customers",
                newName: "customerLastName");

            migrationBuilder.RenameColumn(
                name: "CustomerFirstName",
                table: "Customers",
                newName: "customerFirstName");

            migrationBuilder.RenameColumn(
                name: "CustomerEmail",
                table: "Customers",
                newName: "customerEmail");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "customerId");

            migrationBuilder.AddColumn<string>(
                name: "customerAddr1",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "customerAddr2",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "customerPostcode",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "customerTown",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customerAddr1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "customerAddr2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "customerPostcode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "customerTown",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "customerTitle",
                table: "Customers",
                newName: "CustomerTitle");

            migrationBuilder.RenameColumn(
                name: "customerTelephone",
                table: "Customers",
                newName: "CustomerTelephone");

            migrationBuilder.RenameColumn(
                name: "customerLastName",
                table: "Customers",
                newName: "CustomerLastName");

            migrationBuilder.RenameColumn(
                name: "customerFirstName",
                table: "Customers",
                newName: "CustomerFirstName");

            migrationBuilder.RenameColumn(
                name: "customerEmail",
                table: "Customers",
                newName: "CustomerEmail");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Customers",
                newName: "CustomerId");
        }
    }
}
