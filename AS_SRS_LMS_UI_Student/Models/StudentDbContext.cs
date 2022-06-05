using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class StudentDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<LopHoc> LopHocs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<NienKhoa> NienKhoas { get; set; }
        public DbSet<LichThi> LichThis { get; set; }
        public DbSet<BaiKiemTra> BaiKiemTras { get; set; }
        public DbSet<BangDiem> BangDiems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(LocalDB)\MSSQLLocalDB;Database=Student;Trusted_Connection=True");
        }

    }
}
