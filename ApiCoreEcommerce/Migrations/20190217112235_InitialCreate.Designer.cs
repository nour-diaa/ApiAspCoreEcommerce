﻿// <auto-generated />
using System;
using ApiCoreEcommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiCoreEcommerce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190217112235_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ApplicationUserId");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.ApplicationRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<long>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Metadata");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<long>("ModifyBy");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<string>("Slug");

                    b.Property<int>("Status");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.ApplicationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.AppUserRole", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<long>("RoleId");

                    b.Property<long?>("RoleId1");

                    b.Property<long?>("UserId2");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId2");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CommentId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<long>("ProductId");

                    b.Property<int?>("Rating");

                    b.Property<long>("RatingId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.FileUpload", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FileName");

                    b.Property<string>("FilePath");

                    b.Property<long>("FileSize");

                    b.Property<string>("OriginalFileName");

                    b.Property<bool>("isFeaturedImage");

                    b.HasKey("Id");

                    b.ToTable("FileUploads");

                    b.HasDiscriminator<string>("Discriminator").HasValue("FileUpload");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AddressId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("OrderStatus");

                    b.Property<string>("TrackingNumber");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long>("OrderId");

                    b.Property<int>("Price");

                    b.Property<long>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<string>("Slug");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Price");

                    b.Property<DateTime>("PublishAt");

                    b.Property<string>("Slug")
                        .IsRequired();

                    b.Property<int>("Stock");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.ProductCategory", b =>
                {
                    b.Property<long>("CategoryId");

                    b.Property<long>("ProductId");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.ProductTag", b =>
                {
                    b.Property<long>("TagId");

                    b.Property<long>("ProductId");

                    b.HasKey("TagId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTag");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Rating", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CommentId");

                    b.Property<long?>("CommentId1");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<long>("ProductId");

                    b.Property<long>("UserId");

                    b.Property<long>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CommentId1");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<long>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.CategoryImage", b =>
                {
                    b.HasBaseType("ApiCoreEcommerce.Entities.FileUpload");

                    b.Property<long>("CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryImage");

                    b.HasDiscriminator().HasValue("CategoryImage");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.ProductImage", b =>
                {
                    b.HasBaseType("ApiCoreEcommerce.Entities.FileUpload");

                    b.Property<long>("ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");

                    b.HasDiscriminator().HasValue("ProductImage");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.TagImage", b =>
                {
                    b.HasBaseType("ApiCoreEcommerce.Entities.FileUpload");

                    b.Property<long>("TagId");

                    b.HasIndex("TagId");

                    b.ToTable("TagImage");

                    b.HasDiscriminator().HasValue("TagImage");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Address", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationUser", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.AppUserRole", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId1");

                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId2");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Comment", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.Comment")
                        .WithMany("Replies")
                        .HasForeignKey("CommentId");

                    b.HasOne("ApiCoreEcommerce.Entities.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Order", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.OrderItem", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApiCoreEcommerce.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.ProductCategory", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApiCoreEcommerce.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.ProductTag", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.Product", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductId");

                    b.HasOne("ApiCoreEcommerce.Entities.Tag", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.Rating", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.Comment", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId1");

                    b.HasOne("ApiCoreEcommerce.Entities.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationUser", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.CategoryImage", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.Category", "Category")
                        .WithMany("CategoryImages")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.ProductImage", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApiCoreEcommerce.Entities.TagImage", b =>
                {
                    b.HasOne("ApiCoreEcommerce.Entities.Tag", "Tag")
                        .WithMany("TagImages")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
