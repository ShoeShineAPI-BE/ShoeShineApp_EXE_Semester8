﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoeShineAPI.Infracstructure.DatabaseConnect;

#nullable disable

namespace ShoeShineAPI.Infracstructure.Migrations
{
    [DbContext(typeof(DbContextClass))]
    partial class DbContextClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("IsBookingStatus")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("StoreId");

                    b.ToTable("Booking", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsOrderStatus")
                        .HasColumnType("int");

                    b.Property<string>("OrderCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("QuantityItem")
                        .HasColumnType("int");

                    b.Property<float>("ShipFee")
                        .HasColumnType("real");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("OrderDetail", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<string>("AddInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("Payment", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentMethodId"));

                    b.Property<bool>("IsStatusMethod")
                        .HasColumnType("bit");

                    b.Property<string>("MethodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentMethodId");

                    b.ToTable("PaymentMethod", (string)null);
                });

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

            modelBuilder.Entity("ShoeShineAPI.Core.Model.CategoryStore", b =>
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

                    b.ToTable("CategoryStore", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.CommentStore", b =>
                {
                    b.Property<int>("CommentStoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentStoreId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("RatingId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CommentStoreId");

                    b.HasIndex("RatingId");

                    b.HasIndex("StoreId");

                    b.HasIndex("UserId");

                    b.ToTable("CommentStore", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ImageComment", b =>
                {
                    b.Property<int>("ImageCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageCommentId"));

                    b.Property<int>("CommentStoreId")
                        .HasColumnType("int");

                    b.Property<string>("ImageCommentURL")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ImageCommentId");

                    b.HasIndex("CommentStoreId");

                    b.ToTable("ImageComment", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ImageStore", b =>
                {
                    b.Property<int>("ImageStoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageStoreId"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("ImageStoreId");

                    b.HasIndex("StoreId");

                    b.ToTable("ImageStore", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Product", b =>
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

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingId"));

                    b.Property<int>("RatingScale")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.ToTable("Rating", (string)null);
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

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ServiceStore", b =>
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

                    b.ToTable("ServiceStore", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"));

                    b.Property<bool>("IsStoreStatus")
                        .HasColumnType("bit");

                    b.Property<int>("RatingId")
                        .HasColumnType("int");

                    b.Property<string>("StoreAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StoreDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreEmal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StorePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreId");

                    b.HasIndex("RatingId");

                    b.ToTable("Store", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.User", b =>
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

                    b.Property<DateTime>("UserBirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("UserGender")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

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

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.Booking", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Category", "Category")
                        .WithMany("Bookings")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.Service", "Service")
                        .WithMany("Bookings")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.Store", "Store")
                        .WithMany("Bookings")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Service");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.Order", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.EntityModel.Payment", "Payment")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.OrderDetail", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.EntityModel.Booking", "Booking")
                        .WithOne("OrderDetail")
                        .HasForeignKey("ShoeShineAPI.Core.EntityModel.OrderDetail", "BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.EntityModel.Order", "Order")
                        .WithOne("OrderDetail")
                        .HasForeignKey("ShoeShineAPI.Core.EntityModel.OrderDetail", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.Payment", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.EntityModel.PaymentMethod", "PaymentMethod")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.CategoryStore", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Category", "Category")
                        .WithMany("CategoryStores")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.Store", "Store")
                        .WithMany("CategoryStores")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.CommentStore", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Rating", "Ratings")
                        .WithMany("Comment")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.Store", "Store")
                        .WithMany("Comments")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ratings");

                    b.Navigation("Store");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ImageComment", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.CommentStore", "CommentStore")
                        .WithMany("ImageComments")
                        .HasForeignKey("CommentStoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommentStore");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ImageStore", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Store", "Store")
                        .WithMany("Images")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Product", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.ServiceStore", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Service", "Service")
                        .WithMany("ServiceStores")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoeShineAPI.Core.Model.Store", "Store")
                        .WithMany("ServiceStores")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Store", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Rating", "Ratings")
                        .WithMany("Stores")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.User", b =>
                {
                    b.HasOne("ShoeShineAPI.Core.Model.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.Booking", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.Order", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.Payment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.EntityModel.PaymentMethod", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Category", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("CategoryStores");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.CommentStore", b =>
                {
                    b.Navigation("ImageComments");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Rating", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("Stores");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Service", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("ServiceStores");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.Store", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("CategoryStores");

                    b.Navigation("Comments");

                    b.Navigation("Images");

                    b.Navigation("ServiceStores");
                });

            modelBuilder.Entity("ShoeShineAPI.Core.Model.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
