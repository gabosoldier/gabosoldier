﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TareaBackend;

namespace TareaBackend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220405032959_Cuoarto")]
    partial class Cuoarto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TareaBackend.Entidades.Dron", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CapacidaBateria")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("Modelo")
                        .HasColumnType("int");

                    b.Property<string>("NumeroSerie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PesoLimite")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dron");
                });

            modelBuilder.Entity("TareaBackend.Entidades.DronMedicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("DronId")
                        .HasColumnType("int");

                    b.Property<int?>("MedicamentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DronId");

                    b.HasIndex("MedicamentoId");

                    b.ToTable("DronMedicamento");
                });

            modelBuilder.Entity("TareaBackend.Entidades.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Medicamento");
                });

            modelBuilder.Entity("TareaBackend.Entidades.DronMedicamento", b =>
                {
                    b.HasOne("TareaBackend.Entidades.Dron", "Dron")
                        .WithMany("DronMedicamento")
                        .HasForeignKey("DronId");

                    b.HasOne("TareaBackend.Entidades.Medicamento", "Medicamento")
                        .WithMany("DronMedicamento")
                        .HasForeignKey("MedicamentoId");

                    b.Navigation("Dron");

                    b.Navigation("Medicamento");
                });

            modelBuilder.Entity("TareaBackend.Entidades.Dron", b =>
                {
                    b.Navigation("DronMedicamento");
                });

            modelBuilder.Entity("TareaBackend.Entidades.Medicamento", b =>
                {
                    b.Navigation("DronMedicamento");
                });
#pragma warning restore 612, 618
        }
    }
}
