﻿// <auto-generated />
using System;
using Medico.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Medico.Data.Migrations
{
    [DbContext(typeof(MedicoContext))]
    [Migration("20190706224924_MedicoApplicationUserView_View")]
    partial class MedicoApplicationUserView_View
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Medico.Domain.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SecondaryAddress")
                        .HasMaxLength(2000);

                    b.Property<int>("State");

                    b.Property<string>("WebSiteUrl")
                        .HasMaxLength(2000);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Medico.Domain.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("CompanyId");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SecondaryAddress")
                        .HasMaxLength(2000);

                    b.Property<int>("State");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Medico.Domain.Models.MedicoApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("CompanyId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("EmployeeType");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Gender");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100);

                    b.Property<string>("NamePrefix")
                        .HasMaxLength(100);

                    b.Property<string>("NameSuffix")
                        .HasMaxLength(100);

                    b.Property<string>("PrimaryPhone")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SecondaryAddress")
                        .HasMaxLength(2000);

                    b.Property<string>("SecondaryPhone")
                        .HasMaxLength(100);

                    b.Property<string>("Ssn")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("State");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("MedicoApplicationUser");
                });

            modelBuilder.Entity("Medico.Domain.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<bool>("IsActive");

                    b.Property<Guid>("LocationId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Medico.Domain.Models.Location", b =>
                {
                    b.HasOne("Medico.Domain.Models.Company", "Company")
                        .WithMany("Locations")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Medico.Domain.Models.MedicoApplicationUser", b =>
                {
                    b.HasOne("Medico.Domain.Models.Company", "Company")
                        .WithMany("MedicoApplicationUsers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Medico.Domain.Models.Room", b =>
                {
                    b.HasOne("Medico.Domain.Models.Location", "Location")
                        .WithMany("Rooms")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
