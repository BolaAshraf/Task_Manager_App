﻿// <auto-generated />
using System;
using Clockify2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clockify2.Migrations
{
    [DbContext(typeof(ClockifyContext))]
    partial class ClockifyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Clockify2.Data.ActivityLog", b =>
                {
                    b.Property<int>("A_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("A_id"));

                    b.Property<int>("activty")
                        .HasColumnType("int");

                    b.Property<int>("stId")
                        .HasColumnType("int");

                    b.Property<DateTime>("timeOfActivity")
                        .HasColumnType("datetime2");

                    b.HasKey("A_id");

                    b.HasIndex("stId");

                    b.ToTable("Activitys");
                });

            modelBuilder.Entity("Clockify2.Data.MembersOfTeam", b =>
                {
                    b.Property<int>("JoinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JoinId"));

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.Property<int>("TId")
                        .HasColumnType("int");

                    b.HasKey("JoinId");

                    b.HasIndex("PId");

                    b.HasIndex("TId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Clockify2.Data.Person", b =>
                {
                    b.Property<int>("P_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("P_Id"));

                    b.Property<string>("P_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.Property<string>("imagelocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("registeredAt")
                        .HasColumnType("datetime2");

                    b.HasKey("P_Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Clockify2.Data.SubTask", b =>
                {
                    b.Property<int>("st_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("st_id"));

                    b.Property<int>("TId")
                        .HasColumnType("int");

                    b.Property<string>("st_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("st_id");

                    b.HasIndex("TId");

                    b.ToTable("SubTasks");
                });

            modelBuilder.Entity("Clockify2.Data.Task", b =>
                {
                    b.Property<int>("taskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("taskId"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("priority")
                        .HasColumnType("int");

                    b.Property<string>("taskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("taskId");

                    b.HasIndex("PId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Clockify2.Data.Team", b =>
                {
                    b.Property<int>("teamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teamId"));

                    b.Property<string>("teamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("teamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Clockify2.Data.ActivityLog", b =>
                {
                    b.HasOne("Clockify2.Data.SubTask", "st_id")
                        .WithMany("Activities")
                        .HasForeignKey("stId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("st_id");
                });

            modelBuilder.Entity("Clockify2.Data.MembersOfTeam", b =>
                {
                    b.HasOne("Clockify2.Data.Person", "P_Id")
                        .WithMany("Members")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clockify2.Data.Team", "team_Id")
                        .WithMany("Members")
                        .HasForeignKey("TId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("P_Id");

                    b.Navigation("team_Id");
                });

            modelBuilder.Entity("Clockify2.Data.SubTask", b =>
                {
                    b.HasOne("Clockify2.Data.Task", "task_Id")
                        .WithMany("SubTasks")
                        .HasForeignKey("TId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("task_Id");
                });

            modelBuilder.Entity("Clockify2.Data.Task", b =>
                {
                    b.HasOne("Clockify2.Data.Person", "P_Id")
                        .WithMany("Tasks")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("P_Id");
                });

            modelBuilder.Entity("Clockify2.Data.Person", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Clockify2.Data.SubTask", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("Clockify2.Data.Task", b =>
                {
                    b.Navigation("SubTasks");
                });

            modelBuilder.Entity("Clockify2.Data.Team", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
