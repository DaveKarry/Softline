﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Softline.Data;

namespace Softline.Migrations
{
    [DbContext(typeof(EmployerContext))]
    partial class EmployerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Softline.Models.Employer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MaternityLeave")
                        .HasColumnType("bit");

                    b.Property<string>("Midname")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Employers");
                });
#pragma warning restore 612, 618
        }
    }
}
