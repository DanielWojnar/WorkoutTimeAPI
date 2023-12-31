﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkoutTimeAPI.Data;

#nullable disable

namespace WorkoutTimeAPI.Migrations
{
    [DbContext(typeof(WorkoutTimeContext))]
    partial class WorkoutTimeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WorkoutTimeAPI.Models.Exercise", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("RestAfter")
                        .HasColumnType("real");

                    b.Property<float>("RestBetweenSets")
                        .HasColumnType("real");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("WorkoutTimeAPI.Models.Workout", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("WorkoutTimeAPI.Models.Exercise", b =>
                {
                    b.HasOne("WorkoutTimeAPI.Models.Workout", "Parent")
                        .WithMany("Exercises")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("WorkoutTimeAPI.Models.Workout", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
