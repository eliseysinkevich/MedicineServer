﻿// <auto-generated />
using System;
using MedicineServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedicineServer.Migrations
{
    [DbContext(typeof(MedicineContext))]
    [Migration("20190629122233_Parameter")]
    partial class Parameter
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MedicineServer.Model.Complaint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int?>("ProblemId");

                    b.HasKey("Id");

                    b.HasIndex("ProblemId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("MedicineServer.Model.Diagnosis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int?>("DoctorId");

                    b.Property<int?>("ProblemId");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("ProblemId");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("MedicineServer.Model.DiagnosisDisease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DiagnosisId");

                    b.Property<int?>("DiseaseId");

                    b.HasKey("Id");

                    b.HasIndex("DiagnosisId");

                    b.HasIndex("DiseaseId");

                    b.ToTable("DiagnosisDiseases");
                });

            modelBuilder.Entity("MedicineServer.Model.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.HasKey("Id");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("MedicineServer.Model.DiseaseTreatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DiseaseId");

                    b.Property<int?>("TreatmentId");

                    b.HasKey("Id");

                    b.HasIndex("DiseaseId");

                    b.HasIndex("TreatmentId");

                    b.ToTable("DiseaseTreatments");
                });

            modelBuilder.Entity("MedicineServer.Model.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MedicineServer.Model.Medicament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("MedicineServer.Model.Parameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("MedicineServer.Model.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("MedicineServer.Model.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DiagnosisId");

                    b.HasKey("Id");

                    b.HasIndex("DiagnosisId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("MedicineServer.Model.PrescriptionTreatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PrescriptionId");

                    b.Property<int?>("TreatmentId");

                    b.HasKey("Id");

                    b.HasIndex("PrescriptionId");

                    b.HasIndex("TreatmentId");

                    b.ToTable("PrescriptionTreatments");
                });

            modelBuilder.Entity("MedicineServer.Model.Problem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int?>("DoctorId");

                    b.Property<int?>("PatientId");

                    b.Property<DateTime>("ProblemDate");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Problems");
                });

            modelBuilder.Entity("MedicineServer.Model.Symptom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArchetypeValue");

                    b.Property<int?>("DiagnosisDiseaseId");

                    b.Property<int?>("ParameterId");

                    b.HasKey("Id");

                    b.HasIndex("DiagnosisDiseaseId");

                    b.HasIndex("ParameterId");

                    b.ToTable("Symptoms");
                });

            modelBuilder.Entity("MedicineServer.Model.Treatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int?>("MedicamentId");

                    b.HasKey("Id");

                    b.HasIndex("MedicamentId");

                    b.ToTable("Treatments");
                });

            modelBuilder.Entity("MedicineServer.Model.Complaint", b =>
                {
                    b.HasOne("MedicineServer.Model.Problem", "Problem")
                        .WithMany()
                        .HasForeignKey("ProblemId");
                });

            modelBuilder.Entity("MedicineServer.Model.Diagnosis", b =>
                {
                    b.HasOne("MedicineServer.Model.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.HasOne("MedicineServer.Model.Problem", "Problem")
                        .WithMany()
                        .HasForeignKey("ProblemId");
                });

            modelBuilder.Entity("MedicineServer.Model.DiagnosisDisease", b =>
                {
                    b.HasOne("MedicineServer.Model.Diagnosis", "Diagnosis")
                        .WithMany()
                        .HasForeignKey("DiagnosisId");

                    b.HasOne("MedicineServer.Model.Disease", "Disease")
                        .WithMany()
                        .HasForeignKey("DiseaseId");
                });

            modelBuilder.Entity("MedicineServer.Model.DiseaseTreatment", b =>
                {
                    b.HasOne("MedicineServer.Model.Disease", "Disease")
                        .WithMany()
                        .HasForeignKey("DiseaseId");

                    b.HasOne("MedicineServer.Model.Treatment", "Treatment")
                        .WithMany()
                        .HasForeignKey("TreatmentId");
                });

            modelBuilder.Entity("MedicineServer.Model.Prescription", b =>
                {
                    b.HasOne("MedicineServer.Model.Diagnosis", "Diagnosis")
                        .WithMany()
                        .HasForeignKey("DiagnosisId");
                });

            modelBuilder.Entity("MedicineServer.Model.PrescriptionTreatment", b =>
                {
                    b.HasOne("MedicineServer.Model.Prescription", "Prescription")
                        .WithMany()
                        .HasForeignKey("PrescriptionId");

                    b.HasOne("MedicineServer.Model.Treatment", "Treatment")
                        .WithMany()
                        .HasForeignKey("TreatmentId");
                });

            modelBuilder.Entity("MedicineServer.Model.Problem", b =>
                {
                    b.HasOne("MedicineServer.Model.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.HasOne("MedicineServer.Model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("MedicineServer.Model.Symptom", b =>
                {
                    b.HasOne("MedicineServer.Model.DiagnosisDisease", "DiagnosisDisease")
                        .WithMany()
                        .HasForeignKey("DiagnosisDiseaseId");

                    b.HasOne("MedicineServer.Model.Parameter", "Parameter")
                        .WithMany()
                        .HasForeignKey("ParameterId");
                });

            modelBuilder.Entity("MedicineServer.Model.Treatment", b =>
                {
                    b.HasOne("MedicineServer.Model.Medicament", "Medicament")
                        .WithMany()
                        .HasForeignKey("MedicamentId");
                });
#pragma warning restore 612, 618
        }
    }
}
