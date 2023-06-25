﻿// <auto-generated />
using System;
using APi_Ambulance.Persistens.CodeEfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APi_Ambulance.Persistens.Migrations
{
    [DbContext(typeof(EfCoreDbContext))]
    [Migration("20230625142704_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.AmbulanceDeparture", b =>
                {
                    b.Property<int>("AmbulanceDepartureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AmbulanceDepartureId"), 1L, 1);

                    b.Property<DateTime>("DateDepart")
                        .HasColumnType("date");

                    b.Property<DateTime>("EndTimePatient")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameHospital")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberAccident_AssistantSquad")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartPatient")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeDepart")
                        .HasColumnType("datetime2");

                    b.HasKey("AmbulanceDepartureId");

                    b.HasIndex("PatientId");

                    b.ToTable("AmbulanceDepartures");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.CallingAmbulance", b =>
                {
                    b.Property<int>("CallingAmbulanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CallingAmbulanceId"), 1L, 1);

                    b.Property<string>("CauseCall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCall")
                        .HasColumnType("date");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("RedirectCall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeCall")
                        .HasColumnType("datetime2");

                    b.HasKey("CallingAmbulanceId");

                    b.HasIndex("PatientId");

                    b.ToTable("CallingAmbulances");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.Locality", b =>
                {
                    b.Property<int>("LocalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocalityId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocalityId");

                    b.ToTable("Localities");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Family_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocalityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StreetId")
                        .HasColumnType("int");

                    b.HasKey("PatientId");

                    b.HasIndex("LocalityId");

                    b.HasIndex("StreetId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.Street", b =>
                {
                    b.Property<int>("StreetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StreetId"), 1L, 1);

                    b.Property<int>("LocalityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberEntranceOfHouse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberFlat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberHouse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StreetId");

                    b.HasIndex("LocalityId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.AmbulanceDeparture", b =>
                {
                    b.HasOne("APi_Ambulance.Domain.Entity.Patient", "Patient")
                        .WithMany("AmbulanceDepartures")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.CallingAmbulance", b =>
                {
                    b.HasOne("APi_Ambulance.Domain.Entity.Patient", "Patient")
                        .WithMany("CallingAmbulances")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.Patient", b =>
                {
                    b.HasOne("APi_Ambulance.Domain.Entity.Locality", "Locality")
                        .WithMany("Patients")
                        .HasForeignKey("LocalityId");

                    b.HasOne("APi_Ambulance.Domain.Entity.Street", "Street")
                        .WithMany("Patients")
                        .HasForeignKey("StreetId");

                    b.Navigation("Locality");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.Street", b =>
                {
                    b.HasOne("APi_Ambulance.Domain.Entity.Locality", "Locality")
                        .WithMany("Streets")
                        .HasForeignKey("LocalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Locality");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.Locality", b =>
                {
                    b.Navigation("Patients");

                    b.Navigation("Streets");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.Patient", b =>
                {
                    b.Navigation("AmbulanceDepartures");

                    b.Navigation("CallingAmbulances");
                });

            modelBuilder.Entity("APi_Ambulance.Domain.Entity.Street", b =>
                {
                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
