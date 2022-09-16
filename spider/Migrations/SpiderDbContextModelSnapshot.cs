﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using spider.Data;

#nullable disable

namespace spider.Migrations
{
    [DbContext(typeof(SpiderDbContext))]
    partial class SpiderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.7.22376.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("spider.Model.Product", b =>
                {
                    b.Property<string>("Sku")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Abv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BottleSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<DateTime>("collectionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Sku");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
