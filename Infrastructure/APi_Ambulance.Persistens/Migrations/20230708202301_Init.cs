using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APi_Ambulance.Persistens.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Localities",
                columns: table => new
                {
                    LocalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localities", x => x.LocalityId);
                });

            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    StreetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberHouse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberEntranceOfHouse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberFlat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.StreetId);
                    table.ForeignKey(
                        name: "FK_Streets_Localities_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Localities",
                        principalColumn: "LocalityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Family_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BirthYear = table.Column<DateTime>(type: "date", nullable: false),
                    StreetId = table.Column<int>(type: "int", nullable: true),
                    LocalityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_Localities_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Localities",
                        principalColumn: "LocalityId");
                    table.ForeignKey(
                        name: "FK_Patients_Streets_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Streets",
                        principalColumn: "StreetId");
                });

            migrationBuilder.CreateTable(
                name: "CallingAmbulances",
                columns: table => new
                {
                    CallingAmbulanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCall = table.Column<DateTime>(type: "date", nullable: false),
                    TimeCall = table.Column<TimeSpan>(type: "time", nullable: false),
                    CauseCall = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RedirectCall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallingAmbulances", x => x.CallingAmbulanceId);
                    table.ForeignKey(
                        name: "FK_CallingAmbulances_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AmbulanceDepartures",
                columns: table => new
                {
                    AmbulanceDepartureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberAccident_AssistantSquad = table.Column<int>(type: "int", nullable: false),
                    DateDepart = table.Column<DateTime>(type: "date", nullable: false),
                    TimeDepart = table.Column<TimeSpan>(type: "time", nullable: false),
                    StartPatient = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTimePatient = table.Column<TimeSpan>(type: "time", nullable: false),
                    NameHospital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResultDepart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallingAmbulanceId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmbulanceDepartures", x => x.AmbulanceDepartureId);
                    table.ForeignKey(
                        name: "FK_AmbulanceDepartures_CallingAmbulances_CallingAmbulanceId",
                        column: x => x.CallingAmbulanceId,
                        principalTable: "CallingAmbulances",
                        principalColumn: "CallingAmbulanceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmbulanceDepartures_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmbulanceDepartures_CallingAmbulanceId",
                table: "AmbulanceDepartures",
                column: "CallingAmbulanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AmbulanceDepartures_PatientId",
                table: "AmbulanceDepartures",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_CallingAmbulances_PatientId",
                table: "CallingAmbulances",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_LocalityId",
                table: "Patients",
                column: "LocalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_StreetId",
                table: "Patients",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_Streets_LocalityId",
                table: "Streets",
                column: "LocalityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmbulanceDepartures");

            migrationBuilder.DropTable(
                name: "CallingAmbulances");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Streets");

            migrationBuilder.DropTable(
                name: "Localities");
        }
    }
}
