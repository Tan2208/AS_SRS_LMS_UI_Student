using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class KhoaHoc
    {
        [Key]
        public int KhoaHocId { get; set; }
        public MonHoc MonHoc { get; set; }

        public string  MoTa { get; set; }
        public DateTime ThoiGianHoc { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public LopHoc MaLop { get; set; }
        public NienKhoa NienKhoa { get; set; }
        public string TinhTrang { get; set; }
    }
}
