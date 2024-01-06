using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongThongTin.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChuongTrinhDaoTao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuongTrinhDaoTao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChuongTrinhDaoTaoHocPhan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChuongTrinhDaoTaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuongTrinhDaoTaoHocPhan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Diem = table.Column<int>(type: "int", nullable: false),
                    HocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SinhVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopHocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiemRenLuyen",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Diem = table.Column<int>(type: "int", nullable: false),
                    HocKyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemRenLuyen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocKy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocKy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocPhan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaHocPhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTinChi = table.Column<int>(type: "int", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocPhi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaThanhToan = table.Column<bool>(type: "bit", nullable: false),
                    SinhVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HocKyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KyTucXa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKTX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KyTucXa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LichThi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopHocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayThi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioBatDau = table.Column<TimeSpan>(type: "time", nullable: false),
                    GioKetThuc = table.Column<TimeSpan>(type: "time", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichThi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LopHocPhan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSoHocPhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongSinhVien = table.Column<int>(type: "int", nullable: false),
                    HocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HocKyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocPhan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LopHocPhanSinhVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SinhVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopHocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocPhanSinhVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MSDD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashMatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    ChuongTrinhDaoTaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VaiTro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuongSinhVien = table.Column<int>(type: "int", nullable: false),
                    KTXId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhongSinhVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhongId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SinhVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongSinhVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThoiKhoaBieu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayHoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiangVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopHocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoiKhoaBieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThongBao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinhVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VaiTro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTro", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChuongTrinhDaoTao");

            migrationBuilder.DropTable(
                name: "ChuongTrinhDaoTaoHocPhan");

            migrationBuilder.DropTable(
                name: "Diem");

            migrationBuilder.DropTable(
                name: "DiemRenLuyen");

            migrationBuilder.DropTable(
                name: "HocKy");

            migrationBuilder.DropTable(
                name: "HocPhan");

            migrationBuilder.DropTable(
                name: "HocPhi");

            migrationBuilder.DropTable(
                name: "KyTucXa");

            migrationBuilder.DropTable(
                name: "LichThi");

            migrationBuilder.DropTable(
                name: "LopHocPhan");

            migrationBuilder.DropTable(
                name: "LopHocPhanSinhVien");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "PhongSinhVien");

            migrationBuilder.DropTable(
                name: "ThoiKhoaBieu");

            migrationBuilder.DropTable(
                name: "ThongBao");

            migrationBuilder.DropTable(
                name: "VaiTro");
        }
    }
}
