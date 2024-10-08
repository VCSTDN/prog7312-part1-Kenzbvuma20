﻿// <auto-generated />
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
    [Migration("20240911173259_ProgressProperty")]
    partial class ProgressProperty
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReportsIssue.Models.MediaAttachment", b =>
                {
                    b.Property<int>("MediaAttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MediaAttachmentId"));

                    b.Property<string>("FilePath")
                        .IsRequired()
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
