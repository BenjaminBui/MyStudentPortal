﻿// <auto-generated />
using System;
using CongThongTin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CongThongTin.Migrations
{
    [DbContext(typeof(CongThongTinDbContext))]
    [Migration("20240106164158_AddForeignKey")]
    partial class AddForeignKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CongThongTin.Data.Entities.ChuongTrinhDaoTaoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChuongTrinhDaoTao");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.ChuongTrinhDaoTaoHocPhanEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ChuongTrinhDaoTaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("HocPhanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ChuongTrinhDaoTaoId");

                    b.HasIndex("HocPhanId");

                    b.ToTable("ChuongTrinhDaoTaoHocPhan");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.DemRenLuyenEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<int>("Diem")
                        .HasColumnType("int");

                    b.Property<Guid>("HocKyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DiemRenLuyen");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.DiemEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<int>("Diem")
                        .HasColumnType("int");

                    b.Property<Guid>("HocPhanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LopHocPhanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SinhVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Diem");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.HocKyEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGianBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianKetThuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HocKy");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.HocPhanEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<string>("MaHocPhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoTinChi")
                        .HasColumnType("int");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HocPhan");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.HocPhiEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaThanhToan")
                        .HasColumnType("bit");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("HocKyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HocPhanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SinhVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HocPhi");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.KyTucXaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<string>("MaKTX")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("KyTucXa");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.LichThiEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("GioBatDau")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("GioKetThuc")
                        .HasColumnType("time");

                    b.Property<Guid>("LopHocPhanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayThi")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LichThi");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.LopHocPhanEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("HocKyID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HocPhanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaSoHocPhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongSinhVien")
                        .HasColumnType("int");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LopHocPhan");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.LopHocPhanSinhVienEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("LopHocPhanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SinhVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LopHocPhanSinhVien");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.NguoiDungEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ChuongTrinhDaoTaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("HashMatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MSDD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VaiTro")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("NguoiDung");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.PhongEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("KTXId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuongSinhVien")
                        .HasColumnType("int");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Phong");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.PhongSinhVienEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("PhongId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SinhVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PhongSinhVien");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.ThoiKhoaBieuEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("GiangVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LopHocPhanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayHoc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianKetThuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ThoiKhoaBieu");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.ThongBaoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SinhVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ThongBao");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.VaiTroEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapNhatBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CapNhatLuc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("TaoBoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TaoLuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VaiTro");
                });

            modelBuilder.Entity("CongThongTin.Data.Entities.ChuongTrinhDaoTaoHocPhanEntity", b =>
                {
                    b.HasOne("CongThongTin.Data.Entities.ChuongTrinhDaoTaoEntity", "ChuongTrinhDaoTao")
                        .WithMany()
                        .HasForeignKey("ChuongTrinhDaoTaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CongThongTin.Data.Entities.HocPhanEntity", "HocPhan")
                        .WithMany()
                        .HasForeignKey("HocPhanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChuongTrinhDaoTao");

                    b.Navigation("HocPhan");
                });
#pragma warning restore 612, 618
        }
    }
}
