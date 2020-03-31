﻿// <auto-generated />
using System;
using AspNetCore_RazorPages.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCore_RazorPages.Migrations
{
    [DbContext(typeof(AufgabenDbContext))]
    [Migration("20200331095849_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCore_RazorPages.Data.Aufgabe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AufgabeBis")
                        .HasColumnType("datetime2");

                    b.Property<string>("AufgabenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IstFertig")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Aufgabe");
                });
#pragma warning restore 612, 618
        }
    }
}
