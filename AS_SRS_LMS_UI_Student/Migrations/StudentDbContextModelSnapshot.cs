﻿// <auto-generated />
using System;
using AS_SRS_LMS_UI_Student.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AS_SRS_LMS_UI_Student.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.BaiKiemTra", b =>
                {
                    b.Property<int>("BaiKiemTraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BaiKiemTraId"), 1L, 1);

                    b.Property<string>("FileKT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GiangVienId")
                        .HasColumnType("int");

                    b.Property<string>("HinhThucKT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonHocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayLam")
                        .HasColumnType("datetime2");

                    b.Property<string>("ThoiLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TinhTrang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BaiKiemTraId");

                    b.HasIndex("GiangVienId");

                    b.HasIndex("MonHocId");

                    b.ToTable("BaiKiemTras");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.BangDiem", b =>
                {
                    b.Property<int>("BangDiemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BangDiemId"), 1L, 1);

                    b.Property<double>("DiemTB")
                        .HasColumnType("float");

                    b.Property<int>("GiangVienLopHocId")
                        .HasColumnType("int");

                    b.Property<int>("HocSinhId")
                        .HasColumnType("int");

                    b.Property<string>("KetQua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonHocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayCapNhap")
                        .HasColumnType("datetime2");

                    b.HasKey("BangDiemId");

                    b.HasIndex("GiangVienLopHocId");

                    b.HasIndex("HocSinhId");

                    b.HasIndex("MonHocId");

                    b.ToTable("BangDiems");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.GiangVien", b =>
                {
                    b.Property<int>("GiangVienId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GiangVienId"), 1L, 1);

                    b.Property<string>("DayMon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenGiangVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GiangVienId");

                    b.ToTable("GiangViens");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.HocSinh", b =>
                {
                    b.Property<int>("HocSinhId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HocSinhId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotenHS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaHS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int>("NienKhoaId")
                        .HasColumnType("int");

                    b.HasKey("HocSinhId");

                    b.HasIndex("NienKhoaId");

                    b.ToTable("HocSinhs");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.KhoaHoc", b =>
                {
                    b.Property<int>("KhoaHocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KhoaHocId"), 1L, 1);

                    b.Property<int>("MaLopLopHocId")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonHocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKT")
                        .HasColumnType("datetime2");

                    b.Property<int>("NienKhoaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGianHoc")
                        .HasColumnType("datetime2");

                    b.Property<string>("TinhTrang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KhoaHocId");

                    b.HasIndex("MaLopLopHocId");

                    b.HasIndex("MonHocId");

                    b.HasIndex("NienKhoaId");

                    b.ToTable("KhoaHocs");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.LichThi", b =>
                {
                    b.Property<int>("LichThiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LichThiId"), 1L, 1);

                    b.Property<string>("HinhThucKiemTra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonHocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayThi")
                        .HasColumnType("datetime2");

                    b.HasKey("LichThiId");

                    b.HasIndex("MonHocId");

                    b.ToTable("LichThis");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.LopHoc", b =>
                {
                    b.Property<int>("LopHocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LopHocId"), 1L, 1);

                    b.Property<int>("GiangVienId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaBaoMat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LopHocId");

                    b.HasIndex("GiangVienId");

                    b.ToTable("LopHocs");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.MonHoc", b =>
                {
                    b.Property<int>("MonHocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonHocId"), 1L, 1);

                    b.Property<string>("TenMonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThoiLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TinhTrang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MonHocId");

                    b.ToTable("MonHocs");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.NienKhoa", b =>
                {
                    b.Property<int>("NienKhoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NienKhoaId"), 1L, 1);

                    b.Property<string>("NienKhoaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NienKhoaId");

                    b.ToTable("NienKhoas");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int>("GiangVienId")
                        .HasColumnType("int");

                    b.Property<int>("HocSinhId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("GiangVienId");

                    b.HasIndex("HocSinhId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.BaiKiemTra", b =>
                {
                    b.HasOne("AS_SRS_LMS_UI_Student.Models.GiangVien", "GiangVien")
                        .WithMany()
                        .HasForeignKey("GiangVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AS_SRS_LMS_UI_Student.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiangVien");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.BangDiem", b =>
                {
                    b.HasOne("AS_SRS_LMS_UI_Student.Models.LopHoc", "GiangVien")
                        .WithMany()
                        .HasForeignKey("GiangVienLopHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AS_SRS_LMS_UI_Student.Models.HocSinh", "HocSinh")
                        .WithMany()
                        .HasForeignKey("HocSinhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AS_SRS_LMS_UI_Student.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiangVien");

                    b.Navigation("HocSinh");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.HocSinh", b =>
                {
                    b.HasOne("AS_SRS_LMS_UI_Student.Models.NienKhoa", "NienKhoa")
                        .WithMany()
                        .HasForeignKey("NienKhoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NienKhoa");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.KhoaHoc", b =>
                {
                    b.HasOne("AS_SRS_LMS_UI_Student.Models.LopHoc", "MaLop")
                        .WithMany()
                        .HasForeignKey("MaLopLopHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AS_SRS_LMS_UI_Student.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AS_SRS_LMS_UI_Student.Models.NienKhoa", "NienKhoa")
                        .WithMany()
                        .HasForeignKey("NienKhoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaLop");

                    b.Navigation("MonHoc");

                    b.Navigation("NienKhoa");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.LichThi", b =>
                {
                    b.HasOne("AS_SRS_LMS_UI_Student.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.LopHoc", b =>
                {
                    b.HasOne("AS_SRS_LMS_UI_Student.Models.GiangVien", "GiangVien")
                        .WithMany()
                        .HasForeignKey("GiangVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiangVien");
                });

            modelBuilder.Entity("AS_SRS_LMS_UI_Student.Models.User", b =>
                {
                    b.HasOne("AS_SRS_LMS_UI_Student.Models.GiangVien", "GiangVien")
                        .WithMany()
                        .HasForeignKey("GiangVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AS_SRS_LMS_UI_Student.Models.HocSinh", "HocSinh")
                        .WithMany()
                        .HasForeignKey("HocSinhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AS_SRS_LMS_UI_Student.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiangVien");

                    b.Navigation("HocSinh");

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}