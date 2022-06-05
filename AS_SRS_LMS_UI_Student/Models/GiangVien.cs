using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class GiangVien
    {
        [Key]
        public int GiangVienId { get; set; }
        public string TenGiangVien { get; set; }
        public string DayMon { get; set; }
    }
}
