using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class MonHoc
    {
        [Key]
        public int MonHocId { get; set; }
        public string TenMonHoc { get; set; }   
        public string ThoiLuong { get; set; }
        public string TinhTrang { get; set; }

    }
}
