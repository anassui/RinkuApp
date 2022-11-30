﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RinkuApp.Persistence.Data;

#nullable disable

namespace RinkuApp.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221129233547_Add-A01Empleados")]
    partial class AddA01Empleados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RinkuApp.Persistence.Models.A01Empleados", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("Id"));

                    b.Property<Guid>("IdEmpleado")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdEmpleado");

                    b.HasKey("Id");

                    b.ToTable("A01_Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
