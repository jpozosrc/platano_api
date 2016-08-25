using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PlatanoApi.Model;

namespace platano_api.Migrations
{
    [DbContext(typeof(PlatanoDbContext))]
    [Migration("20160825142213_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("PlatanoApi.Model.AutomationCommand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommandArgs");

                    b.Property<string>("CommandText");

                    b.Property<Guid>("DeviceId");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AutomationCommand");
                });

            modelBuilder.Entity("PlatanoApi.Model.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("Device");
                });
        }
    }
}
