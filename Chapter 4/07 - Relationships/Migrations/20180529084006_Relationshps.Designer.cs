﻿// <auto-generated />
using MappedModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Relationships.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20180529084006_Relationshps")]
    partial class Relationshps
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("MappedModel.Sibling", b =>
                {
                    b.Property<Guid>("SiblingID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("StudentID");

                    b.HasKey("SiblingID");

                    b.HasIndex("StudentID");

                    b.ToTable("Sibling");
                });

            modelBuilder.Entity("MappedModel.Student", b =>
                {
                    b.Property<Guid>("StudentID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<decimal>("FeesOutstanding")
                        .HasColumnType("numeric (20,8)");

                    b.Property<string>("FullNames")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("M")
                        .HasMaxLength(1);

                    b.Property<decimal>("Height");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SystemAge")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("age(CURRENT_TIMESTAMP,DateOfBirth)");

                    b.Property<decimal?>("Weight")
                        .HasColumnName("WGHT");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MappedModel.Sibling", b =>
                {
                    b.HasOne("MappedModel.Student")
                        .WithMany("Siblings")
                        .HasForeignKey("StudentID");
                });
#pragma warning restore 612, 618
        }
    }
}
