using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class NienKhoa
    {
        [Key]
        public int NienKhoaId { get; set; }
        public string NienKhoaName { get; set; }
    }
}
