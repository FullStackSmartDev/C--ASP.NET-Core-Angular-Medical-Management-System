﻿// <auto-generated />
using System;
using Medico.Api.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Medico.Api.Migrations
{
    [DbContext(typeof(MedicoContext))]
    [Migration("20180723205234_Fill_Medication_Table")]
    partial class Fill_Medication_Table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Medico.Api.DB.Models.Admission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("AdmissionData")
                        .IsRequired();

                    b.Property<Guid>("AppointmentId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<Guid>("PatientDemographicId");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.HasIndex("PatientDemographicId");

                    b.ToTable("Admission");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<Guid?>("AdmissionId");

                    b.Property<int>("AppointmentStatus");

                    b.Property<Guid>("CompanyId");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<Guid>("LocationId");

                    b.Property<Guid>("NurseId");

                    b.Property<Guid>("PatientDemographicId");

                    b.Property<Guid>("PhysicianId");

                    b.Property<Guid>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PatientDemographicId");

                    b.HasIndex("RoomId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.ChiefComplaint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("IsActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("True");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("TemplateName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("TemplateType")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("ChiefComplaint");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Fax")
                        .IsRequired();

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<Guid?>("PatientDataModelId");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("SecondaryAddress")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.CptCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CptCode");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("CompanyId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int>("ExmployeeType");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Gender");

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100);

                    b.Property<string>("PrimaryPhone")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SecondaryAddress")
                        .HasMaxLength(200);

                    b.Property<string>("SecondaryPhone")
                        .HasMaxLength(100);

                    b.Property<string>("Ssn")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("State")
                        .HasMaxLength(100);

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("CompanyId");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SecondaryAddress")
                        .HasMaxLength(200);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Medication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Class");

                    b.Property<string>("Form");

                    b.Property<string>("GenericName");

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NdcCode");

                    b.Property<string>("PackageDescription");

                    b.Property<string>("ProductNdc");

                    b.Property<string>("Route");

                    b.Property<string>("Schedule");

                    b.Property<string>("Strength");

                    b.Property<string>("Substance");

                    b.Property<string>("Type");

                    b.Property<string>("Units");

                    b.HasKey("Id");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.PatientDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<Guid?>("CompanyId");

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("JsonPatientDataModel")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique()
                        .HasFilter("[CompanyId] IS NOT NULL");

                    b.ToTable("PatientDataModel");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.PatientDemographic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<Guid>("CompanyId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Gender");

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("PatientDemographic");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("IsDelete");

                    b.Property<Guid>("LocationId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.TemplateLookupItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<Guid?>("CompanyId");

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("JsonValues")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("TemplateLookupItemCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("TemplateLookupItemCategoryId");

                    b.ToTable("TemplateLookupItem");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.TemplateLookupItemCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<bool?>("IsDelete")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("TemplateLookupItemCategory");
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Admission", b =>
                {
                    b.HasOne("Medico.Api.DB.Models.Appointment", "Appointment")
                        .WithOne("Admission")
                        .HasForeignKey("Medico.Api.DB.Models.Admission", "AppointmentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Medico.Api.DB.Models.PatientDemographic", "PatientDemographic")
                        .WithMany("Admissions")
                        .HasForeignKey("PatientDemographicId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Appointment", b =>
                {
                    b.HasOne("Medico.Api.DB.Models.Company", "Company")
                        .WithMany("Appointments")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Medico.Api.DB.Models.Location", "Location")
                        .WithMany("Appointments")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Medico.Api.DB.Models.PatientDemographic", "PatientDemographic")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientDemographicId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Medico.Api.DB.Models.Room", "Room")
                        .WithMany("Appointments")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Employee", b =>
                {
                    b.HasOne("Medico.Api.DB.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Location", b =>
                {
                    b.HasOne("Medico.Api.DB.Models.Company", "Company")
                        .WithMany("Locations")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Medico.Api.DB.Models.PatientDataModel", b =>
                {
                    b.HasOne("Medico.Api.DB.Models.Company", "Company")
                        .WithOne("PatientDataModel")
                        .HasForeignKey("Medico.Api.DB.Models.PatientDataModel", "CompanyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Medico.Api.DB.Models.PatientDemographic", b =>
                {
                    b.HasOne("Medico.Api.DB.Models.Company", "Company")
                        .WithMany("PatientDemographics")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Medico.Api.DB.Models.Room", b =>
                {
                    b.HasOne("Medico.Api.DB.Models.Location", "Location")
                        .WithMany("Rooms")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Medico.Api.DB.Models.TemplateLookupItem", b =>
                {
                    b.HasOne("Medico.Api.DB.Models.Company", "Company")
                        .WithMany("TemplateLookupItems")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Medico.Api.DB.Models.TemplateLookupItemCategory", "TemplateLookupItemCategory")
                        .WithMany("TemplateLookupItems")
                        .HasForeignKey("TemplateLookupItemCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
