// <auto-generated />
using System;
using AssessmentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssessmentAPI.Migrations
{
    [DbContext(typeof(WeatherContext))]
    [Migration("20210523062632_Weather")]
    partial class Weather
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssessmentAPI.Models.Weather", b =>
                {
                    b.Property<string>("City")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Forecast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("HighTemp")
                        .HasColumnType("real");

                    b.Property<float>("LowTemp")
                        .HasColumnType("real");

                    b.HasKey("City");

                    b.ToTable("WeatherDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
