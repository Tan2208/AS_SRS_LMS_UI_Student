using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AS_SRS_LMS_UI_Student.Migrations
{
    public partial class Student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiangViens",
                columns: table => new
                {
                    GiangVienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGiangVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DayMon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangViens", x => x.GiangVienId);
                });

            migrationBuilder.CreateTable(
                name: "MonHocs",
                columns: table => new
                {
                    MonHocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiLuong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHocs", x => x.MonHocId);
                });

            migrationBuilder.CreateTable(
                name: "NienKhoas",
                columns: table => new
                {
                    NienKhoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NienKhoaName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NienKhoas", x => x.NienKhoaId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "LopHocs",
                columns: table => new
                {
                    LopHocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiangVienId = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaBaoMat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocs", x => x.LopHocId);
                    table.ForeignKey(
                        name: "FK_LopHocs_GiangViens_GiangVienId",
                        column: x => x.GiangVienId,
                        principalTable: "GiangViens",
                        principalColumn: "GiangVienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaiKiemTras",
                columns: table => new
                {
                    BaiKiemTraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonHocId = table.Column<int>(type: "int", nullable: false),
                    HinhThucKT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiangVienId = table.Column<int>(type: "int", nullable: false),
                    NgayLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiLuong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileKT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiKiemTras", x => x.BaiKiemTraId);
                    table.ForeignKey(
                        name: "FK_BaiKiemTras_GiangViens_GiangVienId",
                        column: x => x.GiangVienId,
                        principalTable: "GiangViens",
                        principalColumn: "GiangVienId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaiKiemTras_MonHocs_MonHocId",
                        column: x => x.MonHocId,
                        principalTable: "MonHocs",
                        principalColumn: "MonHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichThis",
                columns: table => new
                {
                    LichThiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayThi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonHocId = table.Column<int>(type: "int", nullable: false),
                    HinhThucKiemTra = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichThis", x => x.LichThiId);
                    table.ForeignKey(
                        name: "FK_LichThis_MonHocs_MonHocId",
                        column: x => x.MonHocId,
                        principalTable: "MonHocs",
                        principalColumn: "MonHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocSinhs",
                columns: table => new
                {
                    HocSinhId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotenHS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NienKhoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinhs", x => x.HocSinhId);
                    table.ForeignKey(
                        name: "FK_HocSinhs_NienKhoas_NienKhoaId",
                        column: x => x.NienKhoaId,
                        principalTable: "NienKhoas",
                        principalColumn: "NienKhoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHocs",
                columns: table => new
                {
                    KhoaHocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonHocId = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianHoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayBD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaLopLopHocId = table.Column<int>(type: "int", nullable: false),
                    NienKhoaId = table.Column<int>(type: "int", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHocs", x => x.KhoaHocId);
                    table.ForeignKey(
                        name: "FK_KhoaHocs_LopHocs_MaLopLopHocId",
                        column: x => x.MaLopLopHocId,
                        principalTable: "LopHocs",
                        principalColumn: "LopHocId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhoaHocs_MonHocs_MonHocId",
                        column: x => x.MonHocId,
                        principalTable: "MonHocs",
                        principalColumn: "MonHocId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhoaHocs_NienKhoas_NienKhoaId",
                        column: x => x.NienKhoaId,
                        principalTable: "NienKhoas",
                        principalColumn: "NienKhoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BangDiems",
                columns: table => new
                {
                    BangDiemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HocSinhId = table.Column<int>(type: "int", nullable: false),
                    MonHocId = table.Column<int>(type: "int", nullable: false),
                    GiangVienLopHocId = table.Column<int>(type: "int", nullable: false),
                    DiemTB = table.Column<double>(type: "float", nullable: false),
                    KetQua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCapNhap = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangDiems", x => x.BangDiemId);
                    table.ForeignKey(
                        name: "FK_BangDiems_HocSinhs_HocSinhId",
                        column: x => x.HocSinhId,
                        principalTable: "HocSinhs",
                        principalColumn: "HocSinhId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BangDiems_LopHocs_GiangVienLopHocId",
                        column: x => x.GiangVienLopHocId,
                        principalTable: "LopHocs",
                        principalColumn: "LopHocId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BangDiems_MonHocs_MonHocId",
                        column: x => x.MonHocId,
                        principalTable: "MonHocs",
                        principalColumn: "MonHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    HocSinhId = table.Column<int>(type: "int", nullable: false),
                    GiangVienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_GiangViens_GiangVienId",
                        column: x => x.GiangVienId,
                        principalTable: "GiangViens",
                        principalColumn: "GiangVienId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_HocSinhs_HocSinhId",
                        column: x => x.HocSinhId,
                        principalTable: "HocSinhs",
                        principalColumn: "HocSinhId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaiKiemTras_GiangVienId",
                table: "BaiKiemTras",
                column: "GiangVienId");

            migrationBuilder.CreateIndex(
                name: "IX_BaiKiemTras_MonHocId",
                table: "BaiKiemTras",
                column: "MonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_BangDiems_GiangVienLopHocId",
                table: "BangDiems",
                column: "GiangVienLopHocId");

            migrationBuilder.CreateIndex(
                name: "IX_BangDiems_HocSinhId",
                table: "BangDiems",
                column: "HocSinhId");

            migrationBuilder.CreateIndex(
                name: "IX_BangDiems_MonHocId",
                table: "BangDiems",
                column: "MonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_NienKhoaId",
                table: "HocSinhs",
                column: "NienKhoaId");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaHocs_MaLopLopHocId",
                table: "KhoaHocs",
                column: "MaLopLopHocId");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaHocs_MonHocId",
                table: "KhoaHocs",
                column: "MonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaHocs_NienKhoaId",
                table: "KhoaHocs",
                column: "NienKhoaId");

            migrationBuilder.CreateIndex(
                name: "IX_LichThis_MonHocId",
                table: "LichThis",
                column: "MonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocs_GiangVienId",
                table: "LopHocs",
                column: "GiangVienId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GiangVienId",
                table: "Users",
                column: "GiangVienId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_HocSinhId",
                table: "Users",
                column: "HocSinhId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaiKiemTras");

            migrationBuilder.DropTable(
                name: "BangDiems");

            migrationBuilder.DropTable(
                name: "KhoaHocs");

            migrationBuilder.DropTable(
                name: "LichThis");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "LopHocs");

            migrationBuilder.DropTable(
                name: "MonHocs");

            migrationBuilder.DropTable(
                name: "HocSinhs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "GiangViens");

            migrationBuilder.DropTable(
                name: "NienKhoas");
        }
    }
}
