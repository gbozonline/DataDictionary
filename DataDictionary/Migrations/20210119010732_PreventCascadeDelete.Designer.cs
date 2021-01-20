﻿// <auto-generated />
using System;
using DataDictionary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataDictionary.Migrations
{
    [DbContext(typeof(DataDictionaryContext))]
    [Migration("20210119010732_PreventCascadeDelete")]
    partial class PreventCascadeDelete
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DataDictionary.Models.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecAppExpert")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("DataDictionary.Models.Keyword", b =>
                {
                    b.Property<int>("KeywordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Field1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field18")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field19")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field20")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field21")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field22")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field23")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field24")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field25")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KeywordDefinitionId")
                        .HasColumnType("int");

                    b.Property<int?>("KeywordDefinitionId1")
                        .HasColumnType("int");

                    b.Property<string>("KeywordDefinitionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KeywordId");

                    b.HasIndex("KeywordDefinitionId");

                    b.HasIndex("KeywordDefinitionId1");

                    b.ToTable("Keywords");
                });

            modelBuilder.Entity("DataDictionary.Models.KeywordDefinition", b =>
                {
                    b.Property<int>("KeywordDefinitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<int?>("ApplicationId1")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field10Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field11Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field12Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field13Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field14Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field15Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field16Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field17Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field18Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field19Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field1Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field20Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field21Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field22Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field23Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field24Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field25Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field3Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field4Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field5Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field6Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field7Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field8Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field9Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeywordDefinitionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KeywordDefinitionId");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("ApplicationId1");

                    b.ToTable("KeywordDefinitions");
                });

            modelBuilder.Entity("DataDictionary.Models.Keyword", b =>
                {
                    b.HasOne("DataDictionary.Models.KeywordDefinition", "KeywordDefinition")
                        .WithMany()
                        .HasForeignKey("KeywordDefinitionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataDictionary.Models.KeywordDefinition", null)
                        .WithMany("Keywords")
                        .HasForeignKey("KeywordDefinitionId1");

                    b.Navigation("KeywordDefinition");
                });

            modelBuilder.Entity("DataDictionary.Models.KeywordDefinition", b =>
                {
                    b.HasOne("DataDictionary.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataDictionary.Models.Application", null)
                        .WithMany("KeywordDefinitions")
                        .HasForeignKey("ApplicationId1");

                    b.Navigation("Application");
                });

            modelBuilder.Entity("DataDictionary.Models.Application", b =>
                {
                    b.Navigation("KeywordDefinitions");
                });

            modelBuilder.Entity("DataDictionary.Models.KeywordDefinition", b =>
                {
                    b.Navigation("Keywords");
                });
#pragma warning restore 612, 618
        }
    }
}