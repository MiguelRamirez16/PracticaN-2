﻿// <auto-generated />
using System;
using Construction.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Construction.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Construction.Shared.Entidades.AsignacionEquipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EquipoContruccionesId")
                        .HasColumnType("int");

                    b.Property<int?>("ProyectoConstruccionesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoContruccionesId");

                    b.HasIndex("ProyectoConstruccionesId");

                    b.ToTable("AsignacionEquipos");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.AsignacionMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MaterialesId")
                        .HasColumnType("int");

                    b.Property<int?>("TareasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialesId");

                    b.HasIndex("TareasId");

                    b.ToTable("AsignacionMateriales");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.EquipoConstruccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especialidades")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ListaMiembros")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("EquipoConstrucciones");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.Maquinaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<bool>("Disponibilidad")
                        .HasColumnType("bit");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TareasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TareasId");

                    b.ToTable("Maquinarias");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEntregaAprox")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Provedor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Materiales");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.Presupuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Presupuestos");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.ProyectoConstruccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaAproxFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MaquinariasId")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialesId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PresupuestosId")
                        .HasColumnType("int");

                    b.Property<int?>("TareasId")
                        .HasColumnType("int");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.HasIndex("MaquinariasId");

                    b.HasIndex("MaterialesId");

                    b.HasIndex("PresupuestosId");

                    b.HasIndex("TareasId");

                    b.ToTable("ProyectoConstrucciones");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaAproxFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.AsignacionEquipo", b =>
                {
                    b.HasOne("Construction.Shared.Entidades.EquipoConstruccion", "EquipoContrucciones")
                        .WithMany("AsignacionEquipos")
                        .HasForeignKey("EquipoContruccionesId");

                    b.HasOne("Construction.Shared.Entidades.ProyectoConstruccion", "ProyectoConstrucciones")
                        .WithMany("AsignacionEquipos")
                        .HasForeignKey("ProyectoConstruccionesId");

                    b.Navigation("EquipoContrucciones");

                    b.Navigation("ProyectoConstrucciones");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.AsignacionMaterial", b =>
                {
                    b.HasOne("Construction.Shared.Entidades.Material", "Materiales")
                        .WithMany("AsignacionMateriales")
                        .HasForeignKey("MaterialesId");

                    b.HasOne("Construction.Shared.Entidades.Tarea", "Tareas")
                        .WithMany("AsignacionMateriales")
                        .HasForeignKey("TareasId");

                    b.Navigation("Materiales");

                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.Maquinaria", b =>
                {
                    b.HasOne("Construction.Shared.Entidades.Tarea", "Tareas")
                        .WithMany()
                        .HasForeignKey("TareasId");

                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.ProyectoConstruccion", b =>
                {
                    b.HasOne("Construction.Shared.Entidades.Maquinaria", "Maquinarias")
                        .WithMany()
                        .HasForeignKey("MaquinariasId");

                    b.HasOne("Construction.Shared.Entidades.Material", "Materiales")
                        .WithMany()
                        .HasForeignKey("MaterialesId");

                    b.HasOne("Construction.Shared.Entidades.Presupuesto", "Presupuestos")
                        .WithMany()
                        .HasForeignKey("PresupuestosId");

                    b.HasOne("Construction.Shared.Entidades.Tarea", "Tareas")
                        .WithMany()
                        .HasForeignKey("TareasId");

                    b.Navigation("Maquinarias");

                    b.Navigation("Materiales");

                    b.Navigation("Presupuestos");

                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.EquipoConstruccion", b =>
                {
                    b.Navigation("AsignacionEquipos");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.Material", b =>
                {
                    b.Navigation("AsignacionMateriales");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.ProyectoConstruccion", b =>
                {
                    b.Navigation("AsignacionEquipos");
                });

            modelBuilder.Entity("Construction.Shared.Entidades.Tarea", b =>
                {
                    b.Navigation("AsignacionMateriales");
                });
#pragma warning restore 612, 618
        }
    }
}
