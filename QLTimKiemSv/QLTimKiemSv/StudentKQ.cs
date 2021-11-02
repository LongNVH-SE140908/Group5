using System.ComponentModel;

namespace QLTimKiemSv
{
    public class StudentKQ
    {
        [DisplayName("Mã Môn Học")]
        public string MaMh { get; set; }
        [DisplayName("Tên Môn Học")]
        public string TenMh { get; set; }
        [DisplayName("Điểm Thi")]
        public double DiemThi { get; set; }
        public StudentKQ()
        {
           
        }
    }
}