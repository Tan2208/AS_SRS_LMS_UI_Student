using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class BaiKiemTra
    {
        [Key]
        public int BaiKiemTraId { get; set; }
        public MonHoc MonHoc { get; set; }
        public string HinhThucKT { get; set; }
        public GiangVien GiangVien { get; set; }
        public DateTime NgayLam { get; set; }
        public string ThoiLuong { get; set; }
        public string TinhTrang { get; set; }
        public string FileKT { get; set; }

    }
}
