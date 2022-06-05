using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class BangDiem
    {
        [Key]
        public int BangDiemId { get; set; }
        public HocSinh HocSinh { get; set; }
        public MonHoc MonHoc { get; set; }
        public LopHoc GiangVien { get; set; }
        public double DiemTB { get; set; }
        public string KetQua { get; set; }
        public DateTime NgayCapNhap { get; set; }

    }
}
