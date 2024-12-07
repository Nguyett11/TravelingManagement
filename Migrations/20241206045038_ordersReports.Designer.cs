﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reporting.DataConetion;

#nullable disable

namespace Reporting.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20241206045038_ordersReports")]
    partial class ordersReports
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Reporting.Models.orders_reports", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("order_id")
                        .HasColumnType("int");

                    b.Property<decimal>("total_cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("total_profit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("total_revenue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("orders_reports");
                });

            modelBuilder.Entity("Reporting.Models.product_reports", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<decimal>("cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("order_report_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<decimal>("profit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("revenue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("total_sold")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("product_reports");
                });
#pragma warning restore 612, 618
        }
    }
}
