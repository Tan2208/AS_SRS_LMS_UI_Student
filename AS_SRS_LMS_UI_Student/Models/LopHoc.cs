using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class LopHoc
    {
        [Key]
        public int LopHocId { get; set; }
        public string Lop { get; set; }
        public GiangVien GiangVien { get; set; }
        public string Link { get; set; }
        public string MaBaoMat { get; set; }
        public string TrangThai { get; set; }

    }
}
