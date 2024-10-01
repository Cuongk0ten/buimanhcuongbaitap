﻿// <auto-generated />
using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DemoMVC.Models.Person", b =>
                {
                    b.Property<string>("cancuoccongdan")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("hoten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("quequan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("cancuoccongdan");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DemoMVC.Models.Employeee", b =>
                {
                    b.HasBaseType("DemoMVC.Models.Person");

                    b.Property<string>("EmployeeeID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Employeee");
                });
#pragma warning restore 612, 618
        }
    }
}
