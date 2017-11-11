﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication3;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(InsuranceCompany11Context))]
    [Migration("20171111104430_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication3.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientAddress");

                    b.Property<DateTime?>("ClientDateBirth");

                    b.Property<string>("ClientName");

                    b.Property<string>("ClientPassport");

                    b.Property<int?>("ClientPhone");

                    b.Property<string>("ClientSex");

                    b.Property<int?>("GroupId");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("WebApplication3.Risks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AverageProbability");

                    b.Property<string>("RiskDescription");

                    b.Property<string>("RiskName");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("Risks");
                });

            modelBuilder.Entity("WebApplication3.Staffs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StaffExperience");

                    b.Property<string>("StaffName");

                    b.Property<string>("StaffPost");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });
#pragma warning restore 612, 618
        }
    }
}
