﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoeShineAPI.Infracstructure.DatabaseConnect;

#nullable disable

namespace ShoeShineAPI.Infracstructure.Migrations
{
    [DbContext(typeof(DbContextClass))]
    [Migration("20230918141903_fixRating")]
    partial class fixRating
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsCategoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.CategoryStoreEntity", b =>
                {
                    b.Property<int>("CategoryStoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryStoreId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("CategoryStoreId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("StoreId");

                    b.ToTable("CategoryStoreEntity", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("RatingCommentId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CommentId");

                    b.HasIndex("ProductId");

                    b.HasIndex("RatingCommentId")
                        .IsUnique();

                    b.HasIndex("StoreId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("Image", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ImageComment", b =>
                {
                    b.Property<int>("ImageCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageCommentId"));

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<string>("ImageCommentURL")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ImageCommentId");

                    b.HasIndex("CommentId");

                    b.ToTable("ImageComment", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ProductEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsProductStatus")
                        .HasColumnType("bit");

                    b.Property<float>("ProductAmount")
                        .HasColumnType("real");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("ProductPrice")
                        .HasColumnType("real");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductEntity", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.RatingComment", b =>
                {
                    b.Property<int>("RatingCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingCommentId"));

                    b.Property<int>("RatingCommentScale")
                        .HasColumnType("int");

                    b.HasKey("RatingCommentId");

                    b.ToTable("RatingComment", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.RatingStoresEntity", b =>
                {
                    b.Property<int>("RatingStoresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingStoresId"));

                    b.Property<int>("RatingStoreScale")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("RatingStoresId");

                    b.HasIndex("StoreId")
                        .IsUnique();

                    b.ToTable("RatingStoresEntity", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("RoleId");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<bool>("IsServiceStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<float>("ServicePrice")
                        .HasColumnType("real");

                    b.HasKey("ServiceId");

                    b.ToTable("Service", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ServiceStoreEntity", b =>
                {
                    b.Property<int>("ServiceStoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceStoreId"));

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("ServiceStoreId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("StoreId");

                    b.ToTable("ServiceStoreEntity", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.StoreEntity", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"));

                    b.Property<bool>("IsStoreStatus")
                        .HasColumnType("bit");

                    b.Property<string>("StoreAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StoreDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StoreId");

                    b.ToTable("StoreEntity", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.UserEntity", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsUserStatus")
                        .HasColumnType("bit");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserAccount")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserEntity", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.CategoryStoreEntity", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Category", "Category")
                        .WithMany("CategoryStores")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.StoreEntity", "StoreEntity")
                        .WithMany("CategoryStores")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("StoreEntity");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Comment", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.ProductEntity", "ProductEntity")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.RatingComment", "RatingComment")
                        .WithOne("Comment")
                        .HasForeignKey("ShoeShineAPI.Core.Model.Comment", "RatingCommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Rating_Comment");

                    b.HasOne("ShoeShineAPI.Core.Model.StoreEntity", "StoreEntity")
                        .WithMany("Comments")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.UserEntity", "UserEntity")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductEntity");

                    b.Navigation("RatingComment");

                    b.Navigation("StoreEntity");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Image", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.ProductEntity", "ProductEntity")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.StoreEntity", "StoreEntity")
                        .WithMany("Images")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductEntity");

                    b.Navigation("StoreEntity");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ImageComment", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Comment", null)
                        .WithMany("ImageComments")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ProductEntity", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.RatingStoresEntity", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.StoreEntity", "StoreEntity")
                        .WithOne("RatingStoresEntity")
                        .HasForeignKey("ShoeShineAPI.Core.Model.RatingStoresEntity", "StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Rating_Store");

                    b.Navigation("StoreEntity");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ServiceStoreEntity", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Service", "Service")
                        .WithMany("ServiceStores")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.StoreEntity", "StoreEntity")
                        .WithMany("ServiceStores")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("StoreEntity");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.UserEntity", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Category", b =>
                {
                    b.Navigation("CategoryStores");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Comment", b =>
                {
                    b.Navigation("ImageComments");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ProductEntity", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.RatingComment", b =>
                {
                    b.Navigation("Comment");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Service", b =>
                {
                    b.Navigation("ServiceStores");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.StoreEntity", b =>
                {
                    b.Navigation("CategoryStores");

                    b.Navigation("Comments");

                    b.Navigation("Images");

                    b.Navigation("RatingStoresEntity");

                    b.Navigation("ServiceStores");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.UserEntity", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
