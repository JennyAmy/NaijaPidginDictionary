﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NaijaPidginAPI.DbContexts;

namespace NaijaPidginAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220422152806_user removed")]
    partial class userremoved
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NaijaPidginAPI.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordKey")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NaijaPidginAPI.Entities.Word", b =>
                {
                    b.Property<int>("WordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sentence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WordClassId")
                        .HasColumnType("int");

                    b.Property<string>("WordInput")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WordId");

                    b.HasIndex("WordClassId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("NaijaPidginAPI.Entities.WordClass", b =>
                {
                    b.Property<int>("WordClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("WordClassname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WordClassId");

                    b.ToTable("WordClasses");
                });

            modelBuilder.Entity("NaijaPidginAPI.Entities.Word", b =>
                {
                    b.HasOne("NaijaPidginAPI.Entities.WordClass", "WordClass")
                        .WithMany()
                        .HasForeignKey("WordClassId");

                    b.Navigation("WordClass");
                });
#pragma warning restore 612, 618
        }
    }
}
