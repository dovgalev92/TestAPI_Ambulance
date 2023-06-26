using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APi_Ambulance.Persistens.Migrations
{
    public partial class UpdateAmbulDep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "AmbulanceDepartures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResultDepart",
                table: "AmbulanceDepartures",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "AmbulanceDepartures");

            migrationBuilder.DropColumn(
                name: "ResultDepart",
                table: "AmbulanceDepartures");
        }
    }
}
