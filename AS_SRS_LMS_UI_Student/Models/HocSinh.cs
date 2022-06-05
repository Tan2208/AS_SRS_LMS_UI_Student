using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class HocSinh
    {
        [Key]
        public int HocSinhId { get; set; }
        public string MaHS { get; set; }
        public string HotenHS { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string Lop { get; set; }
        public NienKhoa NienKhoa { get; set; }
        
    }
}
