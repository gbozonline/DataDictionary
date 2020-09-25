﻿// <auto-generated />
using DataDictionary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataDictionary.Migrations
{
    [DbContext(typeof(DataDictionaryContext))]
    partial class DataDictionaryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataDictionary.Models.Application", b =>
                {
                    b.Property<string>("ApplicationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("DataDictionary.Models.Keyword", b =>
                {
                    b.Property<int>("KeywordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field1")
                        .IsRequired()
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

                    b.Property<string>("KeywordDefinitionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("KeywordId");

                    b.HasIndex("KeywordDefinitionId");

                    b.ToTable("Keywords");
                });

            modelBuilder.Entity("DataDictionary.Models.KeywordDefinition", b =>
                {
                    b.Property<string>("KeywordDefinitionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

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

                    b.HasKey("KeywordDefinitionId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("KeywordDefinitions");
                });

            modelBuilder.Entity("DataDictionary.Models.Keyword", b =>
                {
                    b.HasOne("DataDictionary.Models.KeywordDefinition", "KeywordDefinition")
                        .WithMany("Keywords")
                        .HasForeignKey("KeywordDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataDictionary.Models.KeywordDefinition", b =>
                {
                    b.HasOne("DataDictionary.Models.Application", "Application")
                        .WithMany("KeywordDefinitions")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
