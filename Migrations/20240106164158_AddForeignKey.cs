using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongThongTin.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinhDaoTaoHocPhan_ChuongTrinhDaoTaoId",
                table: "ChuongTrinhDaoTaoHocPhan",
                column: "ChuongTrinhDaoTaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinhDaoTaoHocPhan_HocPhanId",
                table: "ChuongTrinhDaoTaoHocPhan",
                column: "HocPhanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuongTrinhDaoTaoHocPhan_ChuongTrinhDaoTao_ChuongTrinhDaoTaoId",
                table: "ChuongTrinhDaoTaoHocPhan",
                column: "ChuongTrinhDaoTaoId",
                principalTable: "ChuongTrinhDaoTao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChuongTrinhDaoTaoHocPhan_HocPhan_HocPhanId",
                table: "ChuongTrinhDaoTaoHocPhan",
                column: "HocPhanId",
                principalTable: "HocPhan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuongTrinhDaoTaoHocPhan_ChuongTrinhDaoTao_ChuongTrinhDaoTaoId",
                table: "ChuongTrinhDaoTaoHocPhan");

            migrationBuilder.DropForeignKey(
                name: "FK_ChuongTrinhDaoTaoHocPhan_HocPhan_HocPhanId",
                table: "ChuongTrinhDaoTaoHocPhan");

            migrationBuilder.DropIndex(
                name: "IX_ChuongTrinhDaoTaoHocPhan_ChuongTrinhDaoTaoId",
                table: "ChuongTrinhDaoTaoHocPhan");

            migrationBuilder.DropIndex(
                name: "IX_ChuongTrinhDaoTaoHocPhan_HocPhanId",
                table: "ChuongTrinhDaoTaoHocPhan");
        }
    }
}
