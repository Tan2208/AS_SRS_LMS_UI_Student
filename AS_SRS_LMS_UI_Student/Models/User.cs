using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS_UI_Student.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } 
        public Role Role { get; set; }
        public HocSinh HocSinh { get; set; }
        public GiangVien GiangVien { get; set; }
        
    }
}
