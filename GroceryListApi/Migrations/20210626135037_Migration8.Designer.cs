﻿// <auto-generated />
using GoceryListApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoceryListApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210626135037_Migration8")]
    partial class Migration8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoceryListApi.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ListId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("GoceryListApi.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Lists");
                });

            modelBuilder.Entity("GoceryListApi.Models.Item", b =>
                {
                    b.HasOne("GoceryListApi.Models.List", "List")
                        .WithMany("Items")
                        .HasForeignKey("ListId")
                        .HasConstraintName("FK_Items_Lists")
                        .IsRequired();

                    b.Navigation("List");
                });

            modelBuilder.Entity("GoceryListApi.Models.List", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
