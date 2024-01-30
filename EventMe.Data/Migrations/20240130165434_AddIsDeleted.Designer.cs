﻿// <auto-generated />
using System;
using EventMe.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventMe.Data.Migrations
{
    [DbContext(typeof(EventMeDbContext))]
    [Migration("20240130165434_AddIsDeleted")]
    partial class AddIsDeleted
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventMe.Data.Data.EntityModels.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Event identifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2")
                        .HasComment("Event end");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Active status");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Event name");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Place for event");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2")
                        .HasComment("Event start");

                    b.HasKey("Id");

                    b.ToTable("Events", t =>
                        {
                            t.HasComment("Table with events");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
