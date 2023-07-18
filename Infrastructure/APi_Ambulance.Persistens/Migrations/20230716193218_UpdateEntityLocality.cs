using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APi_Ambulance.Persistens.Migrations
{
    public partial class UpdateEntityLocality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Localities",
                newName: "NameLocality");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameLocality",
                table: "Localities",
                newName: "Name");
        }
    }
}
