﻿// <auto-generated />
using JWT_Authentication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JWT_Authentication.Migrations
{
    [DbContext(typeof(JWTAuthContext))]
    [Migration("20190827122054_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("JWT_Authentication.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("RoleId");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            Name = "Manager"
                        },
                        new
                        {
                            RoleId = 3,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("JWT_Authentication.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Firstname");

                    b.Property<string>("Gender");

                    b.Property<string>("Lastname");

                    b.Property<string>("Password");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Firstname = "Hosea",
                            Gender = "Male",
                            Lastname = "Burton",
                            Password = "Hosea@123",
                            Username = "hosea.b@jwt.com"
                        },
                        new
                        {
                            UserId = 2,
                            Firstname = "Colin",
                            Gender = "Male",
                            Lastname = "Kaepernick",
                            Password = "Colin@123",
                            Username = "colin.k@jwt.com"
                        },
                        new
                        {
                            UserId = 3,
                            Firstname = "Juan",
                            Gender = "Male",
                            Lastname = "Cole",
                            Password = "Juan@123",
                            Username = "juan.c@jwt.com"
                        },
                        new
                        {
                            UserId = 4,
                            Firstname = "James",
                            Gender = "Male",
                            Lastname = "Baldwin",
                            Password = "James@123",
                            Username = "james.b@jwt.com"
                        },
                        new
                        {
                            UserId = 5,
                            Firstname = "Thomas",
                            Gender = "Male",
                            Lastname = "Parisi",
                            Password = "Thomas@123",
                            Username = "thomas.p@jwt.com"
                        },
                        new
                        {
                            UserId = 6,
                            Firstname = "Ferguson",
                            Gender = "Male",
                            Lastname = "Jenkins",
                            Password = "Ferguson@123",
                            Username = "ferguson.j@jwt.com"
                        },
                        new
                        {
                            UserId = 7,
                            Firstname = "Sonali",
                            Gender = "Female",
                            Lastname = "Sharma",
                            Password = "Sonali@123",
                            Username = "sonali.s@jwt.com"
                        },
                        new
                        {
                            UserId = 8,
                            Firstname = "Eric",
                            Gender = "Male",
                            Lastname = "Margolis",
                            Password = "Eric@123",
                            Username = "eric.m@jwt.com"
                        },
                        new
                        {
                            UserId = 9,
                            Firstname = "Charles",
                            Gender = "Male",
                            Lastname = "Pierce",
                            Password = "Charles@123",
                            Username = "charles.p@jwt.com"
                        },
                        new
                        {
                            UserId = 10,
                            Firstname = "Pierre",
                            Gender = "Male",
                            Lastname = "Tristam",
                            Password = "Pierre@123",
                            Username = "pierre.t@jwt.com"
                        },
                        new
                        {
                            UserId = 11,
                            Firstname = "Juliette",
                            Gender = "Male",
                            Lastname = "Majot",
                            Password = "Juliette@123",
                            Username = "juliette.m@jwt.com"
                        },
                        new
                        {
                            UserId = 12,
                            Firstname = "Shane",
                            Gender = "Male",
                            Lastname = "Ryan",
                            Password = "Shane@123",
                            Username = "shane.r@jwt.com"
                        },
                        new
                        {
                            UserId = 13,
                            Firstname = "Karen",
                            Gender = "Female",
                            Lastname = "Kinney",
                            Password = "Karen@123",
                            Username = "karen.k@jwt.com"
                        },
                        new
                        {
                            UserId = 14,
                            Firstname = "Robert",
                            Gender = "Male",
                            Lastname = "Lipsyte",
                            Password = "Robert@123",
                            Username = "robert.l@jwt.com"
                        },
                        new
                        {
                            UserId = 15,
                            Firstname = "Leonard",
                            Gender = "Male",
                            Lastname = "Junior",
                            Password = "Leonard@123",
                            Username = "leonard.j@jwt.com"
                        });
                });

            modelBuilder.Entity("JWT_Authentication.Models.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("UserRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            UserRoleId = 1,
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            UserRoleId = 2,
                            RoleId = 1,
                            UserId = 2
                        },
                        new
                        {
                            UserRoleId = 3,
                            RoleId = 1,
                            UserId = 3
                        },
                        new
                        {
                            UserRoleId = 4,
                            RoleId = 2,
                            UserId = 4
                        },
                        new
                        {
                            UserRoleId = 5,
                            RoleId = 2,
                            UserId = 5
                        },
                        new
                        {
                            UserRoleId = 6,
                            RoleId = 3,
                            UserId = 6
                        },
                        new
                        {
                            UserRoleId = 7,
                            RoleId = 3,
                            UserId = 7
                        },
                        new
                        {
                            UserRoleId = 8,
                            RoleId = 3,
                            UserId = 8
                        },
                        new
                        {
                            UserRoleId = 9,
                            RoleId = 3,
                            UserId = 9
                        },
                        new
                        {
                            UserRoleId = 10,
                            RoleId = 3,
                            UserId = 10
                        },
                        new
                        {
                            UserRoleId = 11,
                            RoleId = 3,
                            UserId = 11
                        },
                        new
                        {
                            UserRoleId = 12,
                            RoleId = 3,
                            UserId = 12
                        },
                        new
                        {
                            UserRoleId = 13,
                            RoleId = 3,
                            UserId = 13
                        },
                        new
                        {
                            UserRoleId = 14,
                            RoleId = 3,
                            UserId = 14
                        },
                        new
                        {
                            UserRoleId = 15,
                            RoleId = 3,
                            UserId = 15
                        });
                });

            modelBuilder.Entity("JWT_Authentication.Models.UserRole", b =>
                {
                    b.HasOne("JWT_Authentication.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JWT_Authentication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}