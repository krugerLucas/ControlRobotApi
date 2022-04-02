﻿// <auto-generated />
using ControlRobotApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControlRobotApi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220401191534_creatingSQLite")]
    partial class creatingSQLite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("ControlRobotApi.Models.States", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("stateHeadInclination")
                        .HasColumnType("TEXT");

                    b.Property<string>("stateHeadRotation")
                        .HasColumnType("TEXT");

                    b.Property<string>("stateLeftWrist")
                        .HasColumnType("TEXT");

                    b.Property<string>("stateLeftelbow")
                        .HasColumnType("TEXT");

                    b.Property<string>("stateRightWrist")
                        .HasColumnType("TEXT");

                    b.Property<string>("stateRightelbow")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("States");
                });
#pragma warning restore 612, 618
        }
    }
}
