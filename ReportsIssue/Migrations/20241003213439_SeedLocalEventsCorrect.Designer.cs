﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReportsIssue.Models;

#nullable disable

namespace ReportsIssue.Migrations
{
    [DbContext(typeof(ReportsIssueDbContext))]
    [Migration("20241003213439_SeedLocalEventsCorrect")]
    partial class SeedLocalEventsCorrect
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReportsIssue.Models.LocalEvent", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("LocalEvents");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            Category = "Roads",
                            Description = "Join us to clean up the local park.",
                            EventDate = new DateTime(2024, 10, 8, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(891),
                            Title = "Community Cleanup"
                        },
                        new
                        {
                            EventId = 2,
                            Category = "Other",
                            Description = "A talk on the latest trends in technology.",
                            EventDate = new DateTime(2024, 10, 13, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(912),
                            Title = "Tech Talk"
                        },
                        new
                        {
                            EventId = 3,
                            Category = "Sanitation",
                            Description = "Discover tips and resources for a healthier lifestyle.",
                            EventDate = new DateTime(2024, 10, 18, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(914),
                            Title = "Health and Wellness Fair"
                        },
                        new
                        {
                            EventId = 4,
                            Category = "Sanitation",
                            Description = "Join your neighbors to clean up local parks and streets.",
                            EventDate = new DateTime(2024, 10, 13, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(916),
                            Title = "Community Cleanup Day"
                        },
                        new
                        {
                            EventId = 5,
                            Category = "Roads",
                            Description = "A discussion on improving road safety and addressing local concerns.",
                            EventDate = new DateTime(2024, 10, 23, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(917),
                            Title = "Public Road Safety Forum"
                        });
                });

            modelBuilder.Entity("ReportsIssue.Models.MediaAttachment", b =>
                {
                    b.Property<int>("MediaAttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MediaAttachmentId"));

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediaAttachmentId");

                    b.ToTable("MediaAttachments");
                });

            modelBuilder.Entity("ReportsIssue.Models.ReportIssueViewModel", b =>
                {
                    b.Property<int>("ReportsIssueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportsIssueId"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaAttachmentFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MediaAttachmentId")
                        .HasColumnType("int");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.HasKey("ReportsIssueId");

                    b.HasIndex("MediaAttachmentId");

                    b.ToTable("ReportIssues");
                });

            modelBuilder.Entity("ReportsIssue.Models.ReportIssueViewModel", b =>
                {
                    b.HasOne("ReportsIssue.Models.MediaAttachment", "MediaAttachment")
                        .WithMany()
                        .HasForeignKey("MediaAttachmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MediaAttachment");
                });
#pragma warning restore 612, 618
        }
    }
}
