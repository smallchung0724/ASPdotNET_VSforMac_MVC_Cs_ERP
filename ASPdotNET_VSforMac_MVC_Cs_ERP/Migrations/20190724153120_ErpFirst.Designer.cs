﻿// <auto-generated />
using System;
using ASPdotNET_VSforMac_MVC_Cs_ERP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPdotNET_VSforMac_MVC_Cs_ERP.Migrations
{
    [DbContext(typeof(ErpContext))]
    [Migration("20190724153120_ErpFirst")]
    partial class ErpFirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Custom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Contact_person")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("Createdate");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Telphone")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("TitleId");

                    b.HasKey("Id");

                    b.HasIndex("TitleId");

                    b.ToTable("Customs");
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Deliver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contact_person")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("Createdate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Telphone")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Delivers");
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Createdate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<DateTime>("Createdate");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Ename")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Salary");

                    b.Property<string>("Telphone")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("TitleId");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Order_detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Createdate");

                    b.Property<int>("Order_masterId");

                    b.Property<decimal>("Price");

                    b.Property<int>("Product_dataId");

                    b.Property<decimal>("Quality");

                    b.HasKey("Id");

                    b.HasIndex("Order_masterId");

                    b.HasIndex("Product_dataId");

                    b.ToTable("Order_details");
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Order_master", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<decimal>("Charges");

                    b.Property<DateTime>("Createdate");

                    b.Property<int>("CustomId");

                    b.Property<int>("DeliverId");

                    b.Property<DateTime>("Deliverydate");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("Orderdate");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Receiver")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CustomId");

                    b.HasIndex("DeliverId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Order_masters");
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Product_data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Createdate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Order_quality");

                    b.Property<decimal>("Price");

                    b.Property<int>("Product_itemId");

                    b.Property<decimal>("Safe_quality");

                    b.Property<decimal>("Stock_quality");

                    b.Property<int>("SupplyId");

                    b.Property<string>("Unit_quality")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Product_itemId");

                    b.HasIndex("SupplyId");

                    b.ToTable("Product_datas");
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Product_item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Createdate");

                    b.Property<string>("Descripcition")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Product_items");
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Supply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Contact_person")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("Creadedate");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Telphone")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("TitleId");

                    b.HasKey("Id");

                    b.HasIndex("TitleId");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Createdate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Custom", b =>
                {
                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Title", "Title")
                        .WithMany("Customs")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Employee", b =>
                {
                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Title", "Title")
                        .WithMany("Employees")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Order_detail", b =>
                {
                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Order_master", "Order_master")
                        .WithMany()
                        .HasForeignKey("Order_masterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Product_data", "Product_data")
                        .WithMany("Order_datails")
                        .HasForeignKey("Product_dataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Order_master", b =>
                {
                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Custom", "Custom")
                        .WithMany("Order_masters")
                        .HasForeignKey("CustomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Deliver", "Deliver")
                        .WithMany("Order_masters")
                        .HasForeignKey("DeliverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Employee", "Employee")
                        .WithMany("Order_masters")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Product_data", b =>
                {
                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Product_item", "Product_item")
                        .WithMany("Product_datas")
                        .HasForeignKey("Product_itemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Supply", "Supply")
                        .WithMany("Product_datas")
                        .HasForeignKey("SupplyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Supply", b =>
                {
                    b.HasOne("ASPdotNET_VSforMac_MVC_Cs_ERP.Models.Title", "Title")
                        .WithMany("Supplys")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
