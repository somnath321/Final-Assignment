﻿// <auto-generated />
using System;
using LeaveManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeaveManagement.Migrations
{
    [DbContext(typeof(LeaveManagementContext))]
    [Migration("20200409184333_Initial_Migrations")]
    partial class Initial_Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeaveManagement.Models.Admin", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("LeaveManagement.Models.Employee", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DOJ")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("LeaveManagement.Models.LeaveConfiguration", b =>
                {
                    b.Property<string>("Leave_Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("No_of_Days")
                        .HasColumnType("int");

                    b.HasKey("Leave_Name");

                    b.ToTable("LeaveConfiguration");
                });

            modelBuilder.Entity("LeaveManagement.Models.LeaveType", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Leave_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Date");

                    b.ToTable("LeaveType");
                });

            modelBuilder.Entity("LeaveManagement.Models.Leavelist", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Leave_balance")
                        .HasColumnType("int");

                    b.Property<string>("Leave_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Leavelist");
                });
#pragma warning restore 612, 618
        }
    }
}
