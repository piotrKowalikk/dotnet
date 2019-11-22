﻿// <auto-generated />
using System;
using HR.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HR.DataAccess.Migrations
{
    [DbContext(typeof(HR_ProjectContext))]
    [Migration("20191121210520_job offers user posting types")]
    partial class joboffersuserpostingtypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HR.DataAccess.Models.JobOffer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnName("company")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<DateTime>("DateExpiration")
                        .HasColumnName("dateExpiration")
                        .HasColumnType("date");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnName("datePosted")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnName("isActive");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnName("position")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int?>("SalaryFrom")
                        .HasColumnName("salaryFrom");

                    b.Property<int?>("SalaryTo")
                        .HasColumnName("salaryTo");

                    b.Property<string>("UserApply")
                        .HasColumnName("userApply");

                    b.Property<string>("UserPosting")
                        .HasColumnName("userPosting");

                    b.HasKey("Id");

                    b.ToTable("APP_JOBOFFERS");
                });

            modelBuilder.Entity("HR.DataAccess.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnName("roleName")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("DCT_ROLES");
                });

            modelBuilder.Entity("HR.DataAccess.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(30);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(20);

                    b.Property<string>("NameIdentifier");

                    b.Property<int>("RoleId")
                        .HasColumnName("roleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("APP_USERS");
                });

            modelBuilder.Entity("HR.DataAccess.Models.User", b =>
                {
                    b.HasOne("HR.DataAccess.Models.Role", "Role")
                        .WithMany("AppUsers")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_APP_USERS_DCT_ROLES");
                });
#pragma warning restore 612, 618
        }
    }
}
