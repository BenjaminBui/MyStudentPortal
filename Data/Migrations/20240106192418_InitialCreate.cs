using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongThongTin.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    table.ForeignKey(
                        name: "FK_DiemRenLuyen_HocKy_HocKyId",
                        column: x => x.HocKyId,
                        principalTable: "HocKy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_ChuongTrinhDaoTaoHocPhan_ChuongTrinhDaoTao_ChuongTrinhDaoTaoId",
                        column: x => x.ChuongTrinhDaoTaoId,
                        principalTable: "ChuongTrinhDaoTao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChuongTrinhDaoTaoHocPhan_HocPhan_HocPhanId",
                        column: x => x.HocPhanId,
                        principalTable: "HocPhan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LopHocPhan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSoHocPhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongSinhVien = table.Column<int>(type: "int", nullable: false),
                    HocPhanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HocKyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocPhan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LopHocPhan_HocKy_HocKyId",
                        column: x => x.HocKyId,
                        principalTable: "HocKy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LopHocPhan_HocPhan_HocPhanId",
                        column: x => x.HocPhanId,
                        principalTable: "HocPhan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Phong_KyTucXa_KTXId",
                        column: x => x.KTXId,
                        principalTable: "KyTucXa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    VaiTroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NguoiDung_ChuongTrinhDaoTao_ChuongTrinhDaoTaoId",
                        column: x => x.ChuongTrinhDaoTaoId,
                        principalTable: "ChuongTrinhDaoTao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NguoiDung_VaiTro_VaiTroId",
                        column: x => x.VaiTroId,
                        principalTable: "VaiTro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Diem_HocPhan_HocPhanId",
                        column: x => x.HocPhanId,
                        principalTable: "HocPhan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diem_LopHocPhan_LopHocPhanId",
                        column: x => x.LopHocPhanId,
                        principalTable: "LopHocPhan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Diem_NguoiDung_SinhVienId",
                        column: x => x.SinhVienId,
                        principalTable: "NguoiDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_HocPhi_HocKy_HocKyId",
                        column: x => x.HocKyId,
                        principalTable: "HocKy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocPhi_HocPhan_HocPhanId",
                        column: x => x.HocPhanId,
                        principalTable: "HocPhan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocPhi_NguoiDung_SinhVienId",
                        column: x => x.SinhVienId,
                        principalTable: "NguoiDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_LopHocPhanSinhVien_LopHocPhan_LopHocPhanId",
                        column: x => x.LopHocPhanId,
                        principalTable: "LopHocPhan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LopHocPhanSinhVien_NguoiDung_SinhVienId",
                        column: x => x.SinhVienId,
                        principalTable: "NguoiDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_PhongSinhVien_NguoiDung_SinhVienId",
                        column: x => x.SinhVienId,
                        principalTable: "NguoiDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhongSinhVien_Phong_PhongId",
                        column: x => x.PhongId,
                        principalTable: "Phong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_ThoiKhoaBieu_LopHocPhan_LopHocPhanId",
                        column: x => x.LopHocPhanId,
                        principalTable: "LopHocPhan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThoiKhoaBieu_NguoiDung_GiangVienId",
                        column: x => x.GiangVienId,
                        principalTable: "NguoiDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThongBao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaoLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaoBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapNhatLuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapNhatBoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThongBao_NguoiDung_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "NguoiDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinhDaoTaoHocPhan_ChuongTrinhDaoTaoId",
                table: "ChuongTrinhDaoTaoHocPhan",
                column: "ChuongTrinhDaoTaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinhDaoTaoHocPhan_HocPhanId",
                table: "ChuongTrinhDaoTaoHocPhan",
                column: "HocPhanId");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_HocPhanId",
                table: "Diem",
                column: "HocPhanId");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_LopHocPhanId",
                table: "Diem",
                column: "LopHocPhanId");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_SinhVienId",
                table: "Diem",
                column: "SinhVienId");

            migrationBuilder.CreateIndex(
                name: "IX_DiemRenLuyen_HocKyId",
                table: "DiemRenLuyen",
                column: "HocKyId");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhi_HocKyId",
                table: "HocPhi",
                column: "HocKyId");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhi_HocPhanId",
                table: "HocPhi",
                column: "HocPhanId");

            migrationBuilder.CreateIndex(
                name: "IX_HocPhi_SinhVienId",
                table: "HocPhi",
                column: "SinhVienId");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocPhan_HocKyId",
                table: "LopHocPhan",
                column: "HocKyId");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocPhan_HocPhanId",
                table: "LopHocPhan",
                column: "HocPhanId");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocPhanSinhVien_LopHocPhanId",
                table: "LopHocPhanSinhVien",
                column: "LopHocPhanId");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocPhanSinhVien_SinhVienId",
                table: "LopHocPhanSinhVien",
                column: "SinhVienId");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_ChuongTrinhDaoTaoId",
                table: "NguoiDung",
                column: "ChuongTrinhDaoTaoId");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_VaiTroId",
                table: "NguoiDung",
                column: "VaiTroId");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_KTXId",
                table: "Phong",
                column: "KTXId");

            migrationBuilder.CreateIndex(
                name: "IX_PhongSinhVien_PhongId",
                table: "PhongSinhVien",
                column: "PhongId");

            migrationBuilder.CreateIndex(
                name: "IX_PhongSinhVien_SinhVienId",
                table: "PhongSinhVien",
                column: "SinhVienId");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiKhoaBieu_GiangVienId",
                table: "ThoiKhoaBieu",
                column: "GiangVienId");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiKhoaBieu_LopHocPhanId",
                table: "ThoiKhoaBieu",
                column: "LopHocPhanId");

            migrationBuilder.CreateIndex(
                name: "IX_ThongBao_NguoiDungId",
                table: "ThongBao",
                column: "NguoiDungId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChuongTrinhDaoTaoHocPhan");

            migrationBuilder.DropTable(
                name: "Diem");

            migrationBuilder.DropTable(
                name: "DiemRenLuyen");

            migrationBuilder.DropTable(
                name: "HocPhi");

            migrationBuilder.DropTable(
                name: "LichThi");

            migrationBuilder.DropTable(
                name: "LopHocPhanSinhVien");

            migrationBuilder.DropTable(
                name: "PhongSinhVien");

            migrationBuilder.DropTable(
                name: "ThoiKhoaBieu");

            migrationBuilder.DropTable(
                name: "ThongBao");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "LopHocPhan");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "KyTucXa");

            migrationBuilder.DropTable(
                name: "HocKy");

            migrationBuilder.DropTable(
                name: "HocPhan");

            migrationBuilder.DropTable(
                name: "ChuongTrinhDaoTao");

            migrationBuilder.DropTable(
                name: "VaiTro");
        }
    }
}
