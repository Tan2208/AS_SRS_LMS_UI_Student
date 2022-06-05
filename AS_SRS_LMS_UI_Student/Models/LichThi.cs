using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class LichThi
    {
        [Key]
        public int LichThiId { get; set; }
        public DateTime NgayThi { get; set; }
        public MonHoc MonHoc { get; set; }
        public string HinhThucKiemTra { get; set; }

    }
}
