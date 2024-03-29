﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RmgAPI.Models;

namespace RmgAPI.Migrations
{
    [DbContext(typeof(RMGdbContext))]
    [Migration("20191022195716_EmployeeTableIsAdded")]
    partial class EmployeeTableIsAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RmgAPI.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountName");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("RmgAPI.Models.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountID");

                    b.Property<string>("ContactNumber")
                        .IsRequired();

                    b.Property<string>("CurrentProject")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EmployeeName")
                        .IsRequired();

                    b.Property<string>("Experience")
                        .IsRequired();

                    b.Property<string>("src");

                    b.HasKey("Id");

                    b.ToTable("Employees_1");
                });

            modelBuilder.Entity("RmgAPI.Models.ListOfRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountID");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("NumOfDevelopers");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Technology")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ListOfRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
