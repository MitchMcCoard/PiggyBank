﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PiggyBank.Models;

namespace PiggyBank.Migrations
{
    [DbContext(typeof(PiggyBankContext))]
    partial class PiggyBankContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("PiggyBank.Models.SavingsGoal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<float>("GoalPrice")
                        .HasColumnType("REAL");

                    b.Property<string>("LinkToImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkToPage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("SavingsGoals");
                });
#pragma warning restore 612, 618
        }
    }
}
