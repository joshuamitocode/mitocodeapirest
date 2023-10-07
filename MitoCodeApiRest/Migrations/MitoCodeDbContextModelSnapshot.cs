﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MitoCodeApiRest.Data;

#nullable disable

namespace MitoCodeApiRest.Migrations
{
    [DbContext(typeof(MitoCodeDbContext))]
    partial class MitoCodeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MitoCodeApiRest.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Erick"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Adam"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Roxana"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
