﻿// <auto-generated />
using System;
using HiBoard.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HiBoard.Persistence.Migrations
{
    [DbContext(typeof(HiBoardDbContext))]
    partial class HiBoardDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActivityTemplate", b =>
                {
                    b.Property<int>("ActivitiesId")
                        .HasColumnType("int");

                    b.Property<int>("TemplatesId")
                        .HasColumnType("int");

                    b.HasKey("ActivitiesId", "TemplatesId");

                    b.HasIndex("TemplatesId");

                    b.ToTable("template_activities", (string)null);
                });

            modelBuilder.Entity("HiBoard.Domain.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("creation_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)")
                        .HasColumnName("description");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint")
                        .HasColumnName("is_deleted");

                    b.Property<string>("Tag")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tag");

                    b.Property<long>("TimeEstimation")
                        .HasColumnType("bigint")
                        .HasColumnName("time_estimation_in_ticks");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("updated_at");

                    b.Property<long>("UserAverageTime")
                        .HasColumnType("bigint")
                        .HasColumnName("user_average_time_in_ticks");

                    b.Property<int>("UserCompletedCount")
                        .HasColumnType("int")
                        .HasColumnName("user_completed_count");

                    b.Property<int>("Week")
                        .HasColumnType("int")
                        .HasColumnName("week");

                    b.HasKey("Id");

                    b.ToTable("activities", (string)null);
                });

            modelBuilder.Entity("HiBoard.Domain.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Admin")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("admin");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("creation_at");

                    b.Property<string>("Departments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("departments");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)")
                        .HasColumnName("description");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint")
                        .HasColumnName("is_deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("companies", (string)null);
                });

            modelBuilder.Entity("HiBoard.Domain.Models.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("creation_at");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("department");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint")
                        .HasColumnName("is_deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("templates", (string)null);
                });

            modelBuilder.Entity("HiBoard.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("creation_at");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("department");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint")
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int")
                        .HasColumnName("manager_id");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnName("role");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("HiBoard.Domain.Models.UserActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ActivityId")
                        .HasColumnType("int")
                        .HasColumnName("activity_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("creation_at");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint")
                        .HasColumnName("is_deleted");

                    b.Property<byte?>("IsOnTime")
                        .HasColumnType("tinyint")
                        .HasColumnName("is_on_time");

                    b.Property<DateTime?>("StartedWorkedOn")
                        .HasColumnType("DATETIME")
                        .HasColumnName("started_worked_on");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<long>("TimeTookToComplete")
                        .HasColumnType("bigint")
                        .HasColumnName("time_took_to_complete_in_ticks");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("DATETIME")
                        .HasColumnName("updated_at");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("UserId");

                    b.ToTable("user_activities", (string)null);
                });

            modelBuilder.Entity("ActivityTemplate", b =>
                {
                    b.HasOne("HiBoard.Domain.Models.Activity", null)
                        .WithMany()
                        .HasForeignKey("ActivitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HiBoard.Domain.Models.Template", null)
                        .WithMany()
                        .HasForeignKey("TemplatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HiBoard.Domain.Models.Template", b =>
                {
                    b.HasOne("HiBoard.Domain.Models.Company", null)
                        .WithMany("Templates")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HiBoard.Domain.Models.User", b =>
                {
                    b.HasOne("HiBoard.Domain.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("HiBoard.Domain.Models.UserActivity", b =>
                {
                    b.HasOne("HiBoard.Domain.Models.Activity", "Activity")
                        .WithMany("UserActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HiBoard.Domain.Models.User", "User")
                        .WithMany("UserActivities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HiBoard.Domain.Models.Activity", b =>
                {
                    b.Navigation("UserActivities");
                });

            modelBuilder.Entity("HiBoard.Domain.Models.Company", b =>
                {
                    b.Navigation("Templates");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("HiBoard.Domain.Models.User", b =>
                {
                    b.Navigation("UserActivities");
                });
#pragma warning restore 612, 618
        }
    }
}
